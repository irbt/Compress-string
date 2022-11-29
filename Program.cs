// Given a non-empty string, write a method that returns it in compressed format.

namespace Program
{
    class CompressThingTask
    {
        public static void Main(string[] args)
        {
                Console.Clear();
            static void CompressString(string s)
            {
                int length = s.Length - 1;
                int count =1;
                string sp = s;
                List<string> Li = new List<string>();

                for (int i = 0; i <= length; i++)
                {
                    if (i < length)
                    {
                        if (sp[i] == sp[i + 1])
                        {
                            count++;
                        }
                        else 
                        {
                            char sep = sp[i + 1];
                            //string[] tab = sp.Split(sep);
                           string countS;
                           countS = count.ToString();
                            Li.Add(sp[i] + countS);
                            count = 1;
                            
                        }
                    }
                    else  {
                        //count ++ ;
                        string countS;
                        countS = count.ToString();
                        Li.Add(sp[i] + countS);

                    }
                }
// vérification contenu tableau
                foreach (var item in Li)
                {
                    Console.WriteLine(item);
                }
                    Console.WriteLine("----------------------------------");


            }
            CompressString("kkkktttkkkjy9rrruuufffsssss");// → "k4t3r10"
            CompressString("p555ppp7www");// → "p153p371w3"
        }
    }
}