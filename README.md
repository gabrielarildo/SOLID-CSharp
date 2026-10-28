# SOLID

Projeto educacional em **C#/.NET** que demonstra, na prática, os cinco princípios do
Design Orientado a Objetos conhecidos por **SOLID**:

- **SRP** — Single Responsibility Principle (Princípio da Responsabilidade Única)
- **OCP** — Open/Closed Principle (Princípio Aberto/Fechado)
- **LSP** — Liskov Substitution Principle (Princípio da Substituição de Liskov)
- **ISP** — Interface Segregation Principle (Princípio da Segregação de Interfaces)
- **DIP** — Dependency Inversion Principle (Princípio da Inversão de Dependência)

O objetivo do repositório é servir como material didático e como parte do portfólio
de desenvolvimento Back-End, mostrando com exemplos de código funcionais — e não apenas
teóricos — como identificar problemas de design, como eles se manifestam e como a
refatoração corrige cada caso.

## Objetivo do projeto

Este projeto foi desenvolvido para fins educacionais. Cada princípio tem sua pasta
com dois diretórios:

- `Violacao/` — código que demonstra o problema de design do princípio.
- `Solucao/` — código refatorado que aplica o princípio corretamente.

Dentro de cada pasta, o README do princípio explica o que foi feito, por que o
código original viola o princípio e como a refatoração resolve o problema.

## Resumo dos princípios

| Princípio | Nome | Ideia central |
|---|---|---|
| **SRP** | Single Responsibility Principle | Uma classe deve ter apenas uma responsabilidade. |
| **OCP** | Open/Closed Principle | Entidades devem estar abertas para extensão, mas fechadas para modificação. |
| **LSP** | Liskov Substitution Principle | Subtipos devem ser substituíveis pelos tipos base sem quebrar o comportamento. |
| **ISP** | Interface Segregation Principle | Interfaces devem ser pequenas e focadas, não amplas. |
| **DIP** | Dependency Inversion Principle | Alto nível não deve depender de baixo nível; ambos devem depender de abstrações. |

## Tabela comparativa

| Princípio | Objetivo | Exemplo desenvolvido | Erro demonstrado |
|---|---|---|---|
| **SRP** | Isolar cada responsabilidade em uma classe específica. | `OrderService` com cálculo, persistência e relatório. | Classe com múltiplas responsabilidades. |
| **OCP** | Permitir extensão sem alterar código existente. | `OrderProcessor` com `switch` sobre método de pagamento. | `switch` que exige alteração a cada novo comportamento. |
| **LSP** | Permitir substituição de tipos sem quebrar contratos. | Hierarquia `Bird`/`Penguin` com `Fly()` que lança exceção. | Subtipo que não cumpre o contrato da base. |
| **ISP** | Interfaces pequenas e coesas. | Interface `IWorker` com trabalho, comida e sono. | Interface fatia obrigando implementações irrelevantes. |
| **DIP** | Dependência de abstrações, não de implementações. | `PaymentService` com `PayPalGateway` concreto. | Serviço de alto nível acoplado à implementação. |

## Estrutura de pastas

```text
SOLID/
├── README.md
├── .gitignore
├── SOLID.sln
│
├── SRP/
│   ├── README.md
│   ├── Violacao/
│   │   └── SOLID.SRP.Violacao/
│   └── Solucao/
│       └── SOLID.SRP.Solucao/
│
├── OCP/
│   ├── README.md
│   ├── Violacao/
│   │   └── SOLID.OCP.Violacao/
│   └── Solucao/
│       └── SOLID.OCP.Solucao/
│
├── LSP/
│   ├── README.md
│   ├── Violacao/
│   │   └── SOLID.LSP.Violacao/
│   └── Solucao/
│       └── SOLID.LSP.Solucao/
│
├── ISP/
│   ├── README.md
│   ├── Violacao/
│   │   └── SOLID.ISP.Violacao/
│   └── Solucao/
│       └── SOLID.ISP.Solucao/
│
└── DIP/
    ├── README.md
    ├── Violacao/
    │   └── SOLID.DIP.Violacao/
    └── Solucao/
        └── SOLID.DIP.Solucao/
```

## Tecnologias utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET (net10.0)
- **Ferramentas:** SDK do .NET 10, CLI do `dotnet`, Visual Studio (opcional)

## Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download/dotnet/10.0) instalado.
- Nenhuma dependência externa de pacote é utilizada nos exemplos.

## Como executar

### 1. Clonar o repositório

```bash
git clone <URL_DO_REPOSITORIO>
cd SOLID
```

### 2. Compilar a solution

```bash
dotnet build SOLID.sln
```

### 3. Executar os exemplos

Cada exemplo é um projeto independente de console application. Para executar:

```bash
dotnet run --project SRP\Violacao\SOLID.SRP.Violacao
dotnet run --project SRP\Solucao\SOLID.SRP.Solucao
dotnet run --project OCP\Violacao\SOLID.OCP.Violacao
dotnet run --project OCP\Solucao\SOLID.OCP.Solucao
dotnet run --project LSP\Violacao\SOLID.LSP.Violacao
dotnet run --project LSP\Solucao\SOLID.LSP.Solucao
dotnet run --project ISP\Violacao\SOLID.ISP.Violacao
dotnet run --project ISP\Solucao\SOLID.ISP.Solucao
dotnet run --project DIP\Violacao\SOLID.DIP.Violacao
dotnet run --project DIP\Solucao\SOLID.DIP.Solucao
```

> Nos exemplos de violação, alguns comportamentos propositalmente quebram (por exemplo,
> exceções lançadas) para demonstrar o problema. Nos exemplos de solução, o comportamento
> correto é exibido.

## Conclusão

Os princípios SOLID são fundamentais para o desenvolvimento de software orientado a
objetos, especialmente em Back-End, onde sistemas crescem em complexidade e exigem
manutenção, testes e evolução contínua. Aplicá-los de forma prática melhora a qualidade,
reduz o acoplamento, facilita testes unitários e permite que o sistema cresça com novas
regras sem risco de regressões.
