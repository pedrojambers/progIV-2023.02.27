namespace ContadorVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine().ToLower();
            int qtd = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    qtd++;
                }
            }

            Console.WriteLine("Quantidade de vogais na frase: " + qtd);
        }
    }
}