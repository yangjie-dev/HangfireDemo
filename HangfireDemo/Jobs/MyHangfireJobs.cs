using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HangfireDemo.Jobs
{
    public class MyHangfireJobs
    {
        public async Task SendGetRequest()
        {
            var client = new HttpClient();
            await client.GetAsync("https://www.accelist.com");
        }
    }
}
