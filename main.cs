using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTestSender
{
    class main
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            Nachricht testobjekt = new Nachricht();

            //Achtung Propertys der Klasse Nachricht müssen public sein!
            string json1 = JsonConvert.SerializeObject(testobjekt);            

            string url = "http://localhost:5000/api/Nachrichten";

            //senden
            Task<HttpResponseMessage> response = client.PostAsJsonAsync(url, json1);

            try
            {
                response.Wait();
            }
            catch (Exception)
            {
                return;
            }

            //Antwort auslesen
            HttpResponseMessage result = response.Result;

            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch(Exception)
            {

            }

            string empfang = content.Result;

            List<string> zurueck = JsonConvert.DeserializeObject<List<string>>(empfang);
        }
    }
}
