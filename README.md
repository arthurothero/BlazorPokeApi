# BlazorPokeApi

Aplicação Blazor WebAssembly (.NET 10) que busca Pokémon na [PokeAPI](https://pokeapi.co/).

Digite o nome de um Pokémon, clique em **Buscar Pokémon** ou aperte Enter, e a página mostra os dados
retornados pelo endpoint `https://pokeapi.co/api/v2/pokemon/{nome}`:

- **Imagem**: campo `sprites.other.official-artwork.front_default`
- **ID**
- **Nome**
- **Altura**: a API devolve em decímetros; a página converte para metros (ex.: `0,4 m`)
- **Peso**: a API devolve em hectogramas; a página converte para quilos (ex.: `6 kg`)

Se o Pokémon não existir, a API responde 404 e a página mostra "Pokémon não encontrado".

## Como executar

Requer o [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet run
```

Depois é só abrir o endereço que aparece no terminal (por padrão `http://localhost:5266`).

## Estrutura

- `Models/Pokemon.cs`: classes que mapeiam o JSON da API
- `Pages/Home.razor`: formulário de busca, chamada à API e exibição dos dados
- `Program.cs`: registro do `HttpClient` com o endereço base da PokeAPI

## Licença

[MIT](LICENSE)
