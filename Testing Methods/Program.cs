namespace Testing_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num = 3;    
            string number = num.ToString();

            char[] chars = number.ToCharArray();
            bool isNumber = char.IsDigit(number.ToCharArray()[0]);
            
        }
    }
}