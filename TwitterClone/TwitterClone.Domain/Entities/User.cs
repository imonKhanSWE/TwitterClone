namespace TwitterClone.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }

        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        // Navigation Properties
        public ICollection<Tweet> Tweets { get; private set; } = new List<Tweet>();

        public User(
        
            string firstName,
            string lastName,
            string username,
            string emial,
            string passwordHash)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = username;
            Email = emial;
            PasswordHash = passwordHash;
        }

    }
}
