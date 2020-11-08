using BettingTrivia.Shared;
using System;

namespace BettingTrivia.Server.Services
{
    public interface IRoomService
    {
        Room CreateRoom();

        Room GetRoom(Guid id);
    }
}