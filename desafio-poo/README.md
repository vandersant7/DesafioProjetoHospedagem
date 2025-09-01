# Desafio POO - DIO .NET

## Contexto
Este projeto é parte da trilha .NET da DIO, módulo de Programação Orientada a Objetos (POO).  
O objetivo do desafio foi modelar um sistema que trabalha com celulares, utilizando abstração, herança e polimorfismo.  

Foram criadas classes para diferentes marcas de smartphones (`Nokia` e `Iphone`), a partir de uma classe abstrata `Smartphone`. Cada classe filha implementa sua própria forma de instalar aplicativos.

---

## Diagrama de Classes (Mermaid)

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

---

## Trecho de Código

### Classe Abstrata `Smartphone`

```csharp
public abstract class Smartphone
{
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string Imei { get; set; }
    private int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nome);
}
```

### Classe `Nokia` (herda `Smartphone`)

```csharp
public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no Nokia");
    }
}
```

### Classe `Iphone` (herda `Smartphone`)

```csharp
public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no Iphone");
    }
}
```

### Uso no `Program.cs`

```csharp
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Nokia", "123456", 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("789456123", "Iphone", "456789456", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
```

---

## Como Executar

1. Clone este repositório.
2. Abra em um editor como Visual Studio ou VS Code.
3. Compile e execute o projeto.
4. Observe a saída no console, demonstrando o polimorfismo e as operações dos smartphones.
