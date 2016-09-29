using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSet
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int[] set = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            
            Console.WriteLine("Parent Set: ");
            foreach(int element in set)
            {
                Console.Write(element);
            }
            Console.WriteLine();
            Console.WriteLine("Number of Subsets of the set: " + count);
            Console.WriteLine();      
    
            PowerSetFunction(set);
            Console.WriteLine(count);

        }

        void PowerSetParent(int[] s)
        {

            //begin state
            count++;
            Console.WriteLine("{ }");
            int[] t = new int[1];
            PowerSetRecursive(1, s, t);

        }

        void PowerSetRecursive(int position, int[] s, int[] t)
        {

        }

        static void PowerSetFunction(int[] s)
        {
            
            //{ }
            count++;
            Console.WriteLine("{ }");

            for (int a = 0; a < s.Length; a++)
            {

                //{x}
                Console.WriteLine("{" + s[a] + "}");
                count++;

                for (int b = a; b < s.Length; b++)
                {
                    if (b == a)
                        continue;

                    //{x, x}
                    Console.WriteLine("{" + s[a] + ", " + s[b] + "}");
                    count++;

                    for (int c = b; c < s.Length; c++)
                    {
                        if (c == b)
                            continue;

                        //{x, x, x}
                        Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] +  " }");
                        count++;

                        for (int d = c; d < s.Length; d++)
                        {
                            if (d == c)
                                continue;

                            //{x, x, x, x}
                            Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] + ", " + s[d] + " }");
                            count++;

                            //continue
                            for (int e = d; e < s.Length; e++)
                            {
                                if (e == d)
                                {
                                    continue;
                                }

                                //{x, x, x, x, x}
                                count++;
                                Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] + ", " + s[d] + ", " + s[e] + " }");

                                //continue
                                for (int f = e; f < s.Length; f++)
                                {
                                    if (f == e)
                                    {
                                        continue;
                                    }

                                    //{x, x, x, x, x, x}
                                    count++;
                                    Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] + ", " + s[d] + ", " + s[e] + ", " + s[f]  + " }");

                                    //continue
                                    for (int g = f; g < s.Length; g++)
                                    {
                                        if (g == f)
                                        {
                                            continue;
                                        }

                                        //{x, x, x, x, x, x, x}
                                        count++;
                                        Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] + ", " + s[d] + ", " + s[e] + ", " + s[f] + ", " + s[g]  +" }");

                                        //continue
                                        for (int h = g; h < s.Length; h++)
                                        {
                                            if (h == g)
                                            {
                                                continue;
                                            }

                                            //{x, x, x, x, x, x, x, x}
                                            count++;
                                            Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] + ", " + s[d] + ", " + s[e] + ", " + s[f] + ", " + s[g] + " , " + s[h] + " }");

                                            //continue
                                            for (int i = h; i < s.Length; i++)
                                            {
                                                if (i == h)
                                                {
                                                    continue;
                                                }

                                                //{x, x, x, x, x, x, x, x, x}
                                                count++;
                                                Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] + ", " + s[d] + ", " + s[e] + ", " + s[f] + ", " + s[g] + " , " + s[h] + ", " + s[i] +" }");

                                                //continue
                                                for (int j = i; j < s.Length; j++)
                                                {
                                                    if (j == i)
                                                    {
                                                        continue;
                                                    }

                                                    //{x, x, x, x, x, x, x, x, x, x}
                                                    count++;
                                                    Console.WriteLine("{ " + s[a] + ", " + s[b] + ", " + s[c] + ", " + s[d] + ", " + s[e] + ", " + s[f] + ", " + s[g] + " , " + s[h] + ", " + s[i]+", " + s[j]+" }");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
