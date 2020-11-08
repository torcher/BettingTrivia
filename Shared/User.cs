using System;

namespace BettingTrivia.Shared
{
    public class User
    {
        public Guid ID { get; set; }

        public UserRole Role { get; set; }

        public DateTime Create { get; set; } = DateTime.Now;

        public string Username { get; set; }

        public User()
        {
            ID = Guid.NewGuid();
        }
    }
}