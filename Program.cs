string? Produto;
Console.WriteLine("Insira o nome do produto: ");
Produto = Console.ReadLine();

int Quantidade;
Console.WriteLine("Insira uma quantidade ao produto: ");
Quantidade = Convert.ToInt32(Console.ReadLine());

int Valor;
Console.WriteLine("Insira o valor do produto: ");
Valor = Convert.ToInt32(Console.ReadLine());

int mult = Quantidade * Valor;

Console.WriteLine("O valor de {0} é {1}", Produto, mult);