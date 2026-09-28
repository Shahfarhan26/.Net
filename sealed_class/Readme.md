# C# Sealed Class

## What is a Sealed Class?

A `sealed` class is a class that **cannot be inherited**.

Example:

```csharp
sealed class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}
```

Trying to inherit from it is not allowed:

```csharp
class Car : Vehicle
{
}
```

This produces a compilation error because `Vehicle` is sealed.

## Syntax

```csharp
sealed class ClassName
{
}
```

## Why Use a Sealed Class?

A sealed class can be used when we want to prevent further inheritance.

For example:

```csharp
sealed class SecuritySystem
{
}
```

We may want this class to be used directly without allowing another class to derive from it.

## Sealed Method

The `sealed` keyword can also be used with an overridden method.

Example:

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public sealed override void Speak()
    {
        Console.WriteLine("Dog sound");
    }
}
```

Another class cannot override `Speak()` again:

```csharp
class Puppy : Dog
{
    // Cannot override Speak()
}
```

## Important Difference

```text
sealed class
    ↓
Prevents inheritance of the class

sealed override method
    ↓
Prevents further overriding of that method
```

## Key Takeaway

> `sealed` is used when further inheritance or overriding needs to be prevented.
