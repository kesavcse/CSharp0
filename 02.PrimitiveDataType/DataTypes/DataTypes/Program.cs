
using System;

class Program
{
    static void Main()
    {
        bool val = true;
        if (val)
        {
            Console.WriteLine(val == true);
        }
        val = !val;
        if (!val)
        {
            Console.WriteLine(val == false);
        }
    }
}