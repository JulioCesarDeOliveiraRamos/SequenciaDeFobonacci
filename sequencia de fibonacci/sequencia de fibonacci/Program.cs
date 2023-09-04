namespace sequencia_de_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // 0, 1, 1, 2, 3, 5, 8 ,13, 20
        inicio:
            Console.Clear();

            double a = 0, b = 1, c = 0;

            Console.WriteLine("você quer uma sequência de quantos valores?: ");
            double valores;
            if (!double.TryParse (Console.ReadLine(), out valores)){
                Console.WriteLine("Erro só pode valores em numeros");
            }

            for (int i = 0; i < valores; i++)
            {

                if ( i < valores -1)
                {
                    Console.Write(a + ", ");
                }else
                {
                    Console.WriteLine(a);
                }
                c = b + a;
                a = b;
                b = c;

                
            }
            Console.WriteLine("você deseja executar outra sequência? ( s / n ): ");
            
            char novaseq = char.Parse (Console.ReadLine());

            if (novaseq == 's' || novaseq == 'S' )
            {
                goto inicio;
            } else
            {
                Console.WriteLine ("ok, Precione qualquer tecla para sair");
                
            }

        }
    }
}