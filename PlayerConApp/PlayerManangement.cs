using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlayerConApp
{
    public class PlayerManangement
    {
        static List<PlayersData> players = new List<PlayersData>()
        {
            new PlayersData{Id=1,Name="VK",Team="RCB",jerseyNumber=18},
            new PlayersData{Id=2,Name="MSD",Team="CSK",jerseyNumber=7},
            new PlayersData{Id=3,Name="Sachin",Team="MI", jerseyNumber=10},
            new PlayersData{Id=4,Name="Bumrah", Team="MI", jerseyNumber=93},
            new PlayersData{Id=5,Name="Rohit", Team="MI", jerseyNumber=45}
        };
        public List<PlayersData> GetData()
        {
            Console.WriteLine("Id\tName\tTeam\tJerseyNumber");
            foreach (PlayersData player in players)
            {
                Console.WriteLine($"{player.Id}\t{player.Name}\t{ player.Team}\t{player.jerseyNumber}");
}
            return players;
        }
        public PlayersData GetById(int id)
        {
            PlayersData player = players.FirstOrDefault(x => x.Id == id);
            if (player != null)
            {
                Console.WriteLine($"Id: {player.Id}\nName: {player.Name}\nTeam: {player.Team}\nJersey Number: {player.jerseyNumber}");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
            return player;
        }
    }
}
