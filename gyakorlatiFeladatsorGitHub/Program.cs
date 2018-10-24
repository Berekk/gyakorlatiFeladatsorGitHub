using System;



namespace gyakorlatiFeladatsorGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            bekeres();
            tombKiiratas(bekertek);
            max(bekertek);
            min(bekertek);


            Console.WriteLine("any key for exit");
            Console.ReadKey();
        }

        static int[] bekertek;

        static void bekeres()
        {
            int mennyiseg;

                Console.Write("mennyi számot akarsz beadni: ");
                try
                {
                    mennyiseg = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                throw new System.ArgumentException("nem jó számot adtál meg!", "original"); 
                }


            

            bekertek = new int[mennyiseg];
            Console.WriteLine("adj meg {0} számot:", mennyiseg);
           

            for (int i = 0; i < bekertek.Length; i++)
            {
                try
                {
                    bekertek[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw new System.ArgumentException("nem jó számot adtál meg!", "original");
                }
            }


        }

        static void tombKiiratas(int[] tomb)
        {
            Console.WriteLine("bevitt értékek: ");
            for (int i = 0; i < tomb.Length-1; i++)
            {
                Console.Write(tomb[i]+", ");
            }
            Console.WriteLine(tomb[tomb.Length-1]);
            
        }

        static void max(int[] tomb)
        {
            int max = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine("legnagyobb érték: "+ max);
        }

        static void min(int[] tomb)
        {
            int min = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine("legkisebb érték: " + min);
        }

    }
}
