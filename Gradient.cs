using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        public static string input_cmd;
        public static string[] input_args;
        public static string cmd;
        public static string grad_text;
        static void Main(string[] args)
        { // BASIC CLI SHIT. U CAN JUST SKIDRIP THE GRADIENT FUNCTION LIKE YOU WAS GONNAH DO 
            while (true)
            {
                input_cmd = Console.ReadLine();


                /*
                 * Command Parser
                */
                if (input_cmd.Contains(" "))
                {
                    input_args = input_cmd.Split(' ');
                    cmd = input_args[0];
                }
                ////////////////////////////////////////////////////
                

                // Command Handler
                if(input_cmd.StartsWith("grad"))
                { // grad 0,2,255 255,255,255 gradient_this
                    int[] startrgb;
                    int[] endrgb;
                    startrgb = Array.ConvertAll(input_args[1].Split(','), s => int.Parse(s));
                    endrgb = Array.ConvertAll(input_args[2].Split(','), s => int.Parse(s));

                    foreach(string arg in input_args)
                    {
                        if (arg == input_args[0]) continue;
                        if (arg == input_args[1]) continue;
                        if (arg == input_args[2]) continue;
                        grad_text += arg + " ";
                    }

                    Occupieds_Godly_Gradient_DLL.Gradient(startrgb, endrgb, grad_text);
                    
                }
            }
        }
    }
    /*
     * Gradient Tool IN C# BC IM A GOD.
     */
    class Occupieds_Godly_Gradient_DLL
    {
        public static void Gradient(int[] startrgb, int[] endrgb, string text)
        {
            int change_r = endrgb[0] - startrgb[0] / text.Length;
            int change_g = endrgb[1] - startrgb[1] / text.Length;
            int change_b = endrgb[2] - startrgb[2] / text.Length;

            int r = startrgb[0];
            int g = startrgb[1];
            int b = startrgb[2];

            string grad_text = string.Empty;
            foreach(char c in text)
            {
                if (c == '\n') { grad_text += "\n"; continue; }
                grad_text += $"\x1b[38;2;{r};{g};{b}m{c}";
                r += change_r;
                g += change_g;
                b += change_b;
            }
            System.IO.File.WriteAllText(@"C:\Users\V1\source\repos\ConsoleApp2\ConsoleApp2\bin\Debug\testing.txt", grad_text);


            Console.WriteLine("The Text successfully saved to file!");


        }
    }
}
