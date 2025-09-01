# Projetos de Desafios - POO e Sistema de Hospedagem

## Tecnologias Utilizadas
- C# 12
- .NET 8
- Console Application

---

## Desafio 1: POO - Sistema de Smartphones

### Contexto
Projeto desenvolvido para a trilha .NET da DIO, com foco em Programação Orientada a Objetos (POO).  
O objetivo foi modelar um sistema de smartphones utilizando **abstração, herança e polimorfismo**.  

Foram criadas classes para diferentes marcas (`Nokia` e `Iphone`) a partir de uma classe abstrata `Smartphone`. Cada classe filha implementa sua própria forma de instalar aplicativos.

### Diagrama de Classes (Mermaid)
```mermaid
classDiagram
    class Smartphone {
        +string Numero
        -string Modelo
        -string Imei
        -int Memoria
        +Ligar()
        +ReceberLigacao()
        +InstalarAplicativo(nome : string)
    }

    class Nokia {
        +InstalarAplicativo(nome : string)
    }

    class Iphone {
        +InstalarAplicativo(nome : string)
    }

    Smartphone <|-- Nokia
    Smartphone <|-- Iphone
````

### Trecho de Código

```csharp
Smartphone nokia = new Nokia("123456", "Nokia", "123456", 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("789456123", "Iphone", "456789456", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
```

---

## Desafio 2: Sistema de Hospedagem

### Contexto

Desenvolvimento de um sistema em C# para gerenciamento de reservas de hospedagem.
O sistema deve validar hóspedes e suites, separando dados válidos de inválidos, utilizando **listas, validações e tratamento de exceções**.

### Lógica do Sistema

* Entrada: lista de nomes de hóspedes separados por vírgula.
* Validações:

  * Nome vazio ou em branco → `"Erro: nome invalido"`
  * Nome nulo → `"Erro: nome nulo"`
* Saída: nomes válidos separados por vírgula. Se houver erros, exibir `/` seguido das mensagens de erro.

### Trecho de Código

```csharp
var validNames = new List<string>();
var errors = new List<string>();

foreach (var name in names)
{
    if (name.Trim().ToLowerInvariant() == "null")
        errors.Add("Erro: nome nulo");
    else if (string.IsNullOrWhiteSpace(name))
        errors.Add("Erro: nome invalido");
    else
        validNames.Add(name);
}

if (errors.Any())
    Console.WriteLine(validNames.Any() ? 
        $"{string.Join(", ", validNames)} / {string.Join(", ", errors)}" :
        $"/ {string.Join(", ", errors)}");
else
    Console.WriteLine(string.Join(", ", validNames));
```

---

## Observações

* Ambos os projetos foram desenvolvidos como **aplicações de console em C# .NET 8**.
* Aplicam conceitos fundamentais de **POO**, **validação de dados** e **tratamento de exceções**.
* As saídas dos programas foram testadas para garantir conformidade com os requisitos dos desafios.
