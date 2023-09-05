using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharpPrograms
{
    [TestClass]
    public class CSharpPrograms
    {
        [TestMethod]
        public void Program1ToFindTheOccuranceOfString()
        {
            string name = "Sandeep";
            Dictionary<char,int> dict = new Dictionary<char, int>();
            foreach (char ch in name)
            {
                dict.TryGetValue(ch, out int value);
                dict[ch] = value+1;
            }

            foreach (var x in dict)
            {
                Console.WriteLine($"{x.Key},{x.Value}");
            }

                            
        }

        [TestMethod]
        public void Program2ToReverseEachWord()
        {
            string value = "Hello iam good today";

            foreach(string word in value.Split())
            {

                string rev = string.Empty;
                string strv = string.Empty;

               for(int i = word.Length-1;i>=0;i--)
                {

                    rev = rev + word[i];
                }

                strv = strv + rev;
                Console.WriteLine(strv);

            }
        }

        [TestMethod]
        public void Program3ToSortAnArray()
        {

            int[] A = { 1, 20, 5, 3 };
            int temp = 0;

            for (int i = 0; i <= A.Length - 1; i++)
            {

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {

                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }

                }
            }

            foreach (int item in A)
            {

                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Program4ToRemoveWhiteSpace()
        {
            string name= "Iam Anju";
            Console.WriteLine(name.Replace(" ",String.Empty));

        }

        [TestMethod]
        public void Program5ToPrintAsteriskinPattern()
        {
            for(int i = 1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        [TestMethod]
        public void Program6ToReverseNumber()
        {
            int num = 48;
            int rev = 0;
            int rem;
            while(num!=0)
            {
                rem = num % 10;
                rev = rev * 10+rem;
                num = num / 10;
            }
            Console.Write(rev);

        }

    }
}

