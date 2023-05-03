using Oop_Practise;
using System.Collections;

namespace OopPractise
{
    class Program : Student
    {
        public static void Main(string[] args)
        {

            Student st = new Student();
            Console.WriteLine( st.Compute(1, 3));

            //int[] ARR = { 4,8,12,16,20,24,28,32,36,40 };
            //int[] ARR1 = { 8,4,5,6,9,5,4,7,4,5,9};

            //FuncClassSt.GCDArray(ARR1);

        }
    }
}