using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730244_Assignment4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] arge)
        {
           Program p = new Program();
           p.Beowulf = new ArrayList();
            p.Run();

        }
        public void Run()
        {
            this.ReadTextFiles();
            this.ProcessArrayList();
        }
        public void ProcessArrayList()
        {
            int LineNumber = 0;
            foreach(var line in Beowulf)
            {
                

                if(ContainsWord( line.ToString().ToLower(), "sea")&& ContainsWord(line.ToString().ToLower(), "fare"))
                {
                    Console.WriteLine("line number is {0}", LineNumber);
                    Console.WriteLine(line);
                    LineNumber++;
                }
            }
            Console.WriteLine(LineNumber);
        }
        public bool ContainsWord(string line, string word)
        {
            // to do : write algorith to detect the line contain a word
            if(line.Contains(word)== true)
            {
                //Console.WriteLine("Word Found");
                return true;
            }
            return false;
        }
        public void ReadTextFiles()
        {
           
            // Read file using streamReader. Reads file line by line
           using (StreamReader file = new StreamReader("U:/Users/730244/New folder/Beowulf.txt"))
           {
              int words = 1;
              int counter = 0;
              string ln;

              while((ln= file.ReadLine()) !=null)
              {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
              }
              file.Close();
              Console.WriteLine("=======================================================================");
              Console.WriteLine($"File has {counter} lines.");
              Console.ReadLine(); 
           }
        }

        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
             
            foreach (char c in line)
            {
                if(char.IsLetter(c)) { countletters++; }
                if(char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}
