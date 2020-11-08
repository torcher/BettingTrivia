using BettingTrivia.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BettingTrivia.Server.Services
{
    public class RoomService : IRoomService
    {
        private List<Room> roomsDb = new List<Room>();

        public Room CreateRoom()
        {
            var room = new Room();
            roomsDb.Add(room);
            return room;
        }

        public Room GetRoom(Guid id)
        {
            return roomsDb.SingleOrDefault(r => r.ID == id);
        }
    }
}