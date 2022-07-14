namespace FibonacciLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = 50;// range of our fibonacci numbers
            long number1 = 0, number2 = 0, number3 = 0;// operands 
            var list = Enumerable.Range(1, range).Select(x =>
            {
                //I am new to ternary operators,
                //so I first decided to write the logic through if else,
                //and later wrote it through a ternary operator so that the code takes up less space

                //if (x == 1)
                //    number1 = 0;
                //else
                //    number1 = number2;
                //if (x == 1)
                //    number2 = 1;
                //else
                //    number2 = number3;
                //if (x == 1)
                //    number3 = 0;
                //else
                //    number3 = number1 + number2;
                number1 = x == 1 ? 0 : number2;
                number2 = x == 1 ? 1 : number3;
                number3 = x == 1 ? 0 : number1 + number2;
                return number3;
            });
            foreach(var item in list)
                Console.WriteLine(item);
        }
    }
}