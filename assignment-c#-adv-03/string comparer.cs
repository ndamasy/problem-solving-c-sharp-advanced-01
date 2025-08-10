using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class string_comparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
           
                return y?.CompareTo(x) ?? 0;
            
            ;
        }
    }
}
