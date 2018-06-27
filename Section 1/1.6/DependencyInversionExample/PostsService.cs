using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionExample
{
    public class PostsService : IPostsService
    {
        public async Task<IEnumerable<Post>> GetPosts()
        {
            using (var http = new HttpClient())
            {
                var postsJson = await http.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
                return JsonConvert.DeserializeObject<IEnumerable<Post>>(postsJson);
            }
        }
    }
}
