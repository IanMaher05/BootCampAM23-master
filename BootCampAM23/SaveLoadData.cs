using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BootCampAM23
{
    public static class SaveLoadData
    {
        public static void SavePlayerData(Player p)
        {
            string jsP = JsonSerializer.Serialize(p);
            Console.WriteLine(jsP);
            string fileName = "e:\\vgd\\AMPlayer.txt";
            File.WriteAllText(fileName, jsP);

        }

        public static Player LoadPlayerData (Player p)
        {
            string fileName = "e:\\vgd\\AMPlayer.txt";
            string jsP = File.ReadAllText(fileName);
            Player x = JsonSerializer.Deserialize<Player>(jsP);
            return x;
        }

    }
}
