using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefAndValue
{
    class Program
    {
        //integers are conversed by value(a copy of original one)
        //but int[] is concersed by ref , so the orignal one will change as well 
        static void change(int[] a, int i)
        {
            a[0] = 100;
            i = 100;
        }

        //but we can use key word : 'ref' to converse by ref
        static void changeByRef(int[] a, ref int i)
        {
            a[0] = 100;
            i = 100;
        }

        //the key word :"out" can be used when we dont intial the parameter
        static void changeByOut(int[] a, out int i)
        {
            a[0] = 100;
            i = 100;
        }

        static void Main(string[] args)
        {
            int i = 0;
            int j;
            int[] ints = {0,1,2,3};

            Console.WriteLine("i= " + i);
            Console.WriteLine("ints[0]= " + ints[0]);

            Console.WriteLine("After change function :");
            change(ints, i);
            Console.WriteLine("i= " + i);
            Console.WriteLine("ints[0]= " + ints[0]);
            //output:
            //i=0;ints[0]=0
            //i=0;ints[0]=100

            Console.WriteLine("After changeByRef function :");
            changeByRef(ints, ref i);
            Console.WriteLine("i= " + i);
            Console.WriteLine("ints[0]= " + ints[0]);
            //output:
            //i=0;ints[0]=0
            //i=100;ints[0]=100

            Console.WriteLine("After changeByOut function :");
            changeByOut(ints, out j);
            Console.WriteLine("j= " + j);
            Console.WriteLine("ints[0]= " + ints[0]);
            //output:
            //j=0;ints[0]=0
            //j=100;ints[0]=100
        }
    }
}
