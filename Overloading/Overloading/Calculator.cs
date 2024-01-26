using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading;

public class Calculator
{
    public Calculator()
    {
        
    }
    public int Add(int x, int y)
    { 
        return x + y; 
    }

    public float Add(float x, float y)
    {
        return x + y;
    }


}

