﻿using System;

namespace BootCampCSharpDay2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("bibidibop bibididoo");

            Console.WriteLine("Enter and integer:");
            int nbr = GetNbr();

            switch (nbr) {

                case 1: {
                    Console.WriteLine("1 entered.");
                    break;
                }
                case 2: {
                    Console.WriteLine("2 entered.");
                    break;
                }
                case 3: {
                    Console.WriteLine("3 entered.");
                    break;
                }



                default:
                    Console.WriteLine("other than 1,2,3");
                    break;
            }
            Console.WriteLine("for loop w/ index");
            for (int i = 0; i < nbr; i++) {
                Console.WriteLine(i);
            }


            printThreeNumbers(5, 23, 47);
            printThreeNumbers();
            

            Console.WriteLine("bye");
        }

        private static int GetNbr() {
            int nbr = 0;
             try {
               nbr = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) {
                Console.WriteLine("invalid input");
                Console.WriteLine(e.ToString());
            }
            return nbr;
        }
        private static void printThreeNumbers(int n1=1, int n2=2, int n3=3) {
            Console.WriteLine("3nbrs: " + n1 + ","+ n2 + ","+ n3);
        }
    }
}
