# API de Adoção

API desenvolvida em .NET 8.0 para gerenciamento de adoção de animais. O projeto utiliza Entity Framework Core para interação com o banco de dados Oracle e Swashbuckle para documentação da API via Swagger.

## Tecnologias Utilizadas

- .NET 8.0
- Entity Framework Core
- Oracle Entity Framework Core
- Swashbuckle (Swagger)

## Estrutura do Projeto

A estrutura do projeto está organizada da seguinte forma:

```
API-Adocao/
├── Controllers/          # Controladores da API
│   ├── PetController.cs  # Controlador para gerenciamento de pets
├── Domain/               # Definição de entidades
│   ├── Enums/            # Enumerações utilizadas
├── Infrastructure/       # Infraestrutura do projeto
│   ├── Context/          # Contexto do banco de dados
│   ├── Mappings/         # Mapeamento das entidades
│   ├── Persistence/      # Repositório de persistência
├── Migrations/           # Arquivos de migração do Entity Framework
├── Properties/           # Configurações do projeto
├── appsettings.json      # Configurações da aplicação
├── Program.cs            # Ponto de entrada da aplicação
├── README.md             # Documentação do projeto
```

## Endpoints da API

A API expõe os seguintes endpoints:

### **PetController**

- `GET /api/Pet` - Retorna a lista de todos os pets
- `POST /api/Pet` - Adiciona um novo pet
- `GET /api/Pet/{id}` - Retorna um pet específico pelo ID
- `DELETE /api/Pet/{id}` - Remove um pet pelo ID

## Como Executar o Projeto

### **1. Clonar o repositório**
```sh
git clone https://github.com/ViniciuSaeSouza/API-C-.Net.git
cd API-C-.Net
```

### **2. Configurar o banco de dados**
Edite o `appsettings.json` para apontar para sua instância do Oracle Database.

### **3. Aplicar migrações**
```sh
dotnet ef database update
```

### **4. Executar a aplicação**
```sh
dotnet run
```

A API será iniciada e poderá ser acessada via [Swagger UI](https://localhost:7011/swagger).

## Documentação da API

A documentação interativa da API está disponível através do Swagger, permitindo testar os endpoints diretamente pelo navegador.

## Contribuição

Sinta-se à vontade para abrir issues e pull requests para melhorias no projeto.

---

Desenvolvido por ViniciuSaeSouza.

