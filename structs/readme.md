# C# Structs

## What is a Struct?

A `struct` is a **value type** in C# that is used to group related data and behavior together.

Structs are commonly used for small objects that represent a single value or simple collection of values.

### Basic Syntax

```csharp
struct Person
{
    public string Name;
    public int Age;
}
```

Using the struct:

```csharp
Person p1;

p1.Name = "Farhan";
p1.Age = 22;

Console.WriteLine(p1.Name);
Console.WriteLine(p1.Age);
```

## Important Characteristics

* A struct is a **value type**.
* Structs are copied by value.
* A struct can contain:

  * Fields
  * Properties
  * Methods
  * Constructors
  * Events
* A struct cannot inherit from another class or struct.
* Every struct implicitly derives from `System.ValueType`.
* Structs can implement interfaces.

## Value-Type Behavior

When one struct is assigned to another, a copy is created.

```csharp
Person p1 = new Person();
p1.Age = 22;

Person p2 = p1;

p2.Age = 25;
```

Here:

```text
p1.Age = 22
p2.Age = 25
```

Changing `p2` does not change `p1` because they contain separate values.

## When to Use Structs

Structs are generally useful when:

* The object represents a small value.
* The object does not need inheritance.
* The object is relatively small.
* Value-type semantics are desirable.

Examples include concepts such as:

```text
Point
Coordinate
Color
Date/Time-related values
```

## Key Takeaway

> A struct is a value type used to represent small, self-contained data structures.

---

## Practice

Create a struct called `Student` containing:

* `Name`
* `Age`
* `RollNumber`

Create an object of the struct and print its values.
