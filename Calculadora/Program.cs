namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, resultado, modulo;
            string operacao;

            Console.Write("Primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha uma operação [+, -, *, /]: ");
            operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    resultado = Calculos.Somar(v1, v2);
                    Console.WriteLine(v1 + " " + operacao + " " + v2 + " = " + resultado);
                    break;

                case "-":
                    resultado = Calculos.Subtrair(v1, v2);
                    Console.WriteLine(v1 + " " + operacao + " " + v2 + " = " + resultado);
                    break;

                case "*":
                    resultado = Calculos.Multiplicar(v1, v2);
                    Console.WriteLine(v1 + " " + operacao + " " + v2 + " = " + resultado);
                    break;

                case "/":
                    resultado = Calculos.Dividir(v1, v2);
                    modulo = Calculos.Modulo(v1, v2);
                    Console.WriteLine(v1 + " " + operacao + " " + v2 + " = " + resultado);
                    Console.WriteLine("O resto da divisão é " + modulo);
                    break;

                default:
                    Console.WriteLine("Operador inválido!");
                    return;
            }
            
            
            Console.ReadLine();

        }
    }
}