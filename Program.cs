using System;
/*Trabalho ATP Análise e Desenvolvimento de sistemas
 Aluno: Leonardo de Souza Rodrigues.*/
 
class Program
{
    static string[] passageiros = new string[100];
    static int[,] matrizAssentos = new int[100, 100];
    static string[] voosCodigos = new string[100];
    static string[] voosOrigens = new string[100];
    static string[] voosDestinos = new string[100];
    static int[] voosAssentos = new int[100];
    static int[] voosDistancias = new int[100];
    static int numPassageiros = 0;
    static int numVoos = 0;

    static void Main()
    {
        /// <summary>
        /// Menu de opções Imprime o cabeçalho do sistema de passagens aereas
        /// </summary>
        bool sair = false;

        while (!sair)
        {
            //Opcoes do menu
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("======== Sistema de Passagens Aéreas ========");
            Console.WriteLine("1. Cadastrar Passageiro");
            Console.WriteLine("2. Cadastrar Vôo");
            Console.WriteLine("3. Ver Vôos");
            Console.WriteLine("4. Ver Passageiros");
            Console.WriteLine("5. Alterar Passageiro");
            Console.WriteLine("6. Excluir Passageiro");
            Console.WriteLine("7. Alterar Vôo");
            Console.WriteLine("8. Excluir Vôo");
            Console.WriteLine("9. Sair");
            Console.Write("Escolha uma opção: ");
            
           //Lê a opção escolhida pelo usuário
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarPassageiro();break;
                case 2:
                    CadastrarVoo();break;
                case 3:
                    VerVoos();break;
                case 4:
                    VerPassageiros();break;
                case 5:
                    AlterarPassageiro();break;
                case 6:
                    ExcluirPassageiro();break;
                case 7:
                    AlterarVoo();break;
                case 8:
                    ExcluirVoo();break;
                case 9:
                    sair = true;
                    Console.WriteLine("A companhia aérea Air-Force agradece a sua visita! ");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");break;
                    
            }

            Console.WriteLine();
        }
    }

    static void CadastrarPassageiro()
    {
        Console.WriteLine("===== Cadastrar Passageiro =====");

        if (numPassageiros >= 100)
        {
            Console.WriteLine("Limite de passageiros atingido.");
            return;
        }

        Console.Write("Digite o código do passageiro: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do passageiro: ");
        string nome = Console.ReadLine();

        passageiros[numPassageiros] = nome;
        matrizAssentos[numPassageiros, 0] = codigo;

        numPassageiros++;

        Console.WriteLine("Passageiro cadastrado com sucesso!");
    }

    static void CadastrarVoo()
    {
        Console.WriteLine("===== Cadastrar Vôo =====");

        if (numVoos >= 100)
        {
            Console.WriteLine("Limite de vôos atingido.");
            return;
        }

        Console.Write("Digite o código do vôo: ");
        string codigo = Console.ReadLine();

        Console.Write("Digite a origem do vôo: ");
        string origem = Console.ReadLine();

        Console.Write("Digite o destino do vôo: ");
        string destino = Console.ReadLine();

        Console.Write("Digite a quantidade de assentos disponíveis: ");
        int assentos = int.Parse(Console.ReadLine());

        Console.Write("Digite a distância do vôo (em km): ");
        int distancia = int.Parse(Console.ReadLine());

        voosCodigos[numVoos] = codigo;
        voosOrigens[numVoos] = origem;
        voosDestinos[numVoos] = destino;
        voosAssentos[numVoos] = assentos;
        voosDistancias[numVoos] = distancia;

        numVoos++;

        Console.WriteLine("Vôo cadastrado com sucesso!");
    }

    static void VerVoos()
    {
        Console.WriteLine("===== Ver Vôos =====");
        Console.WriteLine("1. Todos os Vôos");
        Console.WriteLine("2. Vôos com Origem e Destino");
        Console.Write("Escolha uma opção: ");
        int subOpcao = int.Parse(Console.ReadLine());

        switch (subOpcao)
        {
            case 1:
                VerTodosVoos();
                break;
            case 2:
                VerVoosOrigemDestino();
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    static void VerTodosVoos()
    {
        Console.WriteLine("===== Todos os Vôos =====");

        for (int i = 0; i < numVoos; i++)
        {
            Console.WriteLine($"Código: {voosCodigos[i]}");
            Console.WriteLine($"Origem: {voosOrigens[i]}");
            Console.WriteLine($"Destino: {voosDestinos[i]}");
            Console.WriteLine($"Assentos Disponíveis: {voosAssentos[i]}/{voosAssentos[i]}");
            Console.WriteLine($"Distância: {voosDistancias[i]} km");
            Console.WriteLine();
        }
    }

    static void VerVoosOrigemDestino()
    {
        Console.WriteLine("===== Vôos com Origem e Destino =====");
        Console.Write("Digite a origem: ");
        string origem = Console.ReadLine();

        Console.Write("Digite o destino: ");
        string destino = Console.ReadLine();

        bool encontrouVoos = false;

        for (int i = 0; i < numVoos; i++)
        {
            if (voosOrigens[i].Equals(origem, StringComparison.OrdinalIgnoreCase) && voosDestinos[i].Equals(destino, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Código: {voosCodigos[i]}");
                Console.WriteLine($"Origem: {voosOrigens[i]}");
                Console.WriteLine($"Destino: {voosDestinos[i]}");
                Console.WriteLine($"Assentos Disponíveis: {voosAssentos[i]}/{voosAssentos[i]}");
                Console.WriteLine($"Distância: {voosDistancias[i]} km");
                Console.WriteLine();
                encontrouVoos = true;
            }
        }

        if (!encontrouVoos)
        {
            Console.WriteLine("Nenhum vôo encontrado com a origem e destino informados.");
        }
    }

    static void VerPassageiros()
    {
        Console.WriteLine("===== Ver Passageiros =====");
        Console.WriteLine("1. Passageiro Específico");
        Console.WriteLine("2. Todos Passageiros de um Vôo");
        Console.Write("Escolha uma opção: ");
        int subOpcao = int.Parse(Console.ReadLine());

        switch (subOpcao)
        {
            case 1:
                VerPassageiroEspecifico();
                break;
            case 2:
                VerPassageirosVoo();
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    static void VerPassageiroEspecifico()
    {
        Console.WriteLine("===== Passageiro Específico =====");
        Console.Write("Digite o código do passageiro: ");
        int codigo = int.Parse(Console.ReadLine());

        int indicePassageiro = -1;
        for (int i = 0; i < numPassageiros; i++)
        {
            if (matrizAssentos[i, 0] == codigo)
            {
                indicePassageiro = i;
                break;
            }
        }

        if (indicePassageiro != -1)
        {
            string nome = passageiros[indicePassageiro];
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nome: {nome}");
        }
        else
        {
            Console.WriteLine("Passageiro não encontrado.");
        }
    }

    static void VerPassageirosVoo()
    {
        Console.WriteLine("===== Todos Passageiros de um Vôo =====");
        Console.Write("Digite o código do vôo: ");
        string codigoVoo = Console.ReadLine();

        int indiceVoo = -1;
        for (int i = 0; i < numVoos; i++)
        {
            if (voosCodigos[i].Equals(codigoVoo, StringComparison.OrdinalIgnoreCase))
            {
                indiceVoo = i;
                break;
            }
        }

        if (indiceVoo != -1)
        {
            Console.WriteLine($"Código do Vôo: {voosCodigos[indiceVoo]}");
            Console.WriteLine($"Origem: {voosOrigens[indiceVoo]}");
            Console.WriteLine($"Destino: {voosDestinos[indiceVoo]}");
            Console.WriteLine($"Assentos Disponíveis: {voosAssentos[indiceVoo]}/{voosAssentos[indiceVoo]}");
            Console.WriteLine($"Distância: {voosDistancias[indiceVoo]} km");
            Console.WriteLine();

            bool encontrouPassageiros = false;

            for (int i = 0; i < numPassageiros; i++)
            {
                if (matrizAssentos[i, indiceVoo] != 0)
                {
                    int codigoPassageiro = matrizAssentos[i, 0];
                    string nome = passageiros[i];
                    Console.WriteLine($"Código do Passageiro: {codigoPassageiro}");
                    Console.WriteLine($"Nome: {nome}");
                    encontrouPassageiros = true;
                }
            }

            if (!encontrouPassageiros)
            {
                Console.WriteLine("Nenhum passageiro encontrado para este vôo.");
            }
        }
        else
        {
            Console.WriteLine("Vôo não encontrado.");
        }
    }

    static void AlterarPassageiro()
    {
        Console.WriteLine("===== Alterar Passageiro =====");
        Console.Write("Digite o código do passageiro: ");
        int codigo = int.Parse(Console.ReadLine());

        int indicePassageiro = -1;
        for (int i = 0; i < numPassageiros; i++)
        {
            if (matrizAssentos[i, 0] == codigo)
            {
                indicePassageiro = i;
                break;
            }
        }

        if (indicePassageiro != -1)
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nome Atual: {passageiros[indicePassageiro]}");

            Console.Write("Digite o novo nome: ");
            string novoNome = Console.ReadLine();

            passageiros[indicePassageiro] = novoNome;

            Console.WriteLine("Passageiro alterado com sucesso!");
        }
        else
        {
            Console.WriteLine("Passageiro não encontrado.");
        }
    }

    static void ExcluirPassageiro()
    {
        Console.WriteLine("===== Excluir Passageiro =====");
        Console.Write("Digite o código do passageiro: ");
        int codigo = int.Parse(Console.ReadLine());

        int indicePassageiro = -1;
        for (int i = 0; i < numPassageiros; i++)
        {
            if (matrizAssentos[i, 0] == codigo)
            {
                indicePassageiro = i;
                break;
            }
        }

        if (indicePassageiro != -1)
        {
            for (int i = indicePassageiro; i < numPassageiros - 1; i++)
            {
                passageiros[i] = passageiros[i + 1];
                for (int j = 0; j < numVoos; j++)
                {
                    matrizAssentos[i, j] = matrizAssentos[i + 1, j];
                }
            }

            numPassageiros--;

            Console.WriteLine("Passageiro excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Passageiro não encontrado.");
        }
    }

    static void AlterarVoo()
    {
        Console.WriteLine("===== Alterar Vôo =====");
        Console.Write("Digite o código do vôo: ");
        string codigo = Console.ReadLine();

        int indiceVoo = -1;
        for (int i = 0; i < numVoos; i++)
        {
            if (voosCodigos[i].Equals(codigo, StringComparison.OrdinalIgnoreCase))
            {
                indiceVoo = i;
                break;
            }
        }

        if (indiceVoo != -1)
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Origem Atual: {voosOrigens[indiceVoo]}");
            Console.WriteLine($"Destino Atual: {voosDestinos[indiceVoo]}");
            Console.WriteLine($"Distância Atual: {voosDistancias[indiceVoo]} km");
            Console.WriteLine($"Assentos Disponíveis Atual: {voosAssentos[indiceVoo]}/{voosAssentos[indiceVoo]}");

            Console.Write("Digite a nova origem: ");
            string novaOrigem = Console.ReadLine();

            Console.Write("Digite o novo destino: ");
            string novoDestino = Console.ReadLine();

            Console.Write("Digite a nova distância: ");
            int novaDistancia = int.Parse(Console.ReadLine());

            Console.Write("Digite a nova quantidade de assentos disponíveis: ");
            int novosAssentos = int.Parse(Console.ReadLine());
        
                // Atualiza as informações de um voo nos arrays correspondentes.
               //- voosOrigens: array que armazena as origens dos voos.
              // - voosDestinos: array que armazena os destinos dos voos...
            voosOrigens[indiceVoo] = novaOrigem;
            voosDestinos[indiceVoo] = novoDestino;
            voosDistancias[indiceVoo] = novaDistancia;
            voosAssentos[indiceVoo] = novosAssentos;

            Console.WriteLine("Vôo alterado com sucesso!");
        }
        else
        {
            Console.WriteLine("Vôo não encontrado.");
        }
    }

    static void ExcluirVoo()
    {
        Console.WriteLine("===== Excluir Vôo =====");
        Console.Write("Digite o código do vôo: ");
        string codigo = Console.ReadLine();

        int indiceVoo = -1;
        for (int i = 0; i < numVoos; i++)
        {
            if (voosCodigos[i].Equals(codigo, StringComparison.OrdinalIgnoreCase))
            {
                indiceVoo = i;
                break;
            }
        }

        if (indiceVoo != -1)
        {
            for (int i = indiceVoo; i < numVoos - 1; i++)
            {
                voosCodigos[i] = voosCodigos[i + 1];
                voosOrigens[i] = voosOrigens[i + 1];
                voosDestinos[i] = voosDestinos[i + 1];
                voosDistancias[i] = voosDistancias[i + 1];
                voosAssentos[i] = voosAssentos[i + 1];
                for (int j = 0; j < numPassageiros; j++)
                {
                    matrizAssentos[j, i] = matrizAssentos[j, i + 1];
                }
            }

            numVoos--;

            Console.WriteLine("Vôo excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Vôo não encontrado.");
        }
    }
}
