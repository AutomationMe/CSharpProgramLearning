using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharpPrograms
{
    [TestClass]
    public class CSharpPrograms
    {
        [TestMethod]
        public void ProgramToFindTheOccuranceOfString()
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
        public void ProgramToReverseEachWord()
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
        public void ProgramToSortAnArray()
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
        public void ProgramToRemoveWhiteSpace()
        {
            string name= "Iam Anju";
            Console.WriteLine(name.Replace(" ",String.Empty));

        }        
    }
}

