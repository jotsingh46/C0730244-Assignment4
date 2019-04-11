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
        }
        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
           // Read file using streamReader. Reads file line by line
           using (StreamReader file = new StreamReader("U:/Users/730244/New folder/C0730244-Assignment4"))
           {
              int counter = 0;
              string ln;

              while((ln= file.ReadLine()) !=null)
              {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
              }
              file.Close();
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
