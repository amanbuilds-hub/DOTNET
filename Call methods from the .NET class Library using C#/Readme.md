# Understanding Methods in the .NET Class Library

![C#](https://img.shields.io/badge/Language-C%23-purple)
![.NET](https://img.shields.io/badge/Framework-.NET-blue)
![Status](https://img.shields.io/badge/Learning-Completed-success)

---

# Overview

This project demonstrates how to use **methods from the .NET Class Library** in a C# application.  
The goal was to understand how developers can call built-in methods to perform common programming tasks such as generating random numbers, performing mathematical operations, and handling program logic.

Instead of writing all functionality from scratch, developers can rely on the **.NET Class Library**, which provides thousands of reusable classes and methods.

---

# What is the .NET Class Library?

The **.NET Class Library** is a collection of reusable classes, interfaces, and methods provided by the .NET framework.

It allows developers to perform common tasks such as:

- Mathematical calculations
- String manipulation
- File handling
- Random number generation
- Date and time operations
- Networking
- Data collections

These libraries significantly reduce development time and help developers build reliable and scalable applications.

---

# Types of Methods Used

During this exercise, different types of methods from the .NET Class Library were used.

## 1. Methods that Return Values

Some methods perform a task and **return a value**.

Example:

```csharp
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
```

Explanation:

- `Next()` generates a random number.
- The generated number is returned and stored in the variable `roll`.

---

## 2. Methods that Accept Parameters

Some methods require **input parameters**.

Example:

```csharp
int result = Math.Max(10, 20);
Console.WriteLine(result);
```

Explanation:

- `Math.Max()` accepts two numbers as parameters.
- It returns the larger number.

---

## 3. Methods that Maintain State

Certain methods maintain internal state using objects.

Example:

```csharp
Random random = new Random();
int number1 = random.Next(1, 10);
int number2 = random.Next(1, 10);
```

Explanation:

- The `Random` object keeps track of its internal state.
- Each call produces a different random value.

---

# Tools Used

The following tools were used while working with the .NET Class Library.

## Visual Studio Code

Visual Studio Code was used as the development environment for writing and executing C# programs.

Key features used:

- IntelliSense
- Syntax highlighting
- Integrated terminal
- Extension support

---

## IntelliSense

IntelliSense helps developers by:

- Suggesting available methods
- Displaying parameter information
- Providing documentation hints

Example suggestion:

```
Math.Max(int val1, int val2)
```

This helps developers quickly understand how a method works.

---

## Microsoft Learn

Documentation from **Microsoft Learn** was used to understand:

- Method definitions
- Parameter requirements
- Return types
- Usage examples

Official documentation provides detailed explanations for every class and method available in the .NET Class Library.

---

# Example Program

Below is a simple program that demonstrates using multiple methods from the .NET Class Library.

```csharp
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int diceRoll = random.Next(1, 7);
        Console.WriteLine("Dice Roll: " + diceRoll);

        int maxNumber = Math.Max(15, 25);
        Console.WriteLine("Maximum Number: " + maxNumber);

        double squareRoot = Math.Sqrt(64);
        Console.WriteLine("Square Root: " + squareRoot);
    }
}
```

Output example:

```
Dice Roll: 4
Maximum Number: 25
Square Root: 8
```

---

# Why the .NET Class Library is Important

Without the .NET Class Library, developers would need to implement every feature manually.

For example:

- Random number generators
- Mathematical functions
- File operations
- Data structures

Creating these features from scratch would require significant effort and time.

The .NET Class Library provides **prebuilt and optimized solutions**, allowing developers to focus on solving real-world problems rather than rebuilding common utilities.

---

# Benefits of Using the .NET Class Library

- Reduces development time
- Provides reliable and tested implementations
- Improves code readability
- Encourages reusable code
- Simplifies complex tasks

Because of these benefits, thousands of companies rely on applications built on top of the .NET ecosystem.

---

# Key Learning Outcomes

By completing this exercise, the following concepts were understood:

- How to call methods from the .NET Class Library
- The difference between methods that return values and those that accept parameters
- How objects maintain state
- How IntelliSense helps discover and understand methods
- How documentation supports learning and development

Understanding how to use the .NET Class Library is an important step toward becoming a professional software developer.

---

# Conclusion

The .NET Class Library is one of the most powerful tools available to developers in the .NET ecosystem.  
It provides a massive collection of prebuilt functionality that simplifies software development and accelerates application building.

By learning how to use these libraries effectively, developers can build robust and scalable applications while focusing on solving real-world problems.

This exercise provided a practical introduction to using methods from the .NET Class Library and demonstrated how they are used in everyday C# development.