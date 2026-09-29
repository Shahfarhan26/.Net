# Virtual Methods in C#

## 📌 What is a Virtual Method?

A **virtual method** is a method in a base class that can be **overridden by a derived class**.

It is used to achieve **runtime polymorphism**.

The `virtual` keyword tells C#:

> "Derived classes are allowed to provide their own implementation of this method."

---

## 🔹 Basic Syntax

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
```

A derived class can override it:

```csharp
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
```

---

## 🔹 Using a Virtual Method

```csharp
Animal animal = new Dog();

animal.MakeSound();
```

Output:

```text
Dog barks
```

Even though the reference is of type `Animal`, the actual object is a `Dog`.

Because `MakeSound()` is virtual, C# uses the **runtime type of the object** to determine which implementation to execute.

---

## 🔹 `virtual` and `override`

These keywords work together.

### Base Class

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}
```

### Derived Class

```csharp
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

* `virtual` → allows overriding
* `override` → provides the new implementation

---

## 🔹 Without `virtual`

Consider:

```csharp
class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

Now:

```csharp
Animal animal = new Dog();

animal.MakeSound();
```

The base implementation is used because `MakeSound()` was not declared as virtual.

---

## 🔹 With `virtual`

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

Now:

```csharp
Animal animal = new Dog();

animal.MakeSound();
```

Output:

```text
Bark
```

This is **runtime polymorphism**.

---

## 🔹 Calling the Base Version with `base`

An overridden method can still call the original base implementation.

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Dog barks");
    }
}
```

Output:

```text
Animal sound
Dog barks
```

Here:

```csharp
base.MakeSound();
```

calls the implementation from `Animal`.

---

## 🔹 Virtual Methods with Multiple Derived Classes

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
```

Now:

```csharp
Animal a1 = new Dog();
Animal a2 = new Cat();

a1.MakeSound();
a2.MakeSound();
```

Output:

```text
Bark
Meow
```

The same method call:

```csharp
MakeSound();
```

produces different behavior depending on the actual object.

---

## 🔹 Important Rule

A method can only be overridden if the base method is declared as one of the following:

```csharp
virtual
abstract
override
```

For example:

```csharp
public virtual void Display()
{
}
```

can be overridden with:

```csharp
public override void Display()
{
}
```

---

## 🔹 Virtual Method vs Abstract Method

### Virtual

A virtual method **has an implementation** in the base class.

```csharp
public virtual void Display()
{
    Console.WriteLine("Default display");
}
```

Derived classes **may** override it.

### Abstract

An abstract method **does not have an implementation**.

```csharp
public abstract void Display();
```

Derived non-abstract classes **must** override it.

---

## 🔹 Virtual Method vs `new`

### `override`

```csharp
public override void Display()
```

Participates in runtime polymorphism.

### `new`

```csharp
public new void Display()
```

Hides the base method instead of overriding it.

This is an important difference:

```text
override → replaces/extends virtual behavior
new      → hides the base member
```

---

## 🧠 Key Concepts Learned

* `virtual` keyword
* `override` keyword
* Runtime polymorphism
* Base-class references
* Derived-class objects
* Runtime method dispatch
* `base` keyword
* Difference between `virtual` and non-virtual methods
* Difference between `override` and `new`
* Virtual vs abstract methods

---

## 🔑 Remember This

The most important pattern is:

```csharp
class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent");
    }
}

class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("Child");
    }
}

Parent obj = new Child();

obj.Show();
```

Output:

```text
Child
```

### The key idea:

```text
Parent reference
      ↓
new Child()
      ↓
virtual method
      ↓
override
      ↓
Child.Show()
```

`virtual` is what allows the derived class's overridden method to be selected at **runtime**.
