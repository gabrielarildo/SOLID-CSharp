# SRP — Single Responsibility Principle

## O que significa o princípio

O **Single Responsibility Principle (SRP)** afirma que uma classe deve ter, no máximo, uma
única responsabilidade. Em outras palavras: uma classe deve ter uma única razão para mudar.

## Problema na implementação de `Violacao`

No exemplo de violação, a classe `OrderService` concentra três responsabilidades:

1. Calcular o total de um pedido.
2. Salvar o pedido (simulação de persistência em banco de dados).
3. Gerar o relatório do pedido.

## Por que o código original viola o princípio

Quando a responsabilidade se mistura, qualquer alteração em uma área (como mudar a
formatação do relatório) pode impactar as demais (como o cálculo ou a persistência), e a
classe fica grande, difícil de entender e de testar.

## Alterações na pasta `Solucao`

Foi criada uma classe para cada responsabilidade:

- `OrderCalculator` — calcula o total.
- `OrderRepository` — salva o pedido.
- `OrderReportGenerator` — gera o relatório.

## Como a refatoração resolve o problema

Com as classes separadas, cada uma tem uma responsabilidade única, o que:

- facilita a manutenção (alterar cálculo não exige conhecer persistência);
- reduz o acoplamento (as classes dependem apenas do que precisam);
- melhora a testabilidade (cada parte pode ser testada isoladamente).

## Benefícios

- Código mais legível e organizado.
- Alterações pontuais e com menor risco de regressão.
- Facilita a reutilização de componentes.

## Como executar

```bash
dotnet run --project SRP\Violacao\SOLID.SRP.Violacao
dotnet run --project SRP\Solucao\SOLID.SRP.Solucao
```
