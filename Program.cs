// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using UC_12_BackEnd.classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPj = new PessoaJuridica ();
Endereco novoEndPf = new Endereco();


novaPf.nome = "Adriano";
novaPf.cpf = "12345678912";
novaPf.rendimento = 7000.5f;
novaPf.dataNasc = new DateTime (1979,01,01);
Console.WriteLine($"Pessoa Fisica =============");
float resultado = novaPf.CalcularImposto(7000);
Console.WriteLine(resultado);
Console.WriteLine($"Validação de datas =============");
DateTime temp = new DateTime(2000,01,01);
// Console.WriteLine(novaPF.ValidarDataNasc(temp));
Console.WriteLine(novaPf.ValidarDataNasc("01/01/2000"));

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.completento = "Predio";
novoEndPf.endComercial = true;

novaPf.endereco = novoEndPf;
Console.WriteLine(@$"
Nome: {novaPf.nome}
Nome da rua:{novaPf.endereco.logradouro}, numero: {novaPf.endereco.numero}
Maior de idade:{novaPf.ValidarDataNasc(novaPf.dataNasc)}
");


// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);

// Console.WriteLine($"-------------------------------------------------");


// Console.WriteLine($"Nome: {novaPF.nome}  Cpf: {novaPF.cpf}");

// novaPF.CalcularImposto(1800);

// Console.WriteLine(novaPF.CalcularImposto(1800));

Console.WriteLine($"Pessoa Juridica==========================================");


// Console.WriteLine(novaPj.CalcularImposto(12000.5f));

float impostoPagar = novaPj.CalcularImposto(12000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"{impostoPagar.ToString("C")}");





