using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleDrawings
{
    class Program
    {
        #region Drawing with console
        static void PrintRectangle(int w, int h)
        {
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        static void PrintTriangle(int w, int h)
        {
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                    if (w <= h)
                        Console.Write("* ");
                Console.Write("  ");
                Console.WriteLine();
            }
        }
        static void PrintPyramid(int rows)
        {
            //hence #no of spaces rule  rows - line index
            //hence #no of stars rule  2*line index -1
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)//3             //###
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void PrintChrismasTree(int rows)
        {
            //pyramid
            //half pyramid
            //sticks
            PrintPyramid(rows);
            //half pyramid
            for (int i = rows / 2 + 1; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++) Console.Write(" ");
                for (int k = 0; k < 2 * i - 1; k++) Console.Write("*");
                Console.WriteLine();
            }
            //sticks
            for (int i = 0; i < rows - 2; i++) Console.Write(" ");
            Console.WriteLine("||");
            for (int i = 0; i < rows - 2; i++) Console.Write(" ");
            Console.WriteLine("||");


        }
        static void PrintChessBoard(int w, int h)
        {


        }
        public static void SlowPrint(string msg, int delay)
        {
            foreach (char c in msg.ToCharArray())
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
        #endregion



        public class ProcessBusinessLogic
        {
            public event EventHandler<bool> ProcessCompleted;
            public void StartProcess()
            {
                try
                {

                    Console.WriteLine("Hello this is some code from the process...");
                    Console.WriteLine("Other Code ...");
                    Console.WriteLine("Some More ...");
                    Console.WriteLine("Ande the Process Is completed and ready to raise the event");
                    throw new Exception("failure");
                    OnProcessCompleted(true);

                }
                catch
                {
                    OnProcessCompleted(false);
                }
            }

            protected virtual void OnProcessCompleted(bool b)
            {
                ProcessCompleted?.Invoke(this, b);
            }

        }
        public static void MethodHandler(object sender, bool b)
        {
            Console.WriteLine(b ? "the process is completed and has beed handled successfully " : "the Process has been failed");

        }

        public delegate void print(string sentence);
        public delegate TResult Funcc<in T, out TResult>(T param);
        public delegate TResult Funcc<in T,in T1, out TResult >(T param);

        static void Main(string[] args)
        {


            Func<int> fun = () => 3 + 5;
            Console.WriteLine(fun());
            
            
                
        }


        public static void printname(string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }

        public static void printgender(string Gender)
        {
            Console.WriteLine($"my gender is : {Gender}");
        }

        public static void choose (print del , string param){

            del(param);
        }







    }
}

