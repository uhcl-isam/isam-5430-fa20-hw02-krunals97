using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            string input;
            int prev = -999, count = 1;
            int clumps = 1, curr;

            while ((input = Console.ReadLine()) != null && input != " ")
            {
                curr = int.Parse(input);
                if (prev != curr)
                {
                    prev = curr;
                    if (count >= 2)
                    {
                        clumps++;
                        count = 1;
                    }
                }
                else
                {
                    count++;
                    prev = curr;
                }


            } 


            Console.WriteLine(clumps);

        }
    }

}
