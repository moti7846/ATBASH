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
            string n;
            n = " ";
            decodedMessage = n;
        }

        static int pointCounter(string[] masamessage)
        {

            return 0;
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

        static void Main(string args)
        {
            deCoding(args);
            warning(decodedMessage);
            pointCounter(warningName);
        }
    }
}
