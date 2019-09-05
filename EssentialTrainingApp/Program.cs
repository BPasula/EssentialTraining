using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.IO;  
using NLog; 

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger(); 
        public static List<string> Words;
        static void Main(string[] args)
        {   
            logger.Trace("Program started.");
            Words = new List<string>();
            Words.Add("Bread");  
            Words.Add("Milk"); 
            Words.Add("Cheese");

            CrazyMathProblem();  
            ReadTextFile();
            Console.ReadLine(); 
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
            {
                income = (income / i); 
            }

            return income; 
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine((contents));
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory. Error: " + ex); 
                logger.Error("Could not find the directory. Error: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file. Error: " + ex); 
                logger.Error("Could not find the file. Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error. Error: " + ex);
            }
            finally
            {
                Console.WriteLine("Finally runs no matter what.");
            }
        }
    }
}
