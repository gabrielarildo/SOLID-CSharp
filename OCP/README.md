# OCP — Open/Closed Principle

## O que significa o princípio

O **Open/Closed Principle (OCP)** (Princípio Aberto/Fechado) afirma que software deve estar
aberto para **extensão**, mas fechado para **modificação**.

## Problema na implementação de `Violacao`

A classe `OrderProcessor` recembe o método de pagamento como `enum` e usava um `switch`
para decidir o comportamento. Para adicionar um novo método de pagamento, seria necessário
editar a própria classe `OrderProcessor`.

## Por que o código original viola o princípio

Cada novo comportamento exigia uma alteração no código central, o que violava o OCP e
tornava o sistema frágil (alterações em produção podem quebrar regras existentes).

## Alterações na pasta `Solucao`

Foi criada a interface `IPaymentProcessor` com a implementação de cada método de pagamento
(`CreditCardPaymentProcessor`, `PayPalPaymentProcessor`, `CashPaymentProcessor` e
`BitcoinPaymentProcessor`). O `OrderProcessor` passou a depender da interface e delegar o
processamento.

## Como a refatoração resolve o princípio

Com o polimorfismo via interface, novos comportamentos podem ser adicionados criando novas
implementações, sem tocar no `OrderProcessor`.

## Benefícios

- Extensibilidade sem risco de regressão.
- Centralização das regras de pagamento.

## Como executar

```bash
dotnet run --project OCP\Violacao\SOLID.OCP.Violacao
dotnet run --project OCP\Solucao\SOLID.OCP.Solucao
```
