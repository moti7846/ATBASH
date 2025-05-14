using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH
{
    internal class Program
    {
        static string[] warningName;
        static string decodedMessage;
        static int pointM;
        static void deCoding(string input)
        {
            string message;
            message = input.ToLower();
            char[] data = { 'a', 'b', 'c' , 'd', 'e', 'f' , 'g', 'h', 
                            'i' ,'j', 'k', 'l' , 'm', 'n', 'o' , 'p', 
                            'q','r' ,'s', 't', 'u' , 'v', 'w', 'x' , 'y', 'z'};
            
            char response = 'a';
            string responseString = "";
            foreach (char c in message)
            {
                if (" /-.,![]()".Contains(c)) 
                {
                    responseString += c;
                    continue; 
                }
                
                int numberNow = ((int)c);
                
                if (numberNow < 123 && numberNow > 96)
                {
                    int calc = 123 - numberNow;
                    calc--;//בגלל המערך שמתחיל ב0
                    response = ((char)data[calc]);
                    responseString += response.ToString();
                }
            }
            message = responseString;
            decodedMessage = message;
        }

        static int pointCounter(string[] masamessage)
        {

            return 0;
        }

        static string warning(string input)
        {
            return "";
        }
        //static void printConsole()
        
        static void Main()
        {
            Console.WriteLine("");
            deCoding(Console.ReadLine);
            warning(decodedMessage);
            pointCounter(warningName);
        }
    }
}
