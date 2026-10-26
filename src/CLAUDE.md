# CLAUDE.md

## Contexto

Projeto de estudo do André para aprender **C# e .NET** a partir de experiência prévia em **Java/Spring Boot**.
Objetivo: preparar para um **teste técnico na Scania (vaga .NET, por indicação) na segunda semana de novembro de 2026**.

Sempre que possível, explique os conceitos comparando com o equivalente em Java/Spring
(ex.: `List` ≈ `ArrayList`, LINQ ≈ Streams, `[ApiController]` ≈ `@RestController`, EF Core ≈ JPA/Hibernate, NuGet ≈ Maven).

## Como trabalhar comigo (IMPORTANTE)

- **Este é um projeto de aprendizado. NÃO escreva o código das tarefas por mim.**
- Guie fase por fase, em partes pequenas e sequenciais.
- Explique o conceito, mostre um exemplo curto **fora do domínio da tarefa** se precisar, e deixe eu implementar.
- Quando eu mandar código, **revise**: aponte erros, convenções do C# e melhorias, explicando o porquê.
- Dê dicas e o "caminho" quando eu travar, sem entregar a resposta completa.
- Só escreva código completo se eu pedir explicitamente.
- Responda em português.

## Stack

- .NET 10 (LTS), C#, `Nullable` e `ImplicitUsings` ativados
- IDE: JetBrains Rider
- Solution: `CentroCirurgico.slnx` (formato novo do .NET 10)
- Projeto console em `src/CentroCirurgico`
- Semana 2: ASP.NET Core + EF Core + PostgreSQL (Docker)

## Convenções combinadas

- Um tipo (classe, record, enum) por arquivo, com o nome do arquivo igual ao do tipo.
- Pastas por responsabilidade, em PascalCase: `Models/`, `Repositories/`, `Services/` (não separar por "classes/" e "records/").
- Namespace em uma linha (file-scoped): `namespace CentroCirurgico.Models;`
- PascalCase para tipos, properties e parâmetros de record; camelCase para variáveis locais e parâmetros de método; `_camelCase` para campos privados.
- Properties públicas; controle de escrita com `set`, `init` ou `private set`.
- `required` para properties obrigatórias de tipos não-nulos.
- Identificadores que não entram em contas (CRM, CPF etc.) são `string`.
- Enums em vez de strings soltas para valores fixos.
- `record` para dados imutáveis (eventos/registros); `class` para entidades que mudam de estado.

## Projeto: Controle de Medicamentos do Centro Cirúrgico

Sistema onde anestesistas registram a administração de medicamentos em procedimentos, com controle de estoque.

### Fases

1. **Models e enums** ← fase atual
2. Repositório em memória (interfaces + `List` como "banco")
3. Service com regras de negócio (validações, exceções — ex.: estoque insuficiente)
4. Menu no console + relatórios com LINQ
5. Async e persistência em JSON

Depois (semana 2): transformar em API REST com ASP.NET Core + EF Core + PostgreSQL, reaproveitando models e regras.
Semana 3: middleware de erros, JWT, testes com xUnit, simulado cronometrado e revisão teórica.

### Fase 1 — tarefa

Em `Models/`:

- `ViaAdministracao` (enum): Oral, Intravenosa, Intramuscular, Inalatoria
- `Medicamento` (classe): `Id`, `Nome`, `DoseMgPadrao`, `Via` (enum), `QuantidadeEstoque`
- `Anestesista` (classe): `Id`, `Nome`, `Crm`, `Especialidade`
- `Administracao` (record): `Id`, `MedicamentoId`, `AnestesistaId`, `DoseMg`, `DataHora` (`DateTime`)

Perguntas para eu refletir:
- Por que `Medicamento` é classe e `Administracao` é record?
- Quais properties devem ser `required`, quais `init` e quais `set`?

## Já estudado

- Tipos, `var`, `decimal`, interpolação de string (`$"..."`, formatação `:C`, raw strings `"""`)
- Properties, `init`, `required`, object initializer
- Records (igualdade por valor, `with`)
- Namespaces e `using`
- Coleções (`List`, `Dictionary`) e LINQ básico (`Where`, `OrderBy`, `Select`, `Sum`, `Any`, `Max`, `FirstOrDefault`, `GroupBy`)
- Lambdas e method group (`ForEach(Console.WriteLine)`)
