using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_GameController
{
    public class OnlinePlayer : IPlayer
    {
        private int _id;
        private string _name;
        public OnlinePlayer(int id, string name)
        {
            _id = id;

            _name = name;

        }
        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPlayerCondition()
        {
            return "online";
        }

        public string GetOnlineID()
        {
;          return "Markenji";
        }
    }
}
