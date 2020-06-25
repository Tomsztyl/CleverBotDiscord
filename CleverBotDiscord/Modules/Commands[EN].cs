using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using NPoco.Expressions;

namespace TutorialBot.Modules
{
    public class Commands_EN_ : ModuleBase<SocketCommandContext>
    {
        [Command("What time is it")]
        public async Task TimeNow()
        {
            DateTime localDate = DateTime.Now;

            await Context.Channel.SendMessageAsync("Time: " + localDate + " :flag_pl: ");
        }
    }
}
