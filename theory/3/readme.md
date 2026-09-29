# Interfaces in C#

## 📌 What is an Interface?

An **interface** defines a contract that a class or struct can implement.

It specifies what members a type must provide, without requiring that type to inherit implementation from the interface.

An interface is declared using the `interface` keyword.

```csharp
interface IAnimal
{
    void MakeSound();
}
```

A class implements the interface using `:`.

```csharp
class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
```

---

# 🔹 Why Use Interfaces?

Interfaces are useful when different classes need to follow the **same contract**, even if they are otherwise unrelated.

For example:

```text
IAnimal
   ↓
 ┌───────┬───────┐
 ↓       ↓       ↓
Dog     Cat     Cow
```

All of them must provide `MakeSound()`, but each can implement it differently.

---

# 🔹 Basic Interface Example

```csharp
interface IAnimal
{
    void MakeSound();
}
```

Implement it:

```csharp
class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

Use it:

```csharp
Dog dog = new Dog();

dog.MakeSound();
```

Output:

```text
Bark
```

---

# 🔹 Interface Members

An interface can define members such as:

* Methods
* Properties
* Events
* Indexers

For example:

```csharp
interface IAnimal
{
    string Name { get; set; }

    void MakeSound();
}
```

A class implementing the interface must provide the required members.

```csharp
class Dog : IAnimal
{
    public string Name { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

---

# 🔹 Interface Reference

An interface can be used as a reference type.

```csharp
IAnimal animal = new Dog();

animal.MakeSound();
```

Here:

```text
IAnimal → reference type
Dog     → actual object
```

The call:

```csharp
animal.MakeSound();
```

executes the implementation provided by `Dog`.

This is another important use of **polymorphism**.

---

# 🔹 Multiple Interfaces

A class can implement **multiple interfaces**.

This is one of the major differences between classes and interfaces.

```csharp
interface IAnimal
{
    void MakeSound();
}

interface IMovable
{
    void Move();
}

class Dog : IAnimal, IMovable
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public void Move()
    {
        Console.WriteLine("Dog runs");
    }
}
```

Now `Dog` follows both contracts.

```csharp
Dog dog = new Dog();

dog.MakeSound();
dog.Move();
```

---

# 🔹 Interfaces and Inheritance

A class can inherit from a base class **and** implement interfaces.

```csharp
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

interface IMovable
{
    void Move();
}

class Dog : Animal, IMovable
{
    public void Move()
    {
        Console.WriteLine("Running");
    }
}
```

Here:

```text
Animal
   ↓
  Dog
```

and:

```text
IMovable
   ↓
  Dog
```

`Dog` inherits from `Animal` and implements `IMovable`.

---

# 🔹 Interface Naming Convention

The common C# naming convention is to start interface names with **`I`**.

Examples:

```text
IAnimal
IMovable
IPayable
IRepository
ILogger
IDisposable
```

This makes it immediately clear that the type is an interface.

---

# 🔹 Interface vs Abstract Class

This is an important distinction.

### Abstract Class

```csharp
abstract class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public abstract void MakeSound();
}
```

An abstract class can provide:

* State
* Fields
* Properties
* Constructors
* Implemented methods
* Abstract methods

### Interface

```csharp
interface IAnimal
{
    void MakeSound();
}
```

An interface primarily defines a contract.

---

## Comparison

| Feature                      | Abstract Class          | Interface             |
| ---------------------------- | ----------------------- | --------------------- |
| Can instantiate directly     | ❌                       | ❌                     |
| Can have abstract members    | ✅                       | ✅                     |
| Can have implemented methods | ✅                       | ✅                     |
| Can have instance fields     | ✅                       | ❌                     |
| Can have constructors        | ✅                       | ❌                     |
| Multiple can be used         | ❌ One base class        | ✅ Multiple interfaces |
| Represents                   | Common base/abstraction | Contract/capability   |

---

# 🔹 Interface as a Contract

Consider a payment system.

```csharp
interface IPayment
{
    void Pay(double amount);
}
```

Different payment methods can implement it:

```csharp
class CreditCard : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card");
    }
}
```

```csharp
class UPI : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI");
    }
}
```

Now both classes follow the same contract:

```csharp
IPayment payment1 = new CreditCard();
IPayment payment2 = new UPI();

payment1.Pay(1000);
payment2.Pay(500);
```

Output:

```text
Paid ₹1000 using Credit Card
Paid ₹500 using UPI
```

The interface doesn't care **how** payment happens.

It only establishes that an implementing type must provide:

```csharp
Pay(double amount)
```

---

# 🔹 Explicit Interface Implementation

A class can implement an interface member explicitly.

```csharp
interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    void IAnimal.MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

Now:

```csharp
Dog dog = new Dog();
```

cannot directly call:

```csharp
dog.MakeSound();
```

Instead:

```csharp
IAnimal animal = dog;

animal.MakeSound();
```

Output:

```text
Bark
```

This technique is useful when:

* Two interfaces contain members with the same name.
* You want an interface implementation to be accessible only through the interface reference.

---

# 🔹 Same Method Name in Multiple Interfaces

Suppose:

```csharp
interface IAnimal
{
    void Move();
}

interface IVehicle
{
    void Move();
}
```

A class can implement both differently:

```csharp
class Robot : IAnimal, IVehicle
{
    void IAnimal.Move()
    {
        Console.WriteLine("Robot walks");
    }

    void IVehicle.Move()
    {
        Console.WriteLine("Robot drives");
    }
}
```

Now:

```csharp
Robot robot = new Robot();

IAnimal animal = robot;
IVehicle vehicle = robot;

animal.Move();
vehicle.Move();
```

Output:

```text
Robot walks
Robot drives
```

---

# 🔹 Default Interface Methods

Modern C# allows interfaces to contain implementations for some members.

```csharp
interface IAnimal
{
    void MakeSound();

    void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
```

A class implementing the interface must implement `MakeSound()`, but it can use the default implementation of `Eat()`.

```csharp
class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

Default interface implementations are useful when evolving interfaces without immediately requiring every existing implementation to provide the new member.

---

# 🔹 Interfaces and Polymorphism

Interfaces are heavily used with polymorphism.

```csharp
interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}
```

Now:

```csharp
List<IShape> shapes =
[
    new Circle(),
    new Square()
];

foreach (IShape shape in shapes)
{
    shape.Draw();
}
```

Output:

```text
Drawing Circle
Drawing Square
```

The collection doesn't need to know the specific class.

It only needs to know that every object implements `IShape`.

---

# 🧠 Key Concepts Learned

* `interface` keyword
* Interfaces as contracts
* Implementing interfaces
* Interface references
* Interface polymorphism
* Multiple interface implementation
* Interface naming convention (`I...`)
* Interfaces with properties
* Interfaces with methods
* Explicit interface implementation
* Default interface methods
* Interface + class inheritance
* Interface vs abstract class

---

# 🔑 Remember This

The basic pattern is:

```csharp
interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

Think of an interface as:

```text
Interface
    ↓
Defines WHAT a class must provide
    ↓
Class
    ↓
Defines HOW it provides it
```

The most important difference to remember:

```text
Abstract Class
    → Common base + shared implementation/state

Interface
    → Contract/capability
```

And one major advantage:

```text
A class can inherit from only ONE class
but can implement MULTIPLE interfaces.
```
