using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System.Net.Http;

namespace ShoppingCart_MicroService_Sh
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUri = "http://*:8080";
            // in debug in visual studio you will need 
            //string baseUri = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseUri))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseUri + "api/shoppingcart").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                var baseUriString = baseUri + "api/shoppingcart";
                Console.WriteLine("ShoppingCart Service running at {0} - press Enter to quit. ", baseUriString);
                Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri);
                Console.WriteLine("I'm running on {0} directly from assembly {1}", Environment.OSVersion, System.Reflection.Assembly.GetEntryAssembly().FullName);
                Console.ReadLine();
            }
        }
    }
}
