using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ATFUC
{
    class Program
    {
        public static void Main()
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://bsxmdn.ml/data.txt","fileins_0.txt");
            string reply0 = client.DownloadString("http://bsxmdn.ml");


            Console.WriteLine("ATFUC V1.0 | hacking | target: http://bsxmdn.ml/");
            int count = 0; 
            while (true)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">>");
                Console.ForegroundColor = ConsoleColor.Gray;
                switch (Console.ReadLine()) {
                    case "install data":
                        {
                            count = (count + 1);
                            Console.WriteLine(System.IO.File.ReadAllText("fileins_0.txt"));
                            break;
                        }
                    case "install data $f":
                        {
                            count = (count + 1);
                            System.IO.File.WriteAllText("data.txt", System.IO.File.ReadAllText("fileins_0.txt"));
                            break;
                        }
                    case "install pageindex $f":
                        {
                            count = (count + 1);
                            System.IO.File.WriteAllText("data.txt", reply0);
                            break;
                        }
                    case "install pageindex":
                        {
                            count = (count + 1);
                            Console.WriteLine(reply0);
                            break;
                        }
                    case "exit":
                        {
                            count = (count + 1);
                            Environment.Exit(0);
                            break;
                        }
                    case "clear":
                        {
                            
                            Console.Clear();
                            break;
                        }

                }
            }
        }
    }
}
