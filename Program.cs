// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using UC_12_BackEnd.classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Adriano";
novaPF.cpf = "12345678912";

Console.WriteLine(novaPF.nome);
Console.WriteLine(novaPF.cpf);

Console.WriteLine($"-------------------------------------------------");


Console.WriteLine($"Nome: {novaPF.nome}  Cpf: {novaPF.cpf}");

