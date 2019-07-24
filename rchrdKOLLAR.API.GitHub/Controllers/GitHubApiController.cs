using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using rchrdKOLLAR.Constants;

namespace rchrdKOLLAR.API.GitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubApiController : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();

        // GET api/github
        [HttpGet]
        public ActionResult<string> Get()
        { 
            string info = "";
            info += "Welcome to the the simple API visualisation\n";
            info += "\n";
            info += "Current apis \n";
            info += "\tTwitter \n";
            info += "\tGitHub \n";
            info += "\t\t githubapi\\{GitHubUserName} \n";

            return info;
        }

        // GET api/github/{}
        [HttpGet("{gitHubUsername}")]
        public async Task<ActionResult<Model.GithubUser>> Get(string gitHubUsername)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                AddHeaders();
                HttpResponseMessage response = await client.GetAsync(Constants.Constants.githubAPIUser + gitHubUsername);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                //string responseBody = await client.GetStringAsync(uri);
                Console.WriteLine(responseBody);

                var userDetail = JsonConvert.DeserializeObject<Model.GithubUser>(responseBody);
                return userDetail;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return new GitHub.Model.GithubUser();
        }

        private static void AddHeaders()
        {
            // text/plain
            // application/xml
            var appHeder = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(item: appHeder);
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
        }
    }
}
