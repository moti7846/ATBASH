using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        //סוכם את כמות ההתראות
        static int pointCounter(string[] masamessage)
        {
            int counter = masamessage.Length;
            return counter;
        }
        //שומר את כל הפעמים שמופיע אזהרה
        static void warning(string input)
        {
            List<string> tempWarnings = new List<string> ();
            string[] warnings = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            string[] temp = input.Split(' ');
            foreach(string i in temp)
            {
                if (warnings.Contains(i))
                {
                    tempWarnings.Add(i);
                }
            }
            warningName = tempWarnings.ToArray();
        }

        //פונקציית הדפסה
        static void printConsole()
        {
          
        }

        
        static void Main()

        {
            Console.WriteLine("");
            deCoding(Console.ReadLine);
            warning(decodedMessage);
            pointCounter(warningName);
        }
    }
}
