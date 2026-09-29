# Polymorphism in C#

## 📌 What is Polymorphism?

**Polymorphism** means **"many forms"**.

In C#, polymorphism allows the same method or object reference to behave differently depending on the actual object involved.

It is one of the fundamental concepts of Object-Oriented Programming (OOP), along with:

* Encapsulation
* Inheritance
* Abstraction

---

## 🔹 Types of Polymorphism

There are two commonly discussed forms of polymorphism in C#:

### 1. Compile-Time Polymorphism

Compile-time polymorphism is mainly achieved through **method overloading**.

The same method name can have different parameters.

```csharp
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}
```

The compiler determines which method to call based on the arguments.

```csharp
Calculator c = new Calculator();

Console.WriteLine(c.Add(10, 20));
Console.WriteLine(c.Add(10, 20, 30));
Console.WriteLine(c.Add(10.5, 20.5));
```

---

## 🔹 2. Run-Time Polymorphism

Run-time polymorphism is achieved through **inheritance** and methods that can be overridden.

The base class defines a method using `virtual`, and the derived class changes its behavior using `override`.

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
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
Dog barks
Cat meows
```

Even though `a1` and `a2` are declared as `Animal`, the actual objects are `Dog` and `Cat`.

The runtime therefore calls the overridden method belonging to the actual object.

---

## 🔹 `virtual`

The `virtual` keyword allows a derived class to override a method.

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}
```

A derived class can then provide its own implementation.

---

## 🔹 `override`

The `override` keyword is used in the derived class to provide a new implementation of a virtual or abstract member.

```csharp
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

The base member must be `virtual`, `abstract`, or already be an overridden member that can continue the virtual chain.

---

## 🔹 Base Class Reference to Derived Object

One of the most important parts of runtime polymorphism is:

```csharp
Animal animal = new Dog();
```

Here:

* `Animal` → compile-time/reference type
* `Dog` → runtime/object type

The reference is of type `Animal`, but the actual object is a `Dog`.

Therefore:

```csharp
animal.MakeSound();
```

calls:

```text
Dog's MakeSound()
```

when `MakeSound()` is virtual and overridden.

---

## 🔹 Polymorphism with Collections

Polymorphism becomes particularly useful when working with collections.

```csharp
List<Animal> animals = new List<Animal>
{
    new Dog(),
    new Cat()
};

foreach (Animal animal in animals)
{
    animal.MakeSound();
}
```

Output:

```text
Dog barks
Cat meows
```

The list can contain different derived classes because both `Dog` and `Cat` are `Animal`.

This allows code to work with different objects through a common base type.

---

## 🔹 `base` with Polymorphism

An overridden method can also call the original base-class implementation using `base`.

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

`base.MakeSound()` explicitly calls the implementation from the base class.

---

## 🔹 `new` vs `override`

These two are different.

### `override`

Changes the behavior of a virtual base member.

```csharp
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

The runtime type determines which implementation runs.

### `new`

Hides the base member instead of overriding it.

```csharp
class Dog : Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

With `new`, the method called depends on the **reference/compile-time type**, not normal virtual dispatch.

---

## 🔹 Abstract Classes and Polymorphism

An abstract method can force derived classes to provide their own implementation.

```csharp
abstract class Animal
{
    public abstract void MakeSound();
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

The derived classes **must** implement the abstract method.

---

## 🔹 Why Polymorphism is Useful

Polymorphism allows us to write flexible code.

Instead of writing:

```csharp
Dog dog = new Dog();
Cat cat = new Cat();

dog.MakeSound();
cat.MakeSound();
```

we can work with the common base type:

```csharp
List<Animal> animals =
[
    new Dog(),
    new Cat()
];

foreach (Animal animal in animals)
{
    animal.MakeSound();
}
```

Now new animal types can be added without changing the basic loop.

---

## 🧠 Key Concepts Learned

* Polymorphism means **many forms**
* Compile-time polymorphism
* Method overloading
* Run-time polymorphism
* Method overriding
* `virtual`
* `override`
* `abstract`
* Base-class references
* Derived-class objects
* Runtime method dispatch
* `base`
* Difference between `new` and `override`
* Polymorphism with collections
* Interface-based polymorphism

---

## 🔑 Important Example

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

class Program
{
    static void Main()
    {
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.MakeSound();
        animal2.MakeSound();
    }
}
```

Output:

```text
Bark
Meow
```

### Main idea:

```text
Base Reference
      ↓
Animal animal = new Dog();
      ↓
Runtime checks actual object
      ↓
Dog.MakeSound()
```

---

## 📚 Summary

Polymorphism allows different classes to be treated through a common type while still providing their own behavior.

The most important runtime-polymorphism pattern to remember is:

```csharp
BaseType reference = new DerivedType();
```

combined with:

```csharp
virtual
override
```

This is one of the main mechanisms that makes inheritance useful in real-world C# applications.
