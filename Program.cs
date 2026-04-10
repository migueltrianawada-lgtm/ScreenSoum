// Screen Sound

using System.Reflection.Metadata;

//Nome das Variaveis e com camel cases
string mesagem = "Screen Sound";
string curso = "Curso C#";
string nome = "Miguel";
string mensagen2 = "Harumi Triana vc e meu mundo todo te amo";
string sobrenome = "Triana";


//Nome das Funcioes e com Pascal Cases
void ExibirMensagem ()
{
    Console.WriteLine(nome);
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");

   
    Console.WriteLine(mensagen2);
    Console.WriteLine(sobrenome);
    Console.WriteLine(mesagem);
}

void ExibirMenu()
{
    Console.WriteLine("\n Digite 1 para registrar uma banda ");
    Console.WriteLine("\n Digite 2 Para mostrar todas as bandas   ");
    Console.WriteLine("\n Digite 3 Para avaliar uma banda ");
    Console.WriteLine("\n Digite 4 para exibir a Méia de uma banda  ");
    Console.WriteLine("\n Digite -1  para sair ");

    Console.Write("\n Digite sua opção : ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if(opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine("\n Voce Digito a opçaõ " + opcaoEscolhidaNumerica);
    }


}

ExibirMensagem();
ExibirMenu();



