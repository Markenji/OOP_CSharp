using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading;

public class Calculator
{
    private string hello;
    public Calculator(string hello)
    {

        this.hello = hello;

    }
    public Calculator()
    {
        
    }

    public string Hello()
    {
        return hello;
    }

    public int Add(int x, int y)
    {
        return x + y;
    }

    public float Add(float x, float y)
    {
        return x + y;
    }

    public int Sub(int x, int y)
    {
        return x - y;
    }

    public float Sub(float x, float y)
    {
        return x - y;
    }

}