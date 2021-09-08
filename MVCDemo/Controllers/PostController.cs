using MVCDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace MVCDemo.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> ListPosts()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            List<Post> post = new List<Post>();
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                post = JsonConvert.DeserializeObject<List<Post>>(body);
            }
            return View(post);
        }
    }
}