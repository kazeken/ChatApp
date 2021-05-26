﻿using ChatBlazorApp.Server.Data;
using ChatBlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace ChatBlazorApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly PreviousChatArchive previousChatArchive;

        public ChatController(PreviousChatArchive PreviousChatArchive)
        {
            previousChatArchive = PreviousChatArchive;
        }
        [HttpGet("{roomName}")]
        public IEnumerable<ChatData> Get([FromRoute] string roomName)
        {
            if (previousChatArchive.Chats.ContainsKey(roomName))

            return previousChatArchive.Chats[roomName];
            return new ChatData[0];
        }
    }
}