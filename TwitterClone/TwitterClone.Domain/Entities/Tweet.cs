namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public string Content { get; private set; }

        public DateTime CreatedAT { get; private set; } = DateTime.UtcNow;

        // Foreign Key
        public Guid UserId { get; private set; }

        //Navigation Property
        public User User { get; private set; } = null!;

        public Tweet(string content, DateTime createdAT, Guid userId)
        {
            Content = content;
            UserId = userId;
        }
    }
}
