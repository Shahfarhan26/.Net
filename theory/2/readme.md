# Abstract Classes and Methods in C#

## 📌 What is an Abstract Class?

An **abstract class** is a class that is designed to be used as a **base class**.

It cannot be instantiated directly.

An abstract class can contain:

* Abstract methods
* Normal methods
* Fields
* Properties
* Constructors
* Other members

It is declared using the `abstract` keyword.

```csharp
abstract class Animal
{
}
```

You **cannot** do this:

```csharp
Animal animal = new Animal();
```

because `Animal` is abstract.

---

## 🔹 Why Use an Abstract Class?

An abstract class is useful when you want to define a **common structure or behavior** for derived classes while leaving some behavior for the derived classes to implement.

For example, every animal can make a sound, but different animals make different sounds.

```csharp
abstract class Animal
{
    public abstract void MakeSound();
}
```

Now `Dog` and `Cat` can provide their own implementations.

---

# 🔹 Abstract Methods

An **abstract method** is a method that has **no implementation** in the abstract class.

It is declared using the `abstract` keyword.

```csharp
abstract class Animal
{
    public abstract void MakeSound();
}
```

Notice that there is **no method body**:

```csharp
public abstract void MakeSound();
```

There is no `{ }`.

The derived class must provide the implementation.

---

## 🔹 Implementing an Abstract Method

```csharp
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
```

The `override` keyword is required.

Similarly:

```csharp
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}
```

---

# 🔹 Complete Example

```csharp
abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound();
        cat.MakeSound();
    }
}
```

Output:

```text
Dog barks
Cat meows
```

Here:

```csharp
Animal dog = new Dog();
```

means:

* Reference type → `Animal`
* Actual object → `Dog`

The abstract method is implemented by `Dog`, so:

```csharp
dog.MakeSound();
```

calls:

```csharp
Dog.MakeSound()
```

---

# 🔹 Abstract Class Can Have Normal Methods

An abstract class does **not** mean every method must be abstract.

It can contain normal methods as well.

```csharp
abstract class Animal
{
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
```

A derived class only needs to implement the abstract members.

```csharp
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
```

Now:

```csharp
Dog dog = new Dog();

dog.MakeSound();
dog.Eat();
```

Output:

```text
Dog barks
Animal is eating
```

---

# 🔹 Abstract Class Can Have Fields and Properties

An abstract class can contain fields:

```csharp
abstract class Animal
{
    protected string name;

    public abstract void MakeSound();
}
```

It can also contain properties:

```csharp
abstract class Animal
{
    public string Name { get; set; }

    public abstract void MakeSound();
}
```

Derived classes inherit these members.

---

# 🔹 Abstract Class Can Have Constructors

An abstract class can have a constructor.

```csharp
abstract class Animal
{
    public string Name;

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();
}
```

The derived class can call the base constructor:

```csharp
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} barks");
    }
}
```

Usage:

```csharp
Dog dog = new Dog("Bruno");

dog.MakeSound();
```

Output:

```text
Bruno barks
```

Even though we cannot create an `Animal` object directly, its constructor can still execute when a derived object is created.

---

# 🔹 Abstract Class Cannot Be Instantiated

This is invalid:

```csharp
abstract class Animal
{
}

Animal animal = new Animal();
```

You will get an error because an abstract class cannot be directly instantiated.

But this is valid:

```csharp
Animal animal = new Dog();
```

provided `Dog` is a concrete derived class.

---

# 🔹 Derived Class Must Implement Abstract Methods

Suppose:

```csharp
abstract class Animal
{
    public abstract void MakeSound();
    public abstract void Move();
}
```

A normal derived class must implement **both**:

```csharp
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public override void Move()
    {
        Console.WriteLine("Dog runs");
    }
}
```

If `Dog` doesn't implement all abstract members, the compiler will give an error.

---

# 🔹 Abstract Derived Classes

A derived class can also be abstract.

```csharp
abstract class Animal
{
    public abstract void MakeSound();
}

abstract class Mammal : Animal
{
}
```

`Mammal` does not have to implement `MakeSound()` because it is also abstract.

A further concrete class must implement it:

```csharp
class Dog : Mammal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

---

# 🔹 Abstract vs Virtual

This is an important difference.

### Virtual Method

A virtual method has a default implementation.

```csharp
public virtual void MakeSound()
{
    Console.WriteLine("Some sound");
}
```

The derived class **can** override it.

### Abstract Method

An abstract method has no implementation.

```csharp
public abstract void MakeSound();
```

The derived class **must** implement it unless the derived class is also abstract.

### Remember:

```text
virtual  → implementation provided → overriding is optional

abstract → no implementation        → overriding is required
```

---

# 🔹 Abstract Class vs Normal Class

| Feature                      | Normal Class | Abstract Class |
| ---------------------------- | ------------ | -------------- |
| Can create object directly   | ✅ Yes        | ❌ No           |
| Can contain normal methods   | ✅ Yes        | ✅ Yes          |
| Can contain abstract methods | ❌ No         | ✅ Yes          |
| Can have fields              | ✅ Yes        | ✅ Yes          |
| Can have properties          | ✅ Yes        | ✅ Yes          |
| Can have constructors        | ✅ Yes        | ✅ Yes          |
| Can be inherited             | ✅ Yes        | ✅ Yes          |

---

# 🔹 Abstract Class vs Interface

Both can be used to define contracts, but they are different concepts.

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

It can contain **state and implemented behavior**.

### Interface

```csharp
interface IAnimal
{
    void MakeSound();
}
```

An interface primarily defines a **contract** that implementing types agree to follow.

---

# 🔹 Real-World Example

Consider different payment methods.

Every payment method should have a `Pay()` operation, but the implementation is different.

```csharp
abstract class Payment
{
    public abstract void Pay(double amount);
}
```

Credit card:

```csharp
class CreditCard : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card");
    }
}
```

UPI:

```csharp
class UPI : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI");
    }
}
```

Now:

```csharp
Payment payment1 = new CreditCard();
Payment payment2 = new UPI();

payment1.Pay(1000);
payment2.Pay(500);
```

Output:

```text
Paid ₹1000 using Credit Card
Paid ₹500 using UPI
```

The common requirement is defined in the abstract class:

```csharp
Pay()
```

while each derived class decides **how** the operation works.

---

# 🧠 Key Concepts Learned

* `abstract` keyword
* Abstract classes
* Abstract methods
* Cannot instantiate abstract classes
* Abstract methods have no implementation
* Derived classes use `override`
* Abstract classes can contain normal methods
* Abstract classes can contain fields and properties
* Abstract classes can have constructors
* Derived classes must implement abstract members
* Abstract derived classes
* Difference between `abstract` and `virtual`
* Abstract classes and runtime polymorphism
* Abstract class vs interface

---

# 🔑 Remember This

The basic pattern is:

```csharp
abstract class Parent
{
    public abstract void Method();
}

class Child : Parent
{
    public override void Method()
    {
        // Implementation
    }
}
```

Think of it like this:

```text
Abstract Class
      ↓
Defines WHAT must exist
      ↓
Derived Class
      ↓
Defines HOW it works
```

The most important rule:

```text
abstract method
      ↓
no implementation in base class
      ↓
derived class must override it
```
