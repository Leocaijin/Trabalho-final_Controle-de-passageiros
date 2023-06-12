# Trabalho-final_Controle-de-passageiros
Documentação trabalho ATP – Análise e desenvolvimento de sistemas  

Aluno: Leonardo de Souza Rodrigues, Matrícula: 790768 

  

*Objetivo do programa: 

O programa de voos tem como objetivo permitir o cadastro de voos, passageiros e realizar operações como visualizar os voos e passageiros cadastrados, alterar informações de passageiros e voos, e excluir passageiros e voos do sistema. 

  

*Detalhes de implementação: 

a. Métodos desenvolvidos: 

   - `CadastrarVoo()`: Responsável por cadastrar um novo voo no sistema. Recebe como parâmetros os dados do voo (código, origem, destino, distância e assentos disponíveis). 

   - `CadastrarPassageiro()`: Responsável por cadastrar um novo passageiro no sistema. Recebe como parâmetro o nome do passageiro. 

   - `VerVoos()`: Mostra as opções para visualizar os voos cadastrados e executa a ação escolhida pelo usuário. Não possui parâmetros de entrada e não retorna valor. 

   - `VerPassageiros()`: Mostra as opções para visualizar os passageiros cadastrados e executa a ação escolhida pelo usuário. Não possui parâmetros de entrada e não retorna valor. 

   - `AlterarPassageiro()`: Permite alterar o nome de um passageiro cadastrado. Recebe como parâmetros o código do passageiro e o novo nome. 

   - `ExcluirPassageiro()`: Permite excluir um passageiro do sistema. Recebe como parâmetro o código do passageiro. 

   - `AlterarVoo()`: Permite alterar o destino e a distância de um voo cadastrado. Recebe como parâmetros o código do voo, o novo destino e a nova distância. 

   - `ExcluirVoo()`: Permite excluir um voo do sistema. Recebe como parâmetro o código do voo. 

  

b. Como executar o programa: 

   - Compile e execute o programa em um ambiente de desenvolvimento C# (por exemplo, Visual Studio). 

   - O programa apresentará um menu com opções numeradas. 

   - Digite o número correspondente à opção desejada e pressione Enter para executar a ação correspondente. 

  

c. Testes realizados: 

   - Foram realizados testes para cada uma das funcionalidades do programa, como cadastrar voos, cadastrar passageiros, visualizar voos e passageiros, alterar informações e excluir registros. Os testes foram feitos para verificar se as operações são executadas corretamente e se as informações são armazenadas e recuperadas de forma adequada. 

  

d. Decisões de implementação: 

   - Para armazenar os dados dos voos, foram utilizados arrays unidimensionais para cada atributo do voo (código, origem, destino, distância e assentos disponíveis). Os voos são armazenados em posições correspondentes nos arrays, utilizando a variável `numVoos` para controlar a quantidade de voos cadastrados. 

   - Para armazenar os passageiros e seus assentos, foi utilizada uma matriz bidimensional, onde cada linha representa um passageiro e cada coluna representa um voo. O valor 1 na posição [i, j] indica que o passageiro i está alocado no voo j. A variável `numPassageiros` controla a quantidade de passageiros cadastrados. 
