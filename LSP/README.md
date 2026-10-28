# LSP — Liskov Substitution Principle

## O que significa o princípio

O **Liskov Substitution Principle (LSP)** afirma que objetos de uma subclasse devem ser
substituíveis pelos objetos da classe base sem alterar o funcionamento correto do programa.

## Problema na implementação de `Violacao`

A classe abstrata `Bird` declarava o método abstrato `Fly()`. A classe `Penguin` sobrescrevia
`Fly()` lançando uma exceção, pois o pinguim não voa.

## Por que o código original viola o princípio

Qualquer código que recebesse uma instância de `Bird` e esperasse que voasse passaria a
recebender um pinguim e falhava. O contrato da classe base não era respeitado pela subclase.

## Alterações na pasta `Solucao`

Foi criada a interface `IFlyable` para encapsular o comportamento de voar. A classe
`Sparrow` passa a implementá-la, enquanto `Penguin` não a implementa e expõe seu próprio
comportamento (`Swim`).

## Como a refatoração resolve o princípio

O contrato fica correto: quem voa implementa a interface; quem não voa simplesmente não o
faz. A substituição de tipos ocorre de forma segura.

## Benefícios

- Comportamento consistente entre subclasses e base.
- Redução de validações e exceções inesperadas no runtime.

## Como executar

```bash
dotnet run --project LSP\Violacao\SOLID.LSP.Violacao
dotnet run --project LSP\Solucao\SOLID.LSP.Solucao
```
