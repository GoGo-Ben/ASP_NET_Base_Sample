using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_ParameterDefaultValue
{
    class Program
    {
        private enum myEnum
        {
            我有10隻豬 = 10,
            我有20隻豬 = 20
        }

        static void Main(string[] args)
        {

            //數字轉字串，第二參數.ToString()代入
            inputData("10", 10.ToString());
            //因 strNumber = "" 所以第二個參數可以不用給，空字串無法轉型，故回傳convertToInt = 0
            inputData("10");

            inputStringData("我有20隻豬");
            Console.ReadLine();
        }

        /// <summary>
        /// 字串轉數字
        /// </summary>
        /// <param name="strData">字串</param>
        private static void inputStringData(string strData)
        {
            myEnum number;
            if (Enum.TryParse(strData, true, out number))
            {
                Console.WriteLine(strData + "," + (int)number);
            };
        }

        /// <summary>
        /// 數字轉字串，第二個參數轉成列舉對應的文字
        /// </summary>
        /// <param name="strText">輸入字串</param>
        /// <param name="strNumber">輸入字串</param>
        private static void inputData(string strText, string strNumber = "")
        {
            int convertToInt = 0;
            string convertToEnum = "";
            if (Int32.TryParse(strNumber, out convertToInt))
            {
                convertToEnum = ((myEnum)convertToInt).ToString();

            }
            Console.WriteLine(strText + "," + (myEnum)convertToInt);
            Console.WriteLine();
        }
    }
}
