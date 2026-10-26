namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Dati numele: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");*/

            //ex1
            /* int a, b, sum = 0;
             Console.Write("Dati valoarea pentru a: ");
             a = int.Parse(Console.ReadLine());
             //Readline tot timpul citeste string, deci trebuie sa convertesc 
             Console.Write("Dati valoarea pentru b: ");
             b = Convert.ToInt32(Console.ReadLine());
             sum = a + b;
             Console.WriteLine("Suma este : " + sum);
             Console.WriteLine("Suma este : {0}", sum);
             Console.WriteLine("Suma dintre {0} si {1} este : {2}", a, b, sum);
             Console.WriteLine($"Suma este : {sum}");*/

            //ex2
            int n;
            List<int> numbers = new List<int>();

            do
            {
                n = int.Parse(Console.ReadLine());
                numbers.Add(n);
            }
            while (n % 100 != 0);

            Console.WriteLine(); 

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
