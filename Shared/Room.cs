using System;
using System.Collections.Generic;

namespace BettingTrivia.Shared
{
    public class Room
    {
        public Guid ID { get; set; }

        public List<User> Users { get; set; }

        public Room()
        {
            ID = Guid.NewGuid();
        }
    }
}