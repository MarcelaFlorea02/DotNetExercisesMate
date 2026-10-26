namespace LanguageFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //ex1 Intershicmbarea a doua numere
            int a, b, aux;
            Console.Write("Introduceti valoarea lui a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea lui b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Numerele inainte de interschimbare:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Numerele dupa de interschimbare:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
