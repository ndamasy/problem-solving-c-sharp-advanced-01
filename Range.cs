using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace assignment_c__advanced_01
{
    internal class Range
    {
        public int max { get; set; }
        public int min { get; set; }

        public Range(int _max , int _min)
        {
            max = _max;
            min = _min;
        }

        public static bool IsInRange<T>( T[] numbers , T value)
        { 
        
         if(numbers is not null)
            {
                for(int i =0; i<numbers.Length; i++)
                {
                 if ( numbers[i].Equals(value))
                    {
                        return true;
                    }
                  
                   
                }
            }
            return false;
        }


        public static int Length<T>(T[] numbers)
        {
            if(numbers is not null)
            {
                return numbers.Length;
            }
            return 0;
        }



        //public override string ToString()
        //{
        //    return $"max :{max} \n min :{min}";
        //}





    }
}
