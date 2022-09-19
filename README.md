
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


