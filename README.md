# Boas-vindas ao repositório do exercício Customer CRUD

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-exercises-customer-crud.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-exercises-customer-crud`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-exercises-customer-crud`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-exercises-customer-crud`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-exercises-customer-crud/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-exercises-customer-crud/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Agora que você já sabe como criar uma API básica, com controllers funcionais que implementam um CRUD, que tal testarmos isso na prática?

Vamos imaginar que você precisa construir uma API para uma plataforma financeira que registre um banco de dados de clientes e suas transações. Seu desafio será implementar os métodos do controller `CustomerController` e os testes necessários para validar o seu funcionamento.

Parte da aplicação já está configurada, especialmente:
- um banco de dados local em JSON, utilizando a biblioteca [`JsonFlatFileDataStore`](https://github.com/ttu/json-flatfile-datastore)
- Uma classe `CustomerRepository` e uma interface `ICustomerRepository`, que implementam o padrão de projeto _repository_ e que servem para facilitar o acesso à camada de acesso ao banco
- a classe `Program`, que já integra os serviços referentes ao banco e ao _repository_ na aplicação, tornando-os acessíveis no controller por meio da **injeção de dependência**

Como temos um repository já implementado, você pode utilizar os métodos da interface `ICustomerRepository` dentro do controller para fazer operações no banco de dados em JSON sem se preocupar com os detalhes de implementação!

**Antes de tudo, vamos configurar o projeto:**
 
## Configurando o `CustomerController`

<details>
  <summary>A classe <code>CustomerController</code> deve ser decorada com o atributo <code>ApiController</code></summary><br />

Esse atributo irá permitir que o controller seja detectado como tal pela aplicação. 
  
</details>

<details>
  <summary>A classe <code>CustomerController</code> deve utilizar o atributo <code>Route</code> para determinar uma rota base <code>"/controller"</code></summary><br />

A rota definida no atributo Route será usada como base por todos os métodos do controller.
  
</details>

<details>
  <summary>A classe <code>CustomerController</code> deve herdar da classe <code>ControllerBase</code></summary><br />

Essa classe define métodos úteis que retornarão objetos derivados de ActionResult e poderão ser usados nos métodos do controller para retornar respostas HTTP completas de forma simples.
  
</details>

<details>
  <summary>A classe <code>CustomerController</code> deve possuir um campo privado e somente leitura do tipo <code>ICustomerRepository</code></summary><br />

Esse campo, que armazenará uma referência ao singleton do repositório, poderá ser utilizada para invocar os seus métodos e, através deles, ler e modificar informações armazenadas no banco.
  
</details>

<details>
  <summary>A classe <code>CustomerController</code> deve possuir um controller que receba um <code>ICustomerRepository</code> e o atribua ao campo criado anteriormente</summary><br />

O serviço <code>CustomerRepository</code> será passado para o controller automaticamente, por injeção de dependência, pois trata-se de um dos serviços preconfigurados na classe <code>Program</code>.
  
</details>

---

## 1 - Crie o método `GetAll`

<details>
  <summary>O método <code>GetAll</code> deve ser acessível por uma requisição <code>GET</code> na rota <code>"/controller"</code></summary><br />

Como a rota usada é a mesma que a rota base, apenas é necessário utilizar neste método o atributo que represente o verbo HTTP correto, sem nenhum parâmetro a mais.
  
</details>

</details>

<details>
  <summary>O método <code>GetAll</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>200 (Ok)</code>, caso a leitura ocorra corretamente</summary><br />

O método <code>Ok()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.
  
</details>

<details>
  <summary>A resposta do método <code>GetAll</code> deve retornar em seu corpo todas as entradas do banco</summary><br />

Ao usar a rota <code>"GET /controller"</code> devemos receber em resposta um array JSON contendo todos os objetos do tipo <code>Customer</code> salvos no banco.
  
</details>

<details>
  <summary>O método <code>GetAllTest</code> deve conter os testes para o método <code>GetAll</code></summary><br />

O seu teste deve conter:
- Uma chamada `GET` para a rota `"/customers"` utilizando o `_client`
- Um mock do método `GetAll()` do repositório, configurado usando o `_repositoryMock`
- Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo `200 (Ok)`
- Uma verificação de que o conteúdo da resposta é equivalente ao objeto retornado pelo mock
- Uma verificação de que o método mockado foi chamado uma única vez
  
</details>

---

## 2 - Crie o método `GetById`

<details>
  <summary>O método <code>GetById</code> deve ser acessível por uma requisição <code>GET</code> na rota <code>"/controller/{id}"</code></summary><br />

Como a rota usada possui um query parameter, além do atributo que represente o verbo HTTP correto, é necessário indicar também o parâmetro recebido.
  
</details>

<details>
  <summary>O método <code>GetById</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>200 (Ok)</code>, caso a leitura ocorra corretamente</summary><br />

O método <code>Ok()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.
  
</details>

<details>
  <summary>O método <code>GetById</code> deve retornar em seu corpo apenas a entrada com o <code>Id</code> indicado, caso a leitura ocorra corretamente</summary><br />

Ao usar essa rota devemos receber um objeto único em JSON, cujo <code>Id</code> corresponda ao valor passado na URL.
  
</details>

<details>
  <summary>O método <code>GetById</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>404 (Not Found)</code>, caso não haja um objeto com o <code>Id</code> passado</summary><br />

O método <code>NotFound()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

</details>

<details>
  <summary>O método <code>GetById</code> deve retornar em seu corpo a mensagem <code>"Customer not found"</code>, caso não haja um objeto com o <code>Id</code> passado</summary><br />

Ao usar essa rota devemos receber apenas uma <code>string</code> indicando que não há nenhum objeto que possua o <code>Id</code> correspondente.
  
</details>

<details>
  <summary>O método <code>GetByIdTest</code> deve conter os testes para o método <code>GetById</code></summary><br />

O seu teste deve conter:
- Uma chamada `GET` para a rota `"/customers/1"` utilizando o `_client`
- Um mock do método `GetById()` do repositório, configurado usando o `_repositoryMock`
  - O método mockado deve retornar o objeto correto apenas se receber o id `1`
- Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo `200 (Ok)`
- Uma verificação de que o conteúdo da resposta é equivalente ao objeto retornado pelo mock
- Uma verificação de que o método mockado foi chamado uma única vez
  
</details>

---

## 3 - Crie o método `Create`

<details>
  <summary>O método <code>Create</code> deve ser acessível por uma requisição <code>POST</code> na rota <code>"/controller"</code></summary><br />

Como a rota usada é a mesma que a rota base, apenas é necessário utilizar neste método o atributo que represente o verbo HTTP correto, sem nenhum parâmetro a mais.
  
</details>

<details>
  <summary>O método <code>Create</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>201 (Created)</code>, caso a leitura ocorra corretamente</summary><br />

O método <code>CreatedAtAction()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.
  
</details>

<details>
  <summary>O método <code>Create</code> deve retornar em seu corpo o objeto criado, contendo o <code>Id</code> e os timestamps de criação e update atribuídos</summary><br />

Ao usar essa rota, devemos receber um objeto único em JSON, cujo <code>Id</code> seja único e corretamente atribuído e cujos <code>CreatedAt</code> e <code>UpdatedAt</code> sejam criados praticamente no mesmo instante (é tolerável uma diferença de até 100 ms).
  
</details>

<details>
  <summary>O método <code>Create</code> deve ter um atributo <code>location</code> no header da resposta com a rota do <code>GetById</code> que pode acessar o objeto criado</summary><br />

O método <code>CreatedAtAction()</code> do <code>ControllerBase</code> retorna esse header automaticamente caso seja configurado da forma correta.

</details>

<details>
  <summary>O método <code>CreateTest</code> deve conter os testes para o método <code>Create</code></summary><br />

O seu teste deve conter:
- Uma chamada `POST` para a rota `"/customers"` utilizando o `_client`
- Um mock do método `GetNextIdValue()` do repositório, configurado usando o `_repositoryMock`
- Um mock do método `Create()` do repositório, configurado usando o `_repositoryMock`
  - O método mockado deve retornar o objeto correto apenas se receber um objeto com o mesmo id retornado pelo mock de `GetNextIdValue()`
- Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo `201 (Created)`
- Verificações de que os campos do objeto retornado possuem os valores esperados
- Verificações de que os métodos mockados foram chamados uma única vez cada
  
</details>

---

## 4 - Crie o método `Update`

<details>
  <summary>O método <code>Update</code> deve ser acessível por uma requisição <code>PUT</code> na rota <code>"/controller/{id}"</code></summary><br />

Como a rota usada possui um query parameter, além do atributo que represente o verbo HTTP correto, é necessário indicar também o parâmetro recebido.
  
</details>

<details>
  <summary>O método <code>Update</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>200 (Ok)</code>, caso a atualização ocorra corretamente</summary><br />

O método <code>Ok()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.
  
</details>

<details>
  <summary>O método <code>Update</code> deve retornar em seu corpo apenas uma mensagem <code>"Customer {id} updated"</code> caso a atualização seja bem-sucedida</summary><br />

Ao usar essa rota, devemos receber um objeto único em JSON, cujo <code>Id</code> corresponda ao valor passado na URL.
  
</details>

<details>
  <summary>O método <code>Update</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>404 (Not Found)</code>, caso não haja um objeto com o <code>Id</code> passado</summary><br />

O método <code>NotFound()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

</details>

<details>
  <summary>O método <code>Update</code> deve retornar em seu corpo a mensagem <code>"Customer not found"</code>, caso não haja um objeto com o <code>Id</code> passado</summary><br />

Ao usar essa rota devemos receber apenas uma <code>string</code> indicando que não há nenhum objeto que possua o <code>Id</code> correspondente.
  
</details>

<details>
  <summary>O método <code>UpdateTest</code> deve conter os testes para o método <code>Update</code></summary><br />

O seu teste deve conter:
- Uma chamada `PUT` para a rota `"/customers/1"` utilizando o `_client`
- Um mock do método `Update()` do repositório, configurado usando o `_repositoryMock`
  - O método mockado deve retornar `true` apenas se receber o id `1`
- Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo `200 (Ok)`
- Uma verificação de que o corpo da resposta é a mensagem `"Customer 1 updated"`
- Uma verificação de que o método mockado foi chamado uma única vez
  
</details>

---

## 5 - Crie o método `Delete`

<details>
  <summary>O método <code>Delete</code> deve ser acessível por uma requisição <code>DELETE</code> na rota <code>"/controller/{id}"</code></summary><br />

Como a rota usada possui um query parameter, além do atributo que represente o verbo HTTP correto, é necessário indicar também o parâmetro recebido.
  
</details>

<details>
  <summary>O método <code>Delete</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>204 (No Content)</code>, caso a deleção ocorra corretamente</summary><br />

O método <code>NoContent()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.
  
</details>

<details>
  <summary>O método <code>Delete</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>404 (Not Found)</code>, caso não haja um objeto com o <code>Id</code> passado</summary><br />

O método <code>NotFound()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

</details>

<details>
  <summary>O método <code>Delete</code> deve retornar em seu corpo a mensagem <code>"Customer not found"</code>, caso não haja um objeto com o <code>Id</code> passado</summary><br />

Ao usar essa rota, devemos receber apenas uma <code>string</code> indicando que não há nenhum objeto que possua o <code>Id</code> correspondente.
  
</details>


<details>
  <summary>O método <code>DeleteTest</code> deve conter os testes para o método <code>Delete</code></summary><br />

O seu teste deve conter:
- Uma chamada `DELETE` para a rota `"/customers/1"` utilizando o `_client`
- Um mock do método `Delete()` do repositório, configurado usando o `_repositoryMock`
  - O método mockado deve retornar `true` apenas se receber o id `1`
- Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo `204 (No Content)`
- Uma verificação de que o método mockado foi chamado uma única vez
  
</details>

---

Parabéns, agora você é capaz de configurar os constrollers em um CRUD básico usando o ASP.NET! Agora podemos entrar de cabeça nas outras camadas das APIs configuradas no .NET para eventualmente montar a aplicação de ponta a ponta! 🚀
