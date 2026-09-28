# C# Partial Classes

## What is a Partial Class?

A `partial` class allows the definition of a single class to be split across multiple files.

The compiler combines all parts into one class during compilation.

## Basic Example

### File 1

```csharp
public partial class Person
{
    public string Name;
}
```

### File 2

```csharp
public partial class Person
{
    public void SayHello()
    {
        Console.WriteLine($"Hello {Name}");
    }
}
```

Although the class is written in two files, C# treats it as one class.

```csharp
Person p = new Person();

p.Name = "Farhan";
p.SayHello();
```

## Syntax

Each part must use the `partial` keyword:

```csharp
partial class Person
{
}
```

```csharp
partial class Person
{
}
```

## Why Use Partial Classes?

Partial classes are useful when:

* A class is very large.
* Different parts of a class need to be separated.
* Code is generated automatically.
* We want to separate generated code from manually written code.

## Important Point

A partial class does **not** create multiple classes.

These:

```text
Person.cs
PersonMethods.cs
```

can both contain parts of the same `Person` class.

The compiler combines them into one class.

## Key Takeaway

> `partial` allows one class to be divided into multiple source files while remaining a single class.
