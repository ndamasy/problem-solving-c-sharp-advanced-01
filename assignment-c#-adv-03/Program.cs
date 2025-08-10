using System.Collections;
using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region non generec collection (Hash table)

            // Hashtable hashtable = new Hashtable()
            // {
            //     { "Mona" , 444 },
            //     { "Ahmed" , 888 },
            //     { "Mohamed" , 240}

            // };

            // foreach (DictionaryEntry entry in hashtable)
            // {
            //     //Console.WriteLine($"{entry.Key} : {entry.Value}");
            // }

            // #region hash table indexer
            // // using indexer to get value
            // Console.WriteLine(hashtable["Mona"]); // 444
            // // using indexer to set value
            //Console.WriteLine (hashtable["Mona"] = 555);
            // // adding new value
            // hashtable["Ali"] = 999;
            // Console.WriteLine(hashtable["Ali"]); // 999
            // //check if key exists
            // if(!hashtable.ContainsKey("Mona"))
            // {
            //     hashtable.Add("Mona" , 555);
            // }
            // else
            // {
            //     Console.WriteLine("Mona does  exists in the hashtable");
            // }
            //#endregion

            #endregion

            #region generic collection (Dictionary)
            // Dictionary<string, int> dictionary = new Dictionary<string, int>()
            // {
            //     { "Mona" , 444 },
            //     { "Ahmed" , 888 },
            //     { "Mohamed" , 240}
            // };
            // //foreach (KeyValuePair<string, int> entry in dictionary)
            // //{
            // //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            // //}
            //foreach (var Name in dictionary.Keys)
            // {
            //     Console.WriteLine(Name);
            // }


            #endregion

            #region generic collection sorted dictionary

            //SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>(new string_comparer())
            // {
            //     { "ali" , 444 },
            //     { "omar" , 888 },
            //     { "ahmed" , 240}
            // };

            // foreach (var item  in sortedDictionary)
            // {
            //     Console.WriteLine(item);
            // }



            #endregion

            #region generic collection sorted list

            //SortedList sortedList = new SortedList()
            //{
            //    { "ali" , 111 },
            //    { "omar" , 777 },
            //    { "ahmed" , 555}
            //};

            // string name= sortedList.GetKey(1).ToString();
            //int number = sortedList.GetByIndex(1).GetHashCode();
            //Console.WriteLine(number); // 777
            //Console.WriteLine(name); // omar
            //foreach (var  item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region generic collection hash set

           HashSet<string> hashSet = new HashSet<string>()
            {
                "ali",
                "omar",
                "ahmed",
                "ali"
            };
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
