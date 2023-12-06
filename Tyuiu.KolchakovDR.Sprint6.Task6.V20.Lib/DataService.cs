using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint6.Task6.V20.Lib
{
    public class DataService : ISprint6Task6V20
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                int x = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    x++;
                    if (line == "")
                    {
                        continue;
                    }
                    else
                    {
                        string[] array = line.Split(' ');
                        if (array[0] == "")
                        {
                            resStr += /*x + ")" + */array[2] + " ";
                        }
                        else
                        {
                            resStr += /*x + ")" + */array[1] + " ";
                        }
                    }
                    
                }
            }
            return resStr;
        }
    }
}
