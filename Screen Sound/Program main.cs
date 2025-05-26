using ScreenSound.Modelos;
//Screen Sound
Banda queen = new Banda ("Queen");

string mensagemDeBoasVindas = "********* screen sound app *********\n";
List<string> Listadasbandas = new List<string> { "beatles" };
Dictionary<string, Banda> bandasregistradas = new);
bandasregistradas.Add(queen.Nome, queen);
void ExibirLogo()
{
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesmenu()
{
    ExibirLogo();
    Console.WriteLine("digite 1 para registrar uma banda");
    Console.WriteLine("digite 2 para mostrar todas as bandas");
    Console.WriteLine("digite 3 para avaliar uma banda");
    Console.WriteLine("digite 4 para exibir a média de nota de uma banda");
    Console.WriteLine("digite -1 para sair\n");

    Console.Write("digite a sua opção:");
    string opcaoescolhida = Console.ReadLine()!;
    int opcaoescolhidanumerica = int.Parse(opcaoescolhida);

    switch (opcaoescolhidanumerica)
    {
        case 1:
            Registrarbanda();
            break;
        case 2:
            ExibirTodasBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaBanda();
            break;
        case -1:
            Console.WriteLine("tchau!");
            break;
        default:
            Console.WriteLine("opcão incorreta");
            break;
    }
}

void Registrarbanda()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("registro de bandas\n");
    Console.Write("digite o nome da banda que deseja registrar: ");
    string nomedabanda = Console.ReadLine()!;
    bandasregistradas.Add(nomedabanda, new List<int>());
    Console.WriteLine($"a banda {nomedabanda} foi registrada com sucesso!\n");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesmenu();
}

void ExibirTodasBandas()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("exibindo todas as bandas registradas: \n");
    for (int i = 0; i < Listadasbandas.Count; i++)
    {
        Console.WriteLine($"banda: {Listadasbandas[i]}\n");
    }
    foreach (string banda in bandasregistradas.Keys)
    {
        Console.WriteLine($"banda: {banda}\n");
    }

    Console.WriteLine("digite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesmenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("digite o nome da banda que deseja avaliar: ");
     nomedabanda = Console.ReadLine()!;
    if (bandasregistradas.ContainsKey(nomedabanda))
    {
        Console.WriteLine($"dê uma nota para a banda {nomedabanda}:");
        int nota = int.Parse(Console.ReadLine()!);
        bandasregistradas[nomedabanda].Add(nota);
        Console.WriteLine($"a nota {nota} foi registrada com sucesso para a banda {nomedabanda}!");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoesmenu();

    }
    else
    {
        Console.WriteLine($"a banda {nomedabanda} não foi encontrada!\n");
        Console.WriteLine("\ndigite uma tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesmenu();
    }

}

void ExibirMediaBanda()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("qual banda deseja consultar a média das notas?");
    string nomedabanda = Console.ReadLine()!;
    if (bandasregistradas.ContainsKey(nomedabanda))
    {
        List<int> notasdabanda = bandasregistradas[nomedabanda];
        Console.WriteLine($"a média de notas da banda {nomedabanda} é {notasdabanda.Average()}");
        Console.WriteLine("digite uma tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesmenu();

    }
    else
    {
        Console.WriteLine("banda não encontrada!");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoesmenu();

    }

}


ExibirOpcoesmenu();