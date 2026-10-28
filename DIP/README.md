# DIP — Dependency Inversion Principle

## O que significa o princípio

O **Dependency Inversion Principle (DIP)** afirma que alta coesão e baixo acoplamento são
alcançados ao invés de depender diretamente de implementações concretas, mas sim de
abstrações (interfaces).

## Problema na implementação de `Violacao`

A classe `PaymentService` (alto nível) instanciava diretamente a classe concreta
`PayPalGateway`, criando acoplamento com uma implementação específica.

## Por que o código original viola o princípio

Qualquer troca de gateway (por exemplo, para Stripe) exigiria alterar a classe
`PaymentService`.

## Alterações na pasta `Solucao`

Foi criada a interface `IPaymentGateway` e a classe `PaymentService` passou a receber a
implementação via construtor (injeção de dependência). As implementações `PayPalGateway` e
`StripeGateway` podem ser trocadas sem alterar a lógica principal.

## Como a refatoração resolve o princípio

A dependência passa a ser do contrato, não da implementação, permitindo substituições.

## Benefícios

- Facilita testes (mockar o gateway).
- Permite troca de implementação sem alterar a lógica de negócio.

## Como executar

```bash
dotnet run --project DIP\Violacao\SOLID.DIP.Violacao
dotnet run --project DIP\Solucao\SOLID.DIP.Solucao
```
