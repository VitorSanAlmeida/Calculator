using Calculator.Menu;

namespace Calculator.Operations
{
    public class OperationOption
    {
        public static void Addition()
        {
            int result = 0;
            int quantity = 0;

            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Quantos números você deseja somar? ");
            Console.SetCursorPosition(3, 11);
            try
            {
                quantity = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite um número.");
                Console.WriteLine("Quantos números você deseja somar? ");
                quantity = int.Parse(Console.ReadLine());
            }
            var number = new int[quantity];

            for (int i = 0; i < number.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite um número: ");
                Console.WriteLine("Pressione ENTER para confirmar");
                number[i] = int.Parse(Console.ReadLine());

            }

            Console.Clear();

            for (int i = 0; i < quantity; i++)
            {
                result += number[i];
            }

            Console.WriteLine($" O resultado da soma é {result}");

            LastOption.Again();
        }

        public static void Subtraction()
        {
            int a;
            int b;
            int result;

            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Clear();

            if (a < b)
                result = b - a;
            else
                result = a - b;

            if (a < b)
                Console.WriteLine($"{b} - {a} = {result}");
            else
                Console.WriteLine($"{a} - {b} = {result}");

            LastOption.Again();

        }

        public static void Division()
        {
            float a;
            float b;
            float result;

            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Clear();
            result = a / b;

            Console.WriteLine($"O valor da divisão é {result.ToString("N3")}");
            LastOption.Again();

        }
        
        public static void Multiplication()
        {
            int result = 1;
            int quantity = 0;
            int account;

            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Quantos números você deseja usar? ");
            Console.SetCursorPosition(3, 11);
            try
            {
                quantity = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite um número.");
                Console.WriteLine("Quantos números você deseja usar? ");
                quantity = int.Parse(Console.ReadLine());
            }
            var number = new int[quantity];

            for (int i = 0; i < number.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite um número: ");
                Console.WriteLine("Pressione ENTER para confirmar");
                number[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            foreach (var item in number)
            {
                result *= item;
            
            }

            Console.WriteLine($"O resultado da multiplicação {result}");
            LastOption.Again();
        }

        public static void Potentiation()
        {
            int a;
            int b = 1;
            int result;

            Console.Clear();
            Console.WriteLine("Digite o número base: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            b += int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da operação é: ");
            Console.WriteLine($"{a}^{b} = {(Math.Pow(a, b))}");
            LastOption.Again();
        }

    }

}
