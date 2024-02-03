using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_GameController
{
    public class GameController
    {
        private readonly IPlayer _player;

        public GameController(IPlayer player)
        {
            _player = player;
        }


        public void PlayerChecker()
        {
            Console.WriteLine($"Player Condition {_player.GetPlayerCondition()}");

            if(_player.GetPlayerCondition() == "online") 
            {
                string onlineId = ((OnlinePlayer)_player).GetOnlineID();
                Console.WriteLine($"Online ID : {onlineId}");
            }

            else if (_player.GetPlayerCondition() == "offline")
            {
                Console.WriteLine("you play while offline");
            }
        }
    }
}
