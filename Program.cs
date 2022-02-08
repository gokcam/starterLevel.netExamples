using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
//             Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            int count = 0;
            bool controlPoint = true;
            ArrayList primes = new ArrayList();
            ArrayList notPrimes = new ArrayList();
            int TotalPrimes =0;
            int TotalNotPrimes =0;
            while(count<5)
            {
                Console.Write("Bir sayı giriniz: ");
                string input = Console.ReadLine();
                

                foreach(var item in input)
                {
                    if(char.IsLetter(item))
                    {
                            Console.WriteLine("Metinsel bir ifade ya da karakter giremezsiniz.");
                        controlPoint = false;
                    }
                }

                if(controlPoint)
                {
                    if(Convert.ToInt32(input)<0)
                    {
                        Console.WriteLine("Negatif bir değer giremezsiniz.");
                    }

                    else 
                    {
                        int number = int.Parse(input);
                        for(int i=2; i< number; i++)
                        {
                            if(number % i == 0)
                            {
                                notPrimes.Add(number);
                                break;
                            }

                            else
                            {
                                primes.Add(number);
                                break;
                            }
                        }

                        count++;

                    }
                }
            }

            primes.Sort();
            notPrimes.Sort();
                Console.WriteLine("**********Asal Sayılar*********");
            for(int i=primes.Count-1;i>=0;i--)
            {
                TotalPrimes+=Convert.ToInt32(primes[i]);
                Console.WriteLine(primes[i]);
            }
            int sayi = primes.Count;
            Console.WriteLine(+ sayi +" Tane asal sayi vardir");
            Console.WriteLine("Asal sayılar ortalaması:{0}",TotalPrimes/primes.Count);


            Console.WriteLine("**********Asal Olmayan Sayılar*********");
            for(int i=notPrimes.Count-1;i>=0;i--)
            {
                TotalNotPrimes+=Convert.ToInt32(notPrimes[i]);
                Console.WriteLine(notPrimes[i]);
            }
            int sayi2 = notPrimes.Count;
            Console.WriteLine(+ sayi2 +" Tane asal olmayan sayi vardir");
            try{
                Console.WriteLine("Asal olmayan sayılar ortalaması:{0}",TotalNotPrimes/notPrimes.Count);
            }
            catch
            {
                Console.WriteLine("Asal sayi olmadığından ortalama hesaplanamaDI");
            }





     
        }


    }
}