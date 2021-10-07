using System;
using System.IO;
using System.Text;

namespace MethodTesting
{

    //[modifiers] type name;        data=field=variable               
    //[modifiers...] type name = expression;   data=field=variable given and initial value
    //[modifiers...] type name = expression; 
    //type name () {body}   operation = method = subroutine = function
    //type name (type p1 type p2) {body}
    //type name (type p1 type p2 type p3) {body}
    //type name (...) {body}
    //      params    body      params=parameters ``` arguments ```     
    //[modifiers...] type name ([modifier type param1,...}) {body}
    //ref changes to the var in sub occur to the caller's variable
    //    out - paas an inin var to su ,sub shoyld provide an init value that is stored in caller's var
    class Program
    {
        static void Main()
        {
            //        //int i = 1;
            //        //stillanother(8, 20, 30);
            //        //int xyzzy    ;
            //        //int i = another();
            //        //Console.WriteLine($"Main:i:{i}");
            //        int i;
            //        Console.WriteLine($"Main before {i}");
            //        // another(ref i); //arg init
            //        another(out i);
            //        Console.WriteLine($"Main After {i}");
            //    }
            //    //    static int another()
            //    //{
            //    //    //stubbing
            //    //    int rv = 0;
            //    //    int i = 2;
            //    //    //stillanother(20, rv, rv++);
            //    //    //stillanother(20, rv, stillanother(10,1,0));
            //    //    //stillanother(20, rv,67);
            //    //    Console.WriteLine($"another:i:{i}   rv:{rv}");
            //    //    return rv;

            //    //    //int i = 2;
            //    //    //if (i > 2)
            //    //    //{
            //    //    //    return 1;
            //    //    //}
            //    //}
            //    //static int stillanother(int a,int b,int c)
            //    //{
            //    //    int i = 3;
            //    //    int rv = 0;
            //    //    return a + b + c + i;
            //    //    //return rv;catch all exit companies prefer 1 statement 
            //    //}
            static void another(out int i)
            {
                //  Console.WriteLine($"another before {i}");
                i = 150;
                //        //i = i + 10;
                Console.WriteLine($"another After:");
            }
        }
        class ArgsToMain
        {
            static void Main(string[] args)
            {
                Console.WriteLine($"the number of args{args.Length}");
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }
                if (args.Length == 1)
                {
                    if (args[0] == "\\?")
                    {
                        Console.WriteLine("Help would be here");
                        return;
                    }
                }
                Console.WriteLine(SumAll("MyTitle", 1, 2, 3.5f, 4, 5.23, 9.30000000000));

            }
            //static int SumAll(int a,int b,int c = 9)
            //{
            //    return a + b + c;
            //}

            static double SumAll(string title, params double[] data)
            {
                Console.WriteLine(title);
                //int rv = 0;
                //foreach(int i in data)
                double rv = 0;
                foreach (var i in data)
                {
                    rv += i;
                }
                return rv;
            }
            class StringStuff
            {
                static void Main1()
                {
                    StringBuilder sb = new StringBuilder();
                    while (true)
                    {
                        Console.Write("More Data:");
                        string temp = Console.ReadLine();
                        //data += temp;
                        //Console.WriteLine($"I now have:{data}");
                        if (temp == "quit")
                        {
                            break;
                        }
                        sb.Append(temp);
                        sb[13] = 'k';
                    }
                    Console.WriteLine();
                }
                static void Main()
                {
                    StreamReader f = File.OpenText("test.dat");
                    while (!f.EndOfStream)
                    {
                        Console.WriteLine(f.ReadLine());
                    }
                    f.Close();
                }

            }

        }
    }
}

