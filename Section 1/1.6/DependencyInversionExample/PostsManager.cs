using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionExample
{
    public class PostsManager
    {
        private IPostsService _service;

        public PostsManager(IPostsService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<Post>> FilterPosts()
        {
            var posts = await _service.GetPosts();
            List<Post> keptPosts = new List<Post>();
            foreach (var post in posts)
            {
                if(post.Body.Length <= 120)
                {
                    keptPosts.Add(post);
                }
            }
            return keptPosts;
        }
    }
}
