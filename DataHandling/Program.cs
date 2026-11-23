namespace DataHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            //citim de la tastatura capacitatea array-ului
            Console.Write("Input the number of elements for the array:");
            n = int.Parse(Console.ReadLine());
            //declaram array-ul 
            int[] ints = new int[n];

            Console.WriteLine("Input the elements for the array:");
            //citim de la tastatura fiecare element din array
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element - {0} : ", i);
                ints[i] = int.Parse(Console.ReadLine());
            }

            //iteram prin fiecare element din array pt a calcula suma 
            for (int i = 0; i < n; i++)
            {
                sum = sum + ints[i];
            }

            //afisam suma 
            Console.WriteLine("Sum=" + sum);
        }
    }
}
