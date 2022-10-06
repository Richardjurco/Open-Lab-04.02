using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string result = string.Empty;
             for (int a = 0;a < original.Length;a++)
            {
                result = result + original[a] + original[a];
            }return result;
            
        }
    }
}
