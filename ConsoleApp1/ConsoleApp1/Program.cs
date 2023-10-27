namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int x;
            int[] idades = new int[10] { 11, 19, 13, 18, 9, 25, 7, 8, 28, 3 };
            int ano;

            Console.WriteLine("Informe o ano em que você nasceu:");
            ano = Convert.ToInt32(Console.ReadLine());

            if (!ChecarPermissao(DateTime.Now.Year - ano))
            {
                Console.WriteLine("Você precisa ter mais de 18 anos para entrar");
                return;
            }

            Console.WriteLine("Acesso permitido!");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo:\n\n" +
                                  "1 - Aluno mais alto\n" +
                                  "2 - Aluno mais baixo\n" +
                                  "3 - Quantidade de pessoas maiores de idade\n" +
                                  "0 - Sair\n\n");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                    AlunoMaisAlto();
                else if (opcao == 2)
                    AlunoMaisBaixo();
                else if (opcao == 3)
                {
                    x = QuantidadeMaiorDeIdade(idades);
                    Console.WriteLine("\n{0} pessoas maiores de 18 anos", x);
                }

                if (opcao != 0)
                {
                    Console.WriteLine("Pressione ENTER para continuar.");
                    Console.ReadLine();
                }

            } while (opcao != 0);
        }

        /// <summary>
        /// Este método checa permissão de acesso, só terá permissão quem tiver 18 anos ou mais
        /// </summary>
        /// <param name="_idade">Informe sua idade</param>
        /// <returns>Retorna verdadeiro se a permissão for consentida, e retorna falso se for negada</returns>
        public static bool ChecarPermissao(int _idade)
        {
            if (_idade >= 18)
                return true;

            return false;
        }

        /// <summary>
        /// Este método solicita a matricula e a altura de 10 alunos e no final imprime
        /// na tela a altura e a matrícula do aluno mais alto.
        /// </summary>
        public static void AlunoMaisAlto()
        {
            double matricula, matriculaMaisAlto = 0;
            double altura, alturaMaisAlto = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("informe a " + (i + 1) + "º matricula:");
                matricula = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("informe a sua autura:");
                altura = Convert.ToDouble(Console.ReadLine());

                if (matricula >= matriculaMaisAlto)
                    matriculaMaisAlto = matricula;
                if (altura >= alturaMaisAlto)
                    alturaMaisAlto = altura;
            }

            Console.WriteLine("O aluno mais alto tem altura de {0} e a matrícula é {1}", alturaMaisAlto, matriculaMaisAlto);
        }

        /// <summary>
        /// Este método solicita a matricula e a altura de 10 alunos e no final imprime
        /// na tela a altura e a matrícula do aluno mais baixo.
        /// </summary>
        public static void AlunoMaisBaixo()
        {
            double matricula, matriculaMaisBaixo = 0;
            double altura, alturaMaisBaixo = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("informe a " + (i + 1) + "º matricula:");
                matricula = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("informe a sua autura:");
                altura = Convert.ToDouble(Console.ReadLine());

                if (matricula <= matriculaMaisBaixo || matriculaMaisBaixo == 0)
                    matriculaMaisBaixo = matricula;
                if (altura <= alturaMaisBaixo || alturaMaisBaixo == 0)
                    alturaMaisBaixo = altura;
            }

            Console.WriteLine("O aluno mais baixo tem altura de {0} e a matrícula é {1}", alturaMaisBaixo, matriculaMaisBaixo);
        }

        /// <summary>
        /// Este método recebe um array de inteiros analisa o conteúdo
        /// e calcula quantidade de pessoas com idade igual ou superior
        /// a 18 anos.
        /// </summary>
        /// <param name="_array">Informe o array a ser analisado</param>
        /// <returns>Retorna a quantidade de pessoas com com idade maior ou igual a 18</returns>
        public static int QuantidadeMaiorDeIdade(int[] _array)
        {
            int retorno = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] >= 18)
                    retorno = retorno + 1;
            }

            return retorno;
        }
    }
}