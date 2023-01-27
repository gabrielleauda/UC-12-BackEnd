// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using UC_12_BackEnd.classes;

PessoaFisica novaPF = new PessoaFisica();

Console.WriteLine($"Pessoa Fisica =============");

novaPF.nome = "Adriano";
novaPF.cpf = "12345678912";
novaPF.rendimento = 7000.5f;
float resultado = novaPF.CalcularImposto(7000);

Console.WriteLine(resultado);

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);

// Console.WriteLine($"-------------------------------------------------");


// Console.WriteLine($"Nome: {novaPF.nome}  Cpf: {novaPF.cpf}");

// novaPF.CalcularImposto(1800);

// Console.WriteLine(novaPF.CalcularImposto(1800));

Console.WriteLine($"Pessoa Juridica==========================================");
PessoaJuridica novaPj = new PessoaJuridica ();

// Console.WriteLine(novaPj.CalcularImposto(12000.5f));

float impostoPagar = novaPj.CalcularImposto(12000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"{impostoPagar.ToString("C")}");





