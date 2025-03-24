# RestConnection API

## Descrição

Esta API foi desenvolvida para realizar requisições REST utilizando a **BrasilAPI** e **ViaCEP** para buscar informações de bancos e endereços.

A arquitetura segue o padrão **3 camadas**, utilizando **Repository Pattern** e **AutoMapper** para melhor organização do código.

## Tecnologias Utilizadas

- **ASP.NET Core 6**
- **AutoMapper** (Mapeamento de objetos)
- **Repository Pattern** (Separando camada de dados)
- **BrasilAPI** (Consulta de bancos)
- **ViaCEP** (Consulta de endereços por CEP)
- **Newtonsoft.Json** (Serialização JSON)

---

## Documentação das APIs utilizadas

- [BrasilAPI](https://brasilapi.com.br/docs)
- [ViaCEP](https://viacep.com.br/)

---

## Estrutura do Projeto

```
```

- **Controllers/**: Camada de apresentação que expõe os endpoints.
- **DTOs/**: Objetos de transferência de dados.
- **Interfaces/**: Definição de contratos para serviços e repositórios.
- **Models/**: Modelos de dados utilizados na aplicação.
- **Repositories/**: Implementação do Repository Pattern para acesso a dados.
- **Services/**: Camada de serviços para lógica de negócio.
- **Mapping/**: Configuração do AutoMapper.

---

## Endpoints

### BancoController

#### Buscar informações de um banco Via Brasil API

```
GET /api/v1/Banco/BuscarBanco/{codigoBanco}
```

- **Parâmetro:** `codigoBanco` (string) - Código do banco a ser pesquisado.
- **Resposta:**
  - **200 OK**: Retorna os dados do banco.
  - **400 Bad Request**: Erro na requisição.
  - **404 Not Found**: Banco não encontrado.
  - **500 Internal Server Error**: Erro interno do servidor.

#### Buscar lista de bancos

```
GET /api/v1/Banco/BuscarBancos
```

- **Resposta:**
  - **200 OK**: Retorna a lista de bancos.
  - **500 Internal Server Error**: Erro interno do servidor.

---

### EnderecoController

#### Buscar endereço pelo CEP Via Brasil API

```
GET /api/v1/Endereco/{cep}
```

- **Parâmetro:** `cep` (string) - CEP a ser consultado.
- **Resposta:**
  - **200 OK**: Retorna os dados do endereço.
  - **400 Bad Request**: Erro na requisição.
  - **404 Not Found**: CEP não encontrado.
  - **500 Internal Server Error**: Erro interno do servidor.

---

### HomeController

#### Buscar endereço pelo CEP via API ViaCEP

```
GET /api/v1/Home/{cep}
```

- **Parâmetro:** `cep` (string) - CEP a ser consultado.
- **Resposta:**
  - **200 OK**: Retorna os dados do endereço.
  - **400 Bad Request**: Erro na requisição.

---

## Como Executar o Projeto

1. Clone o repositório:

   ```sh
   git clone https://github.com/seu-usuario/RestConnection.git
   ```

2. Navegue até o diretório do projeto:

   ```sh
   cd RestConnection
   ```

3. Instale as dependências:

   ```sh
   dotnet restore
   ```

4. Execute o projeto:

   ```sh
   dotnet run
   ```

5. Acesse a API via **Swagger** em:

   ```
   https://localhost:5001/swagger/index.html
   ```

