# ISP — Interface Segregation Principle

## O que significa o princípio

O **Interface Segregation Principle (ISP)** (Princípio da Segregação de Interfaces) afirma que
não deve obrigar uma classe a implementar métodos que ela não utiliza.

## Problema na implementação de `Violacao`

A interface `IWorker` declarava três métodos: `Work()`, `Eat()` e `Sleep()`. A classe
`RobotWorker` era obrigada a implementar `Eat()` e `Sleep()`, mesmo não fazendo sentido para
robôs.

## Por que o código original viola o princípio

A interface era "fat" demais, forçando implementações com métodos irrelevantes, o que
gera código ruim (métodos que lançam exceções) e polui o design.

## Alterações na pasta `Solucao`

A interface foi dividida:

- `IWorker` — com `Work()`.
- `IPerson` — com `Eat()` e `Sleep()`.

Agora o `HumanWorker` implementa as duas interfaces e o `RobotWorker` implementa apenas
`IWorker`.

## Como a refatoração resolve o princípio

Cada classe implementa apenas os contratos necessários, sem métodos desnecessários.

## Benefícios

- Interfaces coesas e focadas.
- Redução de código ruim e de dependências desnecessárias.

## Como executar

```bash
dotnet run --project ISP\Violacao\SOLID.ISP.Violacao
dotnet run --project ISP\Solucao\SOLID.ISP.Solucao
```
