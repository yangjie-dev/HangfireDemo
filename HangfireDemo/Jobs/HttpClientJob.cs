using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HangfireDemo.Jobs
{
    public class HttpClientJob
    {
        public async Task SendGetRequest()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://www.accelist.com");
            Console.WriteLine(string.Format("Request Status: {0} - {1}", response.StatusCode, DateTime.Now));
        }
    }
}
