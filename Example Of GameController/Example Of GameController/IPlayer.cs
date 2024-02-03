using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_GameController
{
    public interface IPlayer
    {
        string GetName();
        int GetId();
        string GetPlayerCondition();
    }
}
