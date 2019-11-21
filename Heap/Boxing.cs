using System;
using System.Collections.Generic;
using System.Linq;


namespace Heap
{
    public class App
    {
        public static void Main(string[] args)
        {
	        int a = 5;
	        int b = 6;
	        
	        int c = GetMaxValue(a, b);
        }
        
        private static int GetMaxValue(object n1, object n2) // Boxing.
        {
            int a = (int)n1; // UnBoxing.
            int b = (int)n2; // UnBoxing.
            
            if (a >= b)
            {
                return a;
            }
            
            return b;
        }
    }
}
