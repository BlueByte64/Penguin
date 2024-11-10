using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Penguin.Boot
{
    public class JsonReader
    {
        class JsonData
        {
            public DiscordBotData DiscordBot { get; set; }
            public class DiscordBotData
            {
                public string Token { get; set; }
            }
        }
        static JsonData data = JsonSerializer.Deserialize<JsonData>(File.ReadAllText("Data.json"));
        public string token = data.DiscordBot.Token;
    }
}