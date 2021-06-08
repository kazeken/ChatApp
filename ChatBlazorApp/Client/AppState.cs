using ChatBlazorApp.Client.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBlazorApp.Client
{
    public class AppState
    {
        public string UserName { get; set; }
        public List<(string RoomName, int NotificationCount)> Rooms { get; set; } = new List<(string, int)>();
        public string RoomsCommaSeparated { get; set; }
        public Action AppStateUpdated { get; set; }
        public Room CurrentRoom { get; set; }
    }
}
