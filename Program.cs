using System;


namespace DIO.Series
{
    class Program
    {
        static SeriesRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() ! = "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                         ListarSeries();
                        break;
                    case "2":
                         InserirSeries();
                         break;
                    case "3":
                         AtualizarSerie();     
                        break; 
                    case "4":
                         ExcluirSerie();
                        break;
                    case "5":
                         VisualizarSerie();
                        break;
                    case "6":
                         ListarFilmes();
                        break;
                    case "7":
                         InserirFilmes();
                         break;
                    case "8":
                         AtualizarFilmes();     
                        break; 
                    case "9":
                         ExcluirFilmes();
                        break;
                    case "10":
                         VisualizarFilmes();
                        break;    
                    case "C":
                         Console.Clear();
                        break;

                    default:
                       throw new ArgumentOutOfRangeException();
                }
            }
            Console.WriteLine("Obrigado por utilizar os nossos serviços.");
            Console.ReadLine();
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie =repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void AtualizarSerie()
        {
           Console.Write("Digite o id da série: ");
           int indiceSerie = int.Parse(Console.ReadLine());

           foreach (int i in Enum.GetValues(typeof(Genero)))
           {
               Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
           }  
           Console.Write("Digite o gênero entre as opções acima: ");
           int entradaGenero = int.Parse(Console.ReadLine());

           Console.Write("Digiteo título da série: ");
           string entradaTitulo = Console.ReadLine();

           Console.Write("Digite o Ano de lançamento: ");
           int entradaAno = int.Parse(Console.ReadLine());

           Console.Write("Digite a descrição da série: ");
           int entradaDescricao = int.Parse(Console.ReadLine());

            Series AtualizarSerie = new Series(id: indiceSerie,
                                            Genero: (Genero)entradaGenero,
                                            Titulo: entradaTitulo,
                                            Ano: entradaAno,
                                            Descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, AtualizarSerie); 
        }


        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                 Console.WriteLine("Nenhuma série cadastrada.");
                 return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido()
                Console.WriteLine("#ID (0): - {1}", serie.retornaId(), serie.retornaTitulo());
            }

        }

        private static void InserirSeries()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            } 
            Console.Write("Digite o gênero entre as opçõs acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSeries = new Series(id: repositorio.ProximoId(),
                                            Genero: (Genero)entradaGenero,
                                            Titulo: entradaTitulo,
                                            Ano: entradaAno,
                                            Descricao: entradaDescricao);

            repositorio.Insere(novaSeries);                                
        }

        static FilmesRepositorio repositorio = new FilmesRepositorio();

         private static void ExcluirFilmes()
        {
            Console.Write("Digite o id da filmes: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceFilmes);
        }

         private static void ExcluirFilmes()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceFilmes);
        }

        private static void AtualizarFilmes()
        {
           Console.Write("Digite o id da filmes: ");
           int indiceFilmes = int.Parse(Console.ReadLine());

           foreach (int i in Enum.GetValues(typeof(Genero)))
           {
               Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
           }  
           Console.Write("Digite o gênero entre as opções acima: ");
           int entradaGenero = int.Parse(Console.ReadLine());

           Console.Write("Digiteo título da série: ");
           string entradaTitulo = Console.ReadLine();

           Console.Write("Digite o Ano de lançamento: ");
           int entradaAno = int.Parse(Console.ReadLine());

           Console.Write("Digite a descrição do filme: ");
           int entradaDescricao = int.Parse(Console.ReadLine());

            Series AtualizarSerie = new Series(id: indiceFilmes,
                                            Genero: (Genero)entradaGenero,
                                            Titulo: entradaTitulo,
                                            Ano: entradaAno,
                                            Descricao: entradaDescricao);

            repositorio.Atualiza(indiceFilmes, AtualizarFilmes); 
        }

        private static void ListarFilmes()
        {
            Console.WriteLine("Listar Filmes");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                 Console.WriteLine("Nenhuma série cadastrada.");
                 return;
            }

            foreach (var Filmes in lista)
            {
                var excluido = filmes.retornaExcluido()
                Console.WriteLine("#ID (0): - {1}", serie.retornaId(), serie.retornaTitulo());
            }

        }

        private static void InserirFilmes()
        {
            Console.WriteLine("Inserir novo filme:");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            } 
            Console.Write("Digite o gênero entre as opçõs acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes novoFilmes = new Filmes(id: repositorio.ProximoId(),
                                            Genero: (Genero)entradaGenero,
                                            Titulo: entradaTitulo,
                                            Ano: entradaAno,
                                            Descricao: entradaDescricao);

            repositorio.Insere(novoFilmes);                                
        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Mr. Séries ao seu dispor !");
            Console.WriteLine("Nos informe a opção desejada: ");

            Console.WriteLine("1- Listar séries ");
            Console.WriteLine("2- Inserir nova série ");
            Console.WriteLine("3- Atualizar série ");
            Console.WriteLine("4- Excluir série ");
            Console.WriteLine("5- Visualizar série ");
            Console.WriteLine("C- Limpar tela ");
            Console.WriteLine("X- sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
