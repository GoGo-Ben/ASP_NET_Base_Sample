using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG5_To_Unicode_UTF8
{
    class Program
    {
        static void Main(string[] args)
        {
            //參考來源 http://blog.darkthread.net/post-2016-10-10-utf8-big5-encoding-ef-bf-bd-issue.aspx
            //嚙踝蕭嚙踝蕭
            Encoding big5 = Encoding.GetEncoding(950);
            Encoding utf8 = Encoding.UTF8;

            string raw = "嚙踝蕭嚙踝蕭";
            byte[] b = big5.GetBytes(raw);
            string dec = utf8.GetString(b);

            //嚙踝蕭嚙踝蕭 是用Big5 解析UTF8 ���� 字元
            Debug.WriteLine(dec);
            //EF-BF-BD 是UTF8 解碼錯誤的無效字元符號
            Debug.WriteLine(BitConverter.ToString(utf8.GetBytes(dec.Substring(0, 1))));

            raw = "多想兩分鐘，你可以不要用BIG5";
            //正常內容存成BIG5，卻用　UTF8 解析
            b = big5.GetBytes(raw);
            dec = utf8.GetString(b);
            Debug.WriteLine("轉出大量� - " + dec);
            //將成串的�內容存成 UTF8，再用Big5 解一次
            b = utf8.GetBytes(dec);
            dec = big5.GetString(b);
            Debug.WriteLine("轉出大量嚙踝蕭 - " + dec);

            raw = "多想兩分鐘，你可以不要用BIG5";
            b = utf8.GetBytes(raw);
            dec = utf8.GetString(b);
            Debug.WriteLine("中文 => UTF8 => UTF8 - " + dec);

            Console.Read();
        }
    }
}
