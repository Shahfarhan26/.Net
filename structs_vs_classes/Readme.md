# C# Structs vs Classes

Both `struct` and `class` allow us to create custom types, but they behave differently.

## Main Difference

The most important difference is:

```text
struct → value type
class  → reference type
```

## Struct

```csharp
struct Student
{
    public string Name;
}
```

When a struct is assigned to another variable, its value is copied.

```csharp
Student s1 = new Student();
s1.Name = "Farhan";

Student s2 = s1;
```

`s1` and `s2` contain separate copies.

---

## Class

```csharp
class Student
{
    public string Name;
}
```

When a class object is assigned to another variable, both variables refer to the same object.

```csharp
Student s1 = new Student();
s1.Name = "Farhan";

Student s2 = s1;

s2.Name = "Ahmed";
```

Now:

```csharp
Console.WriteLine(s1.Name);
```

will also print:

```text
Ahmed
```

because `s1` and `s2` refer to the same object.

## Comparison

| Feature                  | Struct                              | Class                |
| ------------------------ | ----------------------------------- | -------------------- |
| Type                     | Value type                          | Reference type       |
| Assignment               | Copies value                        | Copies reference     |
| Inheritance              | Cannot inherit from classes/structs | Supports inheritance |
| Can implement interfaces | Yes                                 | Yes                  |
| Can contain methods      | Yes                                 | Yes                  |
| Can contain properties   | Yes                                 | Yes                  |
| Suitable for             | Small value-like data               | More complex objects |

## Example

### Struct

```csharp
struct Point
{
    public int X;
    public int Y;
}
```

### Class

```csharp
class Person
{
    public string Name;
    public int Age;
}
```

A `Point` can naturally represent a small value, while a `Person` is generally better represented as a class.

## Key Takeaway

Remember:

```text
Struct → value
Class  → reference
```

This difference affects how assignment and modifications behave.
