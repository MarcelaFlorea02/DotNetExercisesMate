namespace ErrorsAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperatureObj = new Temperature();

            temperatureObj.temp = 10;
            try
            {
                temperatureObj.DisplayTemperature();
            }
            catch(TempIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
