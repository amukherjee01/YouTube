using System;
using System.IO;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\sample1\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch(DirectoryNotFoundException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader!=null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }


        }
    }
}