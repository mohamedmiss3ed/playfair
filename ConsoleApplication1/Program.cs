using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program


    {
        private static string MakeMsgReady(string msg)
        {
            if (msg.Length % 2 == 1)
            {

                return msg + 'x';
                

            }
            else
            {
                return msg;
            }

        }

        private static int x = 0;
        private static int y = 0;
        private static void GetPosition(char[,] ArrOfChar, char ch)
        {
            
            if (ch == 'j')
                GetPosition(ArrOfChar, 'i');

            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    if (ArrOfChar[i, j] == ch)
                    {
                        x = i;
                        y = j;
                    }
        }

        private static char[,] Make2dArray(string key)
        {
            char[] AlphaChars = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[,] arr2D = new char[5, 5];

            HashSet<char> SetofChar = new HashSet<char>();
            for (int j = 0; j < key.Length; j++)
            {
                SetofChar.Add(key[j]);
            }
            for (int i = 0; i < 26; i++)
            {
                SetofChar.Add(AlphaChars[i]);
            }

            SetofChar.Remove('j');
            char[] ch1D = SetofChar.ToArray();

            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr2D[i, j] = ch1D[k];
                    k++;
                }
            }



            return arr2D;


        }

        private static char[] EncryptWithCipher()
        {
            string key = Console.ReadLine();
            char[,]Chars= Make2dArray(key);

            Console.WriteLine("enter message");
            string msg = Console.ReadLine();
            msg=MakeMsgReady(msg);

            List<char> CipherText = new List<char>();

            for (int j = 0; j < msg.Length; j++)
            {
                int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
                GetPosition(Chars,msg[j]);
                x1 = x;
                y1 = y;
                x = 0;
                y = 0;
                GetPosition(Chars,msg[++j]);
                x2 = x;
                y2 = y;
                if (x1 == x2 &&y1==y2)
                {
                   CipherText.Add(Chars[x1, y1]);
                    CipherText.Add(Chars[x2, y2]);
                }
                else if (x1 == x2 )
                {
                    CipherText.Add(Chars[x1, y2%5]);
                    CipherText.Add(Chars[x1, (y2 + 1)%5]);
                }
                else if (y1 == y2)
                {
                    CipherText.Add(Chars[x2%5, y1]);
                    CipherText.Add(Chars[(x2 + 1)%5, y2]);
                }
                else
                {
                        CipherText.Add(Chars[x1, y2]);
                        CipherText.Add(Chars[x2, y1]);
                }
            }
            char[] result = CipherText.ToArray();
            return result;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("enter key");

            char []result=EncryptWithCipher();

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            
        }
    }
}
