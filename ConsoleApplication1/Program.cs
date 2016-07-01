using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_01
{
    public class MooBot
    {
        private DiscordClient bot;
        //When created
        public MooBot()
        {
            bot = new DiscordClient();
            bot.MessageReceived += Bot_MessageReceived1; ;
            bot.Connect("botmoo's-future-email@gmail.com", "placeholder");
            bot.ExecuteAndWait();
        }
        //When msg recieved
        private void Bot_MessageReceived1(object sender, MessageEventArgs e)
        {
            int cntr = 0;

            if (e.Message.IsAuthor) return;

            if (e.Message.Text == "!moo")
            {
                e.Channel.SendMessage(e.User.Mention + "It's a secret ;)");
            }
            if (e.Message.Text.ToLower().Contains("who is moobot"))
            {
                e.Channel.SendMessage(e.User.Mention + "Moobot is a mostly useless discord bot designed to be Doji's arch enemy");
            }
            if (e.Message.Text.ToLower().Contains("who made moobot"))
            {
                e.Channel.SendMessage(e.User.Mention + "Preheat, I'm sad to say. It's his fault I'm so useless.");
            }
            if (e.Message.Text.ToLower().Contains("moo"))
            {
                e.Channel.SendMessage("moo.");
            }
            if (e.Message.Text.ToLower().Contains("doji moo"))
            {
                if (cntr == 0)
                {
                    e.Channel.SendMessage("That's my line.");
                    ++cntr;
                }
                if (cntr == 1)
                {
                    e.Channel.SendMessage("I'm the one who moos!");
                    ++cntr;
                }
                if (cntr == 2)
                {
                    e.Channel.SendMessage("Now you're making me ANGRY");
                    ++cntr;
                }
                if (cntr == 3)
                {
                    e.Channel.SendMessage(" /kick doji");
                    cntr = 0;
                }

            }
        }

        
    }
}
