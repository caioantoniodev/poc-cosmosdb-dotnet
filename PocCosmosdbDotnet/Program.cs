using PocDapperDotnet.Data;
using PocDapperDotnet.Domain;

using var repository = new BlogRepo();

var post = new Post
{
    Title = "Wow, this was cool (if it worked)"
};

var blog = new Blog
{
    Title = "The simplest blog",
    Description = "hello, world!"
};

blog.Posts.Add(post);

repository.Add(blog);

repository.SaveChanges();

repository.FindAll().ForEach(b => Console.WriteLine(b.Title));
