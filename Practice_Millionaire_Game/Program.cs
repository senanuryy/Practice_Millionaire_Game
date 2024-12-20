using System;

namespace Practice_Millionaire_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int puan = 0;

            Console.WriteLine("Kızınca tüküren hayvan hangisidir?");
            Console.WriteLine("A) Lama");
            Console.WriteLine("B) Deve");
            Console.Write("Cevabınız:");
            string cevap1 = Console.ReadLine().ToLower();

            if (cevap1 == "a")
            {
                Console.WriteLine("Doğru Cevap!"); 
                puan += 1;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap :(");
                puan += 0;
            }

            Console.WriteLine("\nDünya'ya en yakın gezegen hangisidir?");
            Console.WriteLine("A) Venüs");
            Console.WriteLine("B) Mars");
            Console.Write("Cevabınız:");
            string cevap2 = Console.ReadLine().ToLower();
          
            if (cevap2 == "a")
            {
                Console.WriteLine("Doğru Cevap!");
                puan += 1;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap :(");
                puan += 0;
            }

            if (puan==0)
            {
                Console.WriteLine("2 soruya yanlış cevap verdiniz. Elendiniz.");
            }
            else
            {
                Console.WriteLine("\n5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
                Console.WriteLine("A) 7");
                Console.WriteLine("B) 12");
                Console.Write("Cevabınız:");
                string cevap3 = Console.ReadLine().ToLower();

                if (cevap3 == "a" && puan==1)
                {
                    Console.WriteLine("Yanlış Cevap :(");
                    puan += 0;
                    Console.WriteLine("2 soruya yanlış cevap verdiniz. Elendiniz.");
                }
                else if (cevap3 == "a" && puan==2)
                {
                    Console.WriteLine("Yanlış Cevap :(");
                    puan += 0;
                    Console.WriteLine("\nTebrikler En Az 2 Soruya Doğru Cevap Vererek Kazandınız! ");
                    Console.WriteLine("Puanınız 2/3");
                }
                else
                {                  
                    Console.WriteLine("Doğru Cevap!");
                    puan += 1;
                    Console.WriteLine("\nTebrikler En Az 2 Soruya Doğru Cevap Vererek Kazandınız! ");
                    Console.WriteLine("Puanınız " + puan + "/3");
                }

            }
        }

    }

}