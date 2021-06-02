﻿using ChatBlazorApp.Client.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBlazorApp.Client
{
    public class AppState
    {
        public string UserName { get; set; }
        public List<string> Rooms { get; set; } = new List<string>();
        public string RoomsCommaSeparated { get; set; }
        public Action AppStateUpdated { get; set; }
        public Room CurrentRoom { get; set; }
    }
}
