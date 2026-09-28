# C# Inheritance

## What is Inheritance?

Inheritance is an OOP concept where one class can acquire members from another class.

It allows us to create a new class based on an existing class.

```text
Base Class
    ↓
Derived Class
```

## Basic Syntax

```csharp
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
```

Here:

```text
Animal → Base Class
Dog    → Derived Class
```

The `Dog` class inherits the `Eat()` method from `Animal`.

```csharp
Dog d = new Dog();

d.Eat();
d.Bark();
```

Output:

```text
Animal is eating
Dog is barking
```

## Why Use Inheritance?

Inheritance allows us to:

* Reuse code
* Avoid unnecessary duplication
* Create relationships between classes
* Extend existing functionality
* Implement polymorphism

## Important Syntax

The colon `:` is used for inheritance.

```csharp
class Dog : Animal
{
}
```

This means:

> Dog inherits from Animal.

## Example

```csharp
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}
```

The `Car` class can use both:

```csharp
Start();
Drive();
```

## Key Takeaway

> Inheritance allows a derived class to reuse and extend functionality from a base class.
