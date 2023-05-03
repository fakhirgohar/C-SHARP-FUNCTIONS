using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Practise
{
    public static class FuncClassSt
    {

        public static class FuncGetClosestDivNo
        {

            //////////////////////////////---Get Closest devisibel no ---//////////////////////////////
            public static void GetClosestDivNo(int Num, int Diviser)
            {
                for (int i = Num; i <= Num; i--)
                {
                    if (i % Diviser == 0)
                    {
                        Console.WriteLine("The Closest Diviseble No of " + Num + " is: " + i);
                        return;
                    }
                }
            }
        }


        //////////////////////////////---Print the given patern---//////////////////////////////
        public static void PrintPat(int num)
        {
            int i, j, k;
            for (k = 0; k < num; k++)
            {
                for (i = num; i > 0; i--)
                {
                    for (j = 0; j < num - k; j++)
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine();
            }
        }



        //////////////////////////////---Get ArmStrong no---//////////////////////////////
        public static void ArmStrongNo(int num)
        {
            int temp = 0;
            string number = num.ToString();
            char[] charArray = num.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int K = int.Parse(charArray[i].ToString());
                temp += K * K * K;
            }
            if (temp == num) { Console.WriteLine("The number " + num + " is ArmStrong"); }
            else { Console.WriteLine("The number " + num + " is not ArmStrong"); }
        }



        //////////////////////////////---Get Largest Element in an Array---//////////////////////////////
        public static int GetLargestElementUsingFor(int[] sourceArray)
        {
            int maxElement = sourceArray[0];
            for (int index = 1; index < sourceArray.Length; index++)
            {
                if (sourceArray[index] > maxElement)
                    maxElement = sourceArray[index];
            }

            return maxElement;
        }


        //////////////////////////////---Get Prime no---//////////////////////////////
        public static bool chkprime(int num)
        {
            if (num <= 1)
            {
                return true;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void PrintPrimeNum(int num)
        {
            if (num <= 1)
            {
                if (chkprime(num))
                {
                    Console.WriteLine(num);
                }
            }

            for (int i = 2; i < num; i++)
            {
                if (chkprime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }



        //////////////////////////////---Get Series of Given Pattern---//////////////////////////////
        public static void GetSeries(int A, int B, int N)
        {
            int temp = B - A;
            Console.WriteLine(A);
            for (int i = 1; i < N; i++)
            {
                Console.WriteLine(A = A + temp);
            }
        }




        //////////////////////////////---Get Table---//////////////////////////////
        public static void GetTable(int num)
        {
            Console.WriteLine("The Table of " + num + " is:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + i * num);
            }
        }




        //////////////////////////////---Get Shape---//////////////////////////////
        public static void shape()
        {

            int maxlen = 7;

            int i, j, r;

            Console.Write("\n\n");
            Console.Write("Display the pattern like diamond:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows (half of the diamond) :");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");

            }

        }





        //////////////////////////////---Get Palindrome No---//////////////////////////////
        public static void PalindromeNo()
        {
            Console.Write("Enter a Number to check the sum of this number is Palindrome or Not: ");
            long Num = Convert.ToInt64(Console.ReadLine());
            List<long> lst = new List<long>();
            long SumofIntegar = 0;
            char[] charr = Num.ToString().ToCharArray();
            foreach (char c in charr) { lst.Add(long.Parse(c.ToString())); }

            //Take Sum and Convert into list
            SumofIntegar = lst.Sum();
            char[] charr1 = SumofIntegar.ToString().ToCharArray();
            List<long> templst = new List<long>();
            foreach (char c in charr1) { templst.Add(long.Parse(c.ToString())); }

            //Reverse List and Store in String Variable
            templst.Reverse();
            string ReverseNo = string.Empty;
            foreach (var c in templst) { ReverseNo += c.ToString(); }

            if (ReverseNo == SumofIntegar.ToString()) { Console.WriteLine("The Number " + Num + " is a Palindrome Number"); }
            else { Console.WriteLine("The Number " + Num + " is not a Palindrome Number"); }
        }




        //////////////////////////////---Reverse the Given No---////////////////////////////// 
        public static void ReverseNo(int Num)
        {
            char[] charr = Num.ToString().ToCharArray();
            List<int> lst = new List<int>();
            foreach (var c in charr)
            {
                lst.Add(int.Parse(c.ToString()));
            }
            lst.Reverse();
            Console.Write("The Reverse Order of " + Num + " is ");
            foreach (var c in lst)
            {
                Console.Write(c);
            }
        }




        //////////////////////////////---Given two numbers A and B, find Kth digit from right of A^B---//////////////////////////////  
        public static void Find_kth_No(int a, int b)
        {
            int num = 1;
            for (int i = 0; i < b; i++)
            {
                num *= a;
            }
            // int num = (int)Math.Pow(a, b);
            char[] charr = num.ToString().ToCharArray();
            List<int> lst = new List<int>();
            foreach (var c in charr)
            {
                lst.Add(int.Parse(c.ToString()));
            }
            lst.Reverse();
            for (int k = 0; k < lst.Count; k++)
            {
                if (k == b - 1)
                {
                    Console.WriteLine("The kth No is " + lst[k - 1].ToString());
                    break;
                }
            }
        }




        //////////////////////////////---Convert Binary to Decimal---//////////////////////////////  
        public static void BinToDec(int Num)
        {
            char[] arr = Num.ToString().ToCharArray();
            List<int> lst = new List<int>();
            foreach (char c in arr)
            {
                lst.Add(int.Parse(c.ToString()));
            }
            decimal dec = 0;
            int temp = lst.Count - 1;
            for (int i = 0; i < lst.Count; i++)
            {
                dec += lst[i] * ((int)Math.Pow(2, temp));
                temp--;
            }
            Console.WriteLine("The Decimal no of " + Num + " is: " + dec);
        }




        //////////////////////////////---Find Greatest Common Diviser of Given 2 No---//////////////////////////////
        public static void GCD()
        {
            Console.Write("Enter 1st No: ");
            int FirstNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd No: ");
            int SecondNo = Convert.ToInt32(Console.ReadLine());
            int ConditionNo = FirstNo < SecondNo ? FirstNo : SecondNo;
            bool msg = false;
            for (int i = ConditionNo; i > 0; i--)
            {
                if (FirstNo % i == 0 && SecondNo % i == 0)
                {
                    msg = true;
                    Console.WriteLine("The Greatest Common Divisor of " + FirstNo + " & " + SecondNo + " is: " + i);
                    break;
                }
            }
            if (msg == false)
            {
                Console.WriteLine("There is no Greatest Common Divisor of " + FirstNo + " " + SecondNo);
            }
        }


        //////////////////////////////---Find LCM of Given 2 No---//////////////////////////////
        public static void LCM()
        {
            Console.Write("Enter 1st No: ");
            int FirstNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd No: ");
            int SecondNo = Convert.ToInt32(Console.ReadLine());
            List<int> lst1 = new List<int>();
            List<int> lst2 = new List<int>();
        }


        //////////////////////////////---Add 2 Fractions---//////////////////////////////
        public static void Factrize()
        {
            Console.Write("Enter 1st No: ");
            double UN1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 1st Denominator: ");
            double LN1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd No: ");
            double UN2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd Denominator: ");
            double LN2 = Convert.ToInt32(Console.ReadLine());

            double Result = 0;
            double T1 = 0;
            double T2 = 0;
            Result = ( (UN1 * LN2) + (UN2 * LN1) ) / (LN1 * LN2);
            T1 = ((UN1 * LN2) + (UN2 * LN1));
            T2 = (LN1 * LN2); 
            Console.WriteLine("The Answer is: " + T1 + "/" + T2 + " OR " + Result);
        }


        //////////////////////////////---Find GCD of Given Array---//////////////////////////////
        public static void GCDArray(int []arr)
        {
            int ConditionNo = arr.Min();
            bool temp = false;
            for(int i = ConditionNo; i > 0; i--)
            {
                foreach (var No in arr)
                {
                    if(No % i != 0)
                    {
                        temp = true;
                        break;
                    }
                }
                if (temp == false)
                {
                    Console.WriteLine("The Greatest Common Dvivsor of Given Array is: " + i);
                    break;
                }
            }
        }


    }
}
