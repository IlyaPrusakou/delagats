using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delagats
{
    public static class StringFormatter //homework
    {
        public static List<string> Formatter(this List<string> list, Func<string, string> del)//homework
        {
            List<string> ResultString = new List<string>();//homework
            foreach (string item in list)//homework
            {
                string result = del(item);//homework
                ResultString.Add(result);//homework
            }
            return ResultString;//homework
        }
    }

    class Program
    {
        public static string MakeToUpper(string str)
        {
            string result = str.ToUpper();
            return result;
        }
        public static string ChangeSpaces(string str)
        {
            string result = str.Replace(" ", "-");
            return result;
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("ddd");
            list.Add("d d d");
            list.Add("aaa");
            list.Add("a a a");
            list.Add("sss");
            list.Add("s s s");
            list.Add("fff");
            list.Add("f f f");
            list.Add("ddhhh");
            //Func<string, string> myfunc = MakeToUpper;
            Func<string, string> myfunc = ChangeSpaces;
            List<string> result = list.Formatter(myfunc);

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
