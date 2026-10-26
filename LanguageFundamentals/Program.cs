namespace LanguageFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1 Intershicmbarea a doua numere
            //int a, b, aux;
            //Console.Write("Introduceti valoarea lui a:");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Introduceti valoarea lui b:");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Numerele inainte de interschimbare:");
            //Console.WriteLine("a=" + a);
            //Console.WriteLine("b=" + b);

            //aux = a;
            //a = b;
            //b = aux;

            //Console.WriteLine("Numerele dupa de interschimbare:");
            //Console.WriteLine("a=" + a);
            //Console.WriteLine("b=" + b);


            //ex2 - ecuatia de gr 1  - ax+b = 0 
            float a, b, x;
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("a nu poate fi 0!");
                a = float.Parse(Console.ReadLine());
            }

            Console.Write("b=");
            b = float.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine("Solutia ecuatiei este x=" + x);

        }
    }
}
