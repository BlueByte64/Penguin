using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using DSharpPlus;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using DSharpPlus.SlashCommands;
using Penguin.Boot;
using DSharpPlus.Interactivity;
using DSharpPlus.EventArgs;

namespace Penguin
{
    internal class Bot
    {
        private static DiscordClient Client { get; set; }
        private static SlashCommandsExtension SlashCommandsExtension { get; set; }
        private static InteractivityExtension InteractivityExtension { get; set; }
        static async Task Main(string[] args)
        {
            try
            {
                JsonReader jsonReader = new JsonReader();
                DiscordConfiguration discordConfig = new DiscordConfiguration()
                {
                    Intents = DiscordIntents.All,
                    Token = jsonReader.token,
                    TokenType = TokenType.Bot,
                    AutoReconnect = true,
                };
                Client = new DiscordClient(discordConfig);
                Client.Ready += Client_Ready;

                await Client.ConnectAsync();
                await Task.Delay(-1);
            }
            catch (Exception E)
            {
                Console.WriteLine("Something seems wrong.. try checking your token on Data.json file and open the program again");
            }
        }
        private static Task Client_Ready(DiscordClient sender, ReadyEventArgs args)
        {
            return Task.CompletedTask;
        }
    }
}