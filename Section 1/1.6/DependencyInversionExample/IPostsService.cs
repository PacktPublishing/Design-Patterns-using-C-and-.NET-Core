using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionExample
{
    public interface IPostsService
    {
        Task<IEnumerable<Post>> GetPosts();
    }
}
