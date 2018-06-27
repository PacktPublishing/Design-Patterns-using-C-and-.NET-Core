using System;

namespace DependencyInversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var manager = new PostsManager(new MockPostsService());
            var manager = new PostsManager(new PostsService());
        }
    }
}
