using Domain;
using Newtonsoft.Json;
using System.Linq;
using System.Net;


namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext dataContext)
        {
            var lunches = GetLaunches();
            dataContext.Launches.AddRange(lunches);
            dataContext.SaveChanges();
            var test = dataContext.Launches.ToList();
        }

        private static List<Launche> GetLaunches()
        {
            const string SPACEX_URL = "https://api.spacexdata.com/v3/launches";
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(SPACEX_URL));
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Launche>>(jsonString);
        }
    }
}
