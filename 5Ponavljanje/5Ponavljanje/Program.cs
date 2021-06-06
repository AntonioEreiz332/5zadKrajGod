using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Ponavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i1 = 1; i1 <= 33; i1++)
            {
                for (int i2 = i1 + 1; i2 <= 34; i2++)
                {
                    for (int i3 = i2 + 1; i3 <= 35; i3++)
                    {
                        for (int i4 = i3 + 1; i4 <= 36; i4++)
                        {
                            for (int i5 = i4 + 1; i5 <= 37; i5++)
                            {
                                for (int i6 = i5 + 1; i6 <= 38; i6++)
                                {
                                    for (int i7 = i6 + 1; i7 <= 39; i7++)
                                    {
                                        Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6 + " " + i7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
