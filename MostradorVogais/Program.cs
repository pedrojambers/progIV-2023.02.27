namespace MostradorVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine().ToLower();
            string vogais = "";

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vogais += c + " ";
                }
            }

            Console.WriteLine($"As vogais encontradas na palavra ou frase digitada são: {vogais}");
        }
    }
}