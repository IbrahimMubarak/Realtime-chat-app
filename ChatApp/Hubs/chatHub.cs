using ChatApp.Data;
using ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _ctx;
        private readonly UserManager<User> _users;
        public ChatHub(ApplicationDbContext ctx, UserManager<User> users)
        {
            _ctx = ctx;
            _users = users;
        }

        public override async Task OnConnectedAsync()
        {
           
            var user = new UserConnection
            {
                Username = Context.User.Identity.Name,
                ConnectionId = Context.ConnectionId
            };
            //await Clients.All.SendAsync("Online", user.Username);

            await _ctx.userConnections.AddAsync(user);
            await _ctx.SaveChangesAsync();

        }
        

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var user = await _ctx.userConnections.Where(u => u.ConnectionId == Context.ConnectionId).FirstOrDefaultAsync();
            _ctx.userConnections.Remove(user);
            _ctx.SaveChanges();
            
        }

        
            public async Task SendMessage(string user, string message)
        {
            if (message != "")
            {
                await Clients.All.SendAsync("ReceiveMessage", user, message);
                var u = await _users.FindByNameAsync(user);
                var mess = new Message()
                {
                    SenderUsername = user,
                    ResiverUsername = "all",
                    Text = message,
                    read = false,
                    time = DateTime.Now,
                    userid = u.Id
                };
                if (mess.Text != "")
                {
                    await _ctx.Messages.AddAsync(mess);
                    await _ctx.SaveChangesAsync();
                }
            }
        }
    }
}