namespace PocDapperDotnet.Domain
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public DateTime Created { get; private set; } = DateTime.Now;
    }
}