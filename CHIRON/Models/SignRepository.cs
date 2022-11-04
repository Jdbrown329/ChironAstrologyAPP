using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CHIRON.Models
{
    public class SignRepository
    {
        public VedicRishiNetClient client = new VedicRishiNetClient("621096", "d30d5cea7c037b24121d31fd1c79d5e8");

        public IEnumerable<CHIRON_SIGNS> ApiReturn()
        {

            var apiEndPoint = "western_horoscope/";
          

            Dictionary<string, double> reqObject = new Dictionary<string, double>();

            reqObject.Add("day", 29);
            reqObject.Add("month", 03);
            reqObject.Add("year", 1990);
            reqObject.Add("hour", 00);
            reqObject.Add("min", 32);
            reqObject.Add("lat", 19.206);
            reqObject.Add("lon", 72.80);
            reqObject.Add("tzone", 5.5);

            string requestData = JsonConvert.SerializeObject(reqObject);

            var response = client.makeRequest(apiEndPoint, requestData);

            var convertObj = JObject.Parse(response);


            var chiron = new CHIRON_SIGNS();
            chiron.sign_id = (int)convertObj["planets"][11]["sign_id"];

            chiron.house = (int)convertObj["planets"][11]["house"];
            var chironList= new List<CHIRON_SIGNS>() {chiron};  
            return chironList;

        }
    }


}
