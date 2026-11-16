# Relearning C#

> 🇧🇷 [Português](#o-que-você-encontrará-neste-repositório) · 🇺🇸 [English](#what-will-you-find-in-this-repository)

## O que você encontrará neste repositório?

Material teórico para consulta.

Construído durante um intensivo de quatro horas e meia da [freeCodeCamp](https://www.youtube.com/watch?v=GhQdlIFylQ8),
entre **maio e julho de 2021**.

O objetivo é reaprender o básico da minha primeira linguagem de programação, aprendida em 2017 durante o ensino médio.
Feito isso, os estudos da Unity serão mais fáceis (veja o [random-baller](https://github.com/tofolo17/random-baller)).

### Estrutura

Uma solução (`Relearning CSharp.sln`) com um projeto de console por aula, numerados de `_00` a `_22`: variáveis, tipos,
strings, números, entrada do usuário, calculadoras, arrays (inclusive 2D), métodos, `if`/`switch`, laços, tratamento
de exceções e orientação a objetos (classes, construtores, getters/setters, membros estáticos e herança).

### Ferramentas

- C#
- .NET 5 (os projetos usam `net5.0`)
- JetBrains Rider

### Como usar

```bash
git clone https://github.com/tofolo17/relearning-csharp.git
cd relearning-csharp
dotnet run --project "_10 A Better Calculator"
```

Também dá para abrir a `.sln` no Rider ou no Visual Studio. O .NET 5 já não tem suporte: se só houver um SDK mais novo
instalado, troque `net5.0` por `net8.0` no `.csproj` da aula que for rodar.

### Licença

[MIT](LICENSE)

---

## What will you find in this repository?

Theoretical material for consultation.

Built during a four-and-a-half hour intensive course at [freeCodeCamp](https://www.youtube.com/watch?v=GhQdlIFylQ8),
between **May and July 2021**.

The goal is to relearn the basics of my first programming language, learned in 2017 during high school. That done,
Unity's studies will be easier (see [random-baller](https://github.com/tofolo17/random-baller)).

### Structure

One solution (`Relearning CSharp.sln`) with one console project per lesson, numbered `_00` to `_22`: variables, types,
strings, numbers, user input, calculators, arrays (including 2D), methods, `if`/`switch`, loops, exception handling and
object orientation (classes, constructors, getters/setters, static members and inheritance).

### Tools

- C#
- .NET 5 (the projects target `net5.0`)
- JetBrains Rider

### How to use

```bash
git clone https://github.com/tofolo17/relearning-csharp.git
cd relearning-csharp
dotnet run --project "_10 A Better Calculator"
```

You can also open the `.sln` in Rider or Visual Studio. .NET 5 is out of support: if you only have a newer SDK
installed, change `net5.0` to `net8.0` in the `.csproj` of the lesson you want to run.

### License

[MIT](LICENSE)
