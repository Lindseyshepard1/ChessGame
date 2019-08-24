using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {

            int horizontal = 8;
            int vertical = 8;

            for(int i=0; i<horizontal;i++)
            {
                for(int across=0; across<vertical;across++)
                {
                    if((i+across)%2==0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}