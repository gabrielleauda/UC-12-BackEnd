// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using UC_12_BackEnd.classes;




Console.Clear();
Utils.BarraCarregamento("Iniciando sistema");

string? opcao;


do
{
    Console.Clear();
    Console.WriteLine(@$"
        ==========================================
        |    Bem Vindo ao Sistema de Cadastro    |
        |    de Pessoas Físicas e Juridicas      |
        ==========================================
        |    Digite o número da opção desejada   |
        ==========================================
        |                                        |
        |          1. Pessoa Física              |
        |          2. Pessoa Juridica            |
        |                                        |
        |          0. Sair                       |
        |                                        |
        ==========================================
");

opcao = Console.ReadLine();
Thread.Sleep(1000);

        switch (opcao)
    {
        case "1":

        PessoaFisica novaPf = new PessoaFisica();
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
        novoEndPf.complemento = "Predio";
        novoEndPf.endComercial = true;

        novaPf.endereco = novoEndPf;
        Console.WriteLine(@$"
        Nome: {novaPf.nome}
        Nome da rua:{novaPf.endereco.logradouro}, numero: {novaPf.endereco.numero}
        Maior de idade:{novaPf.ValidarDataNasc(novaPf.dataNasc)}
        ");


        Console.WriteLine(novaPf.nome);
        Console.WriteLine(novaPf.cpf);

        Console.WriteLine($"-------------------------------------------------");


        Console.WriteLine($"Nome: {novaPf.nome}  Cpf: {novaPf.cpf}");

        novaPf.CalcularImposto(1800);
        Console.WriteLine(novaPf.CalcularImposto(1800));

        Console.WriteLine($"Para continuar, tecle Enter.");
        Console.ReadLine();
            break;
            
        case "2":

        PessoaJuridica novaPj = new PessoaJuridica ();
        Endereco novoEndPj = new Endereco();

        Console.WriteLine(novaPj.ValidarCnpj("43.490.429/0001-17"));
        novaPj.cnpj = "43.490.429/0001-17";

        Console.WriteLine(@$"
        CNPJ: {novaPj.cnpj}
        Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
        ");

        Console.WriteLine($"Pessoa Juridica==========================================");

        novoEndPj.logradouro = "Rua Sergipe";
        novoEndPj.numero = 200;
        novoEndPj.complemento = "Predio";
        novoEndPj.endComercial = true;

        novaPj.endereco = novoEndPj;

        Console.WriteLine($"Pessoa Juridica==========================================");
        Console.WriteLine(novaPj.CalcularImposto(12000.5f));

        float impostoPagar = novaPj.CalcularImposto(12000.5f);
        Console.WriteLine($"R$ {impostoPagar:0.00}");
        Console.WriteLine($"{impostoPagar.ToString("C")}");

        Console.WriteLine($"Para continuar, tecle Enter.");
        Console.ReadLine();
            break;

        case "0":

        Console.WriteLine($"Obrigada por utilizar o nosso sistema!");
        // Console.WriteLine($"Para continuar, tecle Enter.");
        // Console.ReadLine();
            break;

        default:
            Console.WriteLine($"Opção inválida, indique um valor indicado a cima!");
            Console.WriteLine($"Para continuar, tecle Enter.");
            Console.ReadLine();
            break;
    }

} while (opcao != "0");

Utils.BarraCarregamento("Finalizando Sistema");
