namespace Calculator.Menu
{
    internal class LastOption
    {
        public static void Again()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja realizar outra operação?");
            Console.WriteLine("S / N");
            var outher = Console.ReadLine().ToUpper();

            Console.Clear();
            if (outher == "S")
                MainMenu.OptionsMenu();
            else
                Console.WriteLine("Obrigado por ultilizar o programa! :)");
        }
    }
}
