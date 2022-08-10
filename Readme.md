# Contact Api

## Sobre o Projeto

O presente projeto tem como objetivo proporcionar uma api para criação, atualização e remoção de contatos vinculados à usuários.

A api oferece todas as funções de CRUD para usuários e seus contatos.

## Executando o projeto

Este Projeto foi densevolvido na linguagem C# utilizando o .NET Framework Core na versão `6.0.302` e o Entity Framework Core .NET Command-line Tools `6.0.5`.\
Para obter o funcionamento esperado é recomendado que se utilize esta versão. 

Foi utilizado um Banco de Dados mySql para testes em um container Docker,a configuração de conexão com o banco pode ser alterada no arquivo `appsettings.json` por padrão foi 
utilizado a credencial de root sem autenticação.

O arquivo de configuração `docker-compose.yml` pode ser usado para gerar a imagem do banco caso `docker` e `docker-compose` esteja instalado.

Para construir a estrutura e popular o banco do projeto deve-se executar o comando\
`dotnet ef database update`, este comando é utilizado para rodar as migrations do projeto.

Para executar o projeto, utilize o comando `dotnet run` no diretório raiz do mesmo ou execute o dotnet pela sua IDE.

A api vai estar executando na porta `http://localhost:7117`, os endpoints disponíveis podem ser visualizados no `Swagger` do projeto no endereço `http://localhost:7117/swagger/`.
