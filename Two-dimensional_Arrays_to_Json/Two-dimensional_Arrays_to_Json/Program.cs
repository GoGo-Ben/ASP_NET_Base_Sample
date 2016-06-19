using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Two_dimensional_Arrays_to_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> myTwoArray = new List<List<string>>();
            List<string> myArray = new List<string>();

            // loop 
            myArray.Add("1");
            myArray.Add("5");
            myTwoArray.Add(myArray);
            // end loop

            List<string> myArray2 = new List<string>();
            myArray2.Add("10");
            myArray2.Add("15");
            myTwoArray.Add(myArray2);
            //myTwoArray supposed be  [ [1,2],[3,4] ]

            //verify 
            //Equivalent to myTwoArray[0][0]
            //Equivalent to myTwoArray[0][1]
            List<String> temp = myTwoArray[0];
            //Console.WriteLine(temp[0]);
            //Console.WriteLine(temp[1]);

            // 2nd times 
            List<String> temp2 = myTwoArray[1];
            //Console.WriteLine(temp2[0]);
            //Console.WriteLine(temp2[1]);

            var str_json = JsonConvert.SerializeObject(myTwoArray);
            var str_json2 = JsonConvert.SerializeObject(myTwoArray, Formatting.Indented);
            Console.WriteLine(str_json);
            Console.WriteLine(str_json2);
            Console.ReadLine();

        }
    }
}
