//Screen Sound
//C# É fortemente tipada

//string mensagemDeBoasVindas = "********* SCREEN SOUND APP *********\n";
//List<string> ListaDasBandas = new List<string> { "Beatles" };
//Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
//BandasRegistradas.Add("soad", new List<int> { 10, 07, 08 });
//void ExibirLogo()
//{
//    Console.WriteLine(mensagemDeBoasVindas);
//}

//void ExibirOpcoesDoMenu()
//{
//    ExibirLogo();
//    Console.WriteLine("Digite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para exibir a média de nota de uma banda");
//    Console.WriteLine("Digite -1 para sair\n");

//    Console.Write("Digite a sua opção:");
//    string opcaoEscolhida = Console.ReadLine()!;
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//    switch (opcaoEscolhidaNumerica)
//    {
//        case 1:
//            RegistrarBanda();
//            break;
//        case 2:
//            ExibirTodasAsBandas();
//            break;
//        case 3:
//            AvaliarBanda();
//            break;
//        case 4:
//            ExibirMediaBanda();
//            break;
//        case -1:
//            Console.WriteLine("Tchau!");
//            break;
//        default:
//            Console.WriteLine("Opcão incorreta");
//            break;
//    }
//}

//void RegistrarBanda()
//{
//    Console.Clear();
//    ExibirLogo();
//    Console.WriteLine("Registro de bandas\n");
//    Console.Write("Digite o nome da banda que deseja registrar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    BandasRegistradas.Add(nomeDaBanda, new List<int>());
//    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!\n");
//    Thread.Sleep(1000);
//    Console.Clear();
//    ExibirOpcoesDoMenu();
//}

//void ExibirTodasAsBandas()
//{
//    Console.Clear();
//    ExibirLogo();
//    Console.WriteLine("Exibindo todas as bandas registradas: \n");
//    for (int i = 0; i < ListaDasBandas.Count; i++)
//    {
//        Console.WriteLine($"Banda: {ListaDasBandas[i]}\n");
//    }
//    foreach (string banda in BandasRegistradas.Keys)
//    {
//        Console.WriteLine($"Banda: {banda}\n");
//    }

//    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
//    Console.ReadKey();
//    Console.Clear();
//    ExibirOpcoesDoMenu();
//}

//void AvaliarBanda()
//{
//    Console.Clear();
//    ExibirLogo();
//    Console.Write("Digite o nome da banda que deseja avaliar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (BandasRegistradas.ContainsKey(nomeDaBanda))
//    {
//        Console.WriteLine($"Dê uma nota para a banda {nomeDaBanda}:");
//        int nota = int.Parse(Console.ReadLine()!);
//        BandasRegistradas[nomeDaBanda].Add(nota);
//        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
//        Thread.Sleep(1000);
//        Console.Clear();
//        ExibirOpcoesDoMenu();

//    }
//    else
//    {
//        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!\n");
//        Console.WriteLine("\nDigite uma tecla para retornar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }

//}

//void ExibirMediaBanda()
//{
//    Console.Clear();
//    ExibirLogo();
//    Console.WriteLine("Qual banda deseja consultar a média das notas?");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (BandasRegistradas.ContainsKey(nomeDaBanda))
//    {
//        List<int> notasDaBanda = BandasRegistradas[nomeDaBanda];
//        Console.WriteLine($"A média de notas da banda {nomeDaBanda} é {notasDaBanda.Average()}");
//        Console.WriteLine("Digite uma tecla para retornar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();

//    }
//    else
//    {
//        Console.WriteLine("Banda não encontrada!");
//        Thread.Sleep(1000);
//        Console.Clear();
//        ExibirOpcoesDoMenu();

//    }

//}
//ExibirOpcoesDoMenu();