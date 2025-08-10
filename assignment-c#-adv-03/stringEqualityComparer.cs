using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class stringEqualityComparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
          
            string? X = x as string;
            string? Y = y as string;
            return X?.ToLower().Equals(Y?.ToLower()) ?? false;
        }

        public int GetHashCode(object obj)
        {
            string?value = obj as string;
            if (value != null)
            {
                return value.ToLower().GetHashCode();
            }
            else
            {
                throw new ArgumentException("Object is not a string");
            }
                
        }

       
    }
}
