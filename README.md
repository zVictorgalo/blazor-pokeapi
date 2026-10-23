# BlazorPokeApi

Atividade de Desenvolvimento Web: aplicação **Blazor WebAssembly em C#/.NET 8** que consulta a PokéAPI pelo nome de um Pokémon.

## Funcionalidades
- Busca pelo nome, com botão ou tecla Enter.
- Exibição da imagem oficial, ID, nome, altura em metros e peso em quilogramas.
- Mensagens para nome vazio, Pokémon inexistente, falha de conexão e tempo excedido.
- Layout responsivo e estado de carregamento.

A imagem vem exclusivamente de `sprites.other["official-artwork"].front_default`, conforme o enunciado. A API informa altura em decímetros e peso em hectogramas; ambos são divididos por 10 para apresentar metros e quilogramas.

## Executar
1. Instale o **SDK .NET 8** (https://dotnet.microsoft.com/download/dotnet/8.0). No Visual Studio 2022, use uma versão compatível com .NET 8 e a carga de trabalho ASP.NET e desenvolvimento Web.
2. Extraia o ZIP e abra um terminal dentro da pasta `blazor-pokeapi` (a pasta do `.csproj`).
3. Execute:

```sh
dotnet restore
dotnet run
```

4. Abra o endereço exibido no terminal (normalmente http://localhost:5080).

Também é possível abrir `BlazorPokeApi.csproj` no Visual Studio e executar com F5. Não abra `index.html` diretamente: o projeto precisa ser compilado e servido pelo .NET.

O navegador precisa de acesso à Internet para consultar https://pokeapi.co e carregar as imagens oficiais. A aplicação não utiliza chave de API nem banco de dados.

## Conferência manual
- Busque `ditto`: ID 132, altura 0,3 m, peso 4 kg.
- Busque `pikachu`: ID 25, altura 0,4 m, peso 6 kg.
- Busque ` PIKACHU `: espaços e letras maiúsculas são normalizados.
- Busque `pokemon-inexistente`: deve aparecer a mensagem de não encontrado.
- Envie o campo vazio: deve solicitar um nome.
- Desative a conexão e consulte novamente: deve informar falha na consulta.
- Verifique o layout em uma janela estreita.

## Organização
- `Pages/Home.razor`: formulário, resultado e estados da tela.
- `Services/PokemonService.cs`: requisição HTTP.
- `Models/Pokemon.cs`: desserialização e conversão de unidades.
- `Program.cs`: configuração do Blazor e injeção de dependências.
- `wwwroot/css/app.css`: estilos.

## Publicar no GitHub e entregar
Crie um repositório vazio chamado **blazor-pokeapi** na sua conta. Dentro da pasta do projeto:

```sh
git init
git add .
git commit -m "Implementa consulta Pokemon em Blazor WebAssembly"
git branch -M main
git remote add origin https://github.com/SEU-USUARIO/blazor-pokeapi.git
git push -u origin main
```

Substitua `SEU-USUARIO` pelo seu usuário real. Depois entregue a URL do repositório no Google Classroom. A criação do repositório e a entrega não foram realizadas automaticamente.

## Validação desta entrega
Estrutura, arquivos de configuração, mapeamento do JSON e integridade do ZIP foram revisados. O ambiente de criação não possui o SDK .NET, portanto a compilação e a consulta ao vivo devem ser conferidas localmente com os passos acima.

## Licença
MIT. Consulte `LICENSE`.
