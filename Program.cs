Console.Clear();

string senhaCorreta = "1234abcd" ;
string senha;


Console.Write("Digite a Senha de acesso: ");
senha = Console.ReadLine()!;

bool senhaAcesso = senha == senhaCorreta;

if(!senhaAcesso)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nAcesso Negado !!");
    Console.ResetColor();
    Environment.Exit(-1);
}
 
 Console.WriteLine("\nAcesso Permitido !!");


