using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionExample
{
    public class MockPostsService : IPostsService
    {
        public Task<IEnumerable<Post>> GetPosts()
        {
            return new Task<IEnumerable<Post>>(() =>
            {
                return new List<Post>()
                {
                    new Post() { Id = 1, Title = "Mock Post 1" , Body = "Mock Body 1", UserId = 1, CreatedAt = new DateTime()},
                    new Post() { Id = 2, Title = "Mock Post 2" , Body = "Mock Body 2", UserId = 1, CreatedAt = new DateTime()},
                    new Post() { Id = 3, Title = "Mock Post 3" , Body = "Mock Body 3", UserId = 2, CreatedAt = new DateTime()}
                };
            });
        }
    }
}
