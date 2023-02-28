namespace MostradorConsoantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine().ToLower();
            string consoantes = "";

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase[i];
                if (c >= 'a' && c <= 'z' && c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                {
                    consoantes += c + " ";
                }
            }

            Console.WriteLine($"As consoantes encontradas na palavra ou frase digitada são: {consoantes}");
        }
    }
}