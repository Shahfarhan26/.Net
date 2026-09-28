# C# Protected Access Modifier

## What is `protected`?

The `protected` access modifier allows a member to be accessed:

* Inside the class where it is declared.
* Inside classes derived from that class.

Example:

```csharp
class Animal
{
    protected string Name = "Animal";
}

class Dog : Animal
{
    public void ShowName()
    {
        Console.WriteLine(Name);
    }
}
```

`Dog` can access `Name` because `Dog` derives from `Animal`.

## Protected vs Private

### Private

```csharp
class Animal
{
    private string Name;
}
```

The member can only be accessed inside `Animal`.

A derived class cannot directly access it.

### Protected

```csharp
class Animal
{
    protected string Name;
}
```

The member can be accessed inside `Animal` and its derived classes.

## Example

```csharp
class Person
{
    protected int Age;
}

class Student : Person
{
    public void ShowAge()
    {
        Console.WriteLine(Age);
    }
}
```

Here `Age` is not directly accessible from outside:

```csharp
Student s = new Student();

// s.Age; ❌
```

But it can be accessed inside the derived class:

```csharp
class Student : Person
{
    public void ShowAge()
    {
        Console.WriteLine(Age);
    }
}
```

## Access Overview

| Modifier    | Same Class | Derived Class | Outside |
| ----------- | ---------: | ------------: | ------: |
| `private`   |          ✅ |             ❌ |       ❌ |
| `protected` |          ✅ |             ✅ |       ❌ |
| `public`    |          ✅ |             ✅ |       ✅ |

## Why Use Protected?

`protected` is useful when a base class needs to expose certain implementation details to its derived classes without making them publicly accessible to everyone.

## Key Takeaway

> `protected` means the member is accessible within the declaring class and its derived classes, but not directly from unrelated external code.
