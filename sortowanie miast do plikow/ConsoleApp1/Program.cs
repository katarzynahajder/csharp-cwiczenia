using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader odczyt = new StreamReader("odczyt.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            StreamWriter K = new StreamWriter("K.txt");
            for (int i = 0; i < 12; i++)
            {
                string miasto = odczyt.ReadLine();
                switch (miasto[0])
                {
                    case 'A':
                        A.WriteLine(miasto);
                        break;
                    case 'B':
                        B.WriteLine(miasto);
                        break;
                    case 'C':
                        C.WriteLine(miasto);
                        break;
                    case 'D':
                        D.WriteLine(miasto);
                        break;
                    case 'E':
                        E.WriteLine(miasto);
                        break;
                    case 'F':
                        F.WriteLine(miasto);
                        break;
                    case 'G':
                        G.WriteLine(miasto);
                        break;
                    case 'H':
                        H.WriteLine(miasto);
                        break;
                    case 'I':
                        I.WriteLine(miasto);
                        break;
                    case 'J':
                        J.Write(miasto);
                        break;
                    case 'K':
                        K.WriteLine(miasto);
                        break;
                    case 'L':
                        L.WriteLine(miasto);
                        break;
                    case 'M':
                        M.WriteLine(miasto);
                        break;
                    case 'N':
                        N.WriteLine(miasto);
                        break;
                    case 'O':
                        O.WriteLine(miasto);
                        break;
                    case 'P':
                        P.WriteLine(miasto);
                        break;
                    case 'R':
                        R.WriteLine(miasto);
                        break;
                    case 'S':
                        S.WriteLine(miasto);
                        break;
                    case 'T':
                        T.WriteLine(miasto);
                        break;
                    case 'U':
                        U.WriteLine(miasto);
                        break;
                    case 'W':
                        W.WriteLine(miasto);
                        break;
                    case 'Z':
                        Z.WriteLine(miasto);
                        break;
                }
            }
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            K.Close();
            odczyt.Close();
        }
    }
}