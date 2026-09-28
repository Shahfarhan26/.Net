# C# Base and Derived Classes

## Base Class

A **base class** is the class whose members are inherited by another class.

Example:

```csharp
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}
```

Here, `Animal` is the base class.

## Derived Class

A **derived class** is a class that inherits from another class.

```csharp
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking");
    }
}
```

Here:

```text
Animal → Base Class
Dog    → Derived Class
```

## Using the Derived Class

```csharp
Dog d = new Dog();

d.Eat();
d.Bark();
```

The derived class can access inherited members that are accessible to it.

## The `base` Keyword

The `base` keyword is used to access members of the base class.

Example:

```csharp
class Animal
{
    public string Name = "Animal";
}

class Dog : Animal
{
    public void Show()
    {
        Console.WriteLine(base.Name);
    }
}
```

Here:

```csharp
base.Name
```

refers to the member defined in the base class.

## Calling a Base Constructor

The `base` keyword can also be used to call a base-class constructor.

```csharp
class Animal
{
    public Animal(string name)
    {
        Console.WriteLine(name);
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
}
```

The constructor of `Animal` is called when a `Dog` object is created.

## Relationship

```text
        Animal
       /      \
     Dog      Cat
```

`Animal` is the base class.

`Dog` and `Cat` are derived classes.

## Key Takeaway

```text
Base Class    → provides common functionality
Derived Class → inherits and can extend that functionality
base keyword  → accesses the base-class implementation
```
