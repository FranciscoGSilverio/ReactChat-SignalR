using Microsoft.AspNetCore.SignalR;

namespace SignRChat.Hubs
{
    public class ChatHub:Hub
    {

        private readonly string _botUser;

        public ChatHub()
        {
            _botUser = "Nigth Bot";
        }

        public async Task JoinRoom(UserConnection userConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);
            await Clients.Group(userConnection.Room).SendAsync("Receive Message", _botUser, $"{userConnection.User} has joined {userConnection.Room}");
        }

    }
}
