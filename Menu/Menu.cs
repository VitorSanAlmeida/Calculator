
using Calculator.Operations;

namespace Calculator.Menu
{
    public class MainMenu
    {
        public static void OptionsMenu()
        {
            short answer = 0;

            DrawnScreen.Drawn();

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Digite a operação que dejesa fazer: ");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("1 - Adição");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("2 - Subtração");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("3 - Divisão");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("4 - Multiplicação");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("5 - Potenciação");
            
            Console.SetCursorPosition(3, 8);

            try
            {
                answer = short.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite uma opção válida");
                Thread.Sleep(1000);
                OptionsMenu();
            }

            switch (answer)
            {
                case 1: OperationOption.Addition(); break;
                case 2: OperationOption.Subtraction(); break;
                case 3: OperationOption.Division(); break;
                case 4: OperationOption.Multiplication(); break;
                case 5: OperationOption.Potentiation(); break;
                default: OptionsMenu(); break;

            }
        }
    }
}
