# Decision Statements in C#

![Language](https://img.shields.io/badge/Language-C%23-purple)
![Framework](https://img.shields.io/badge/Framework-.NET-blue)
![Concept](https://img.shields.io/badge/Topic-Branching%20Logic-green)

---

# Overview

In this module, the main objective was to learn how to add **branching logic** to a C# program using **decision statements**.

Decision statements allow a program to **choose different execution paths** depending on conditions. This capability is essential for building dynamic and intelligent applications.

Using decision statements, a program can:

- Evaluate conditions
- Execute specific blocks of code
- Skip unnecessary instructions
- Control program flow

Without these constructs, software applications would not be able to automate complex tasks required in modern systems.

---

# What is Branching Logic?

Branching logic allows a program to **make decisions** based on conditions.

In programming, this is done by evaluating **Boolean expressions** that return either:

```
true
false
```

Depending on the result, the program executes different sections of code.

Example:

```
If condition is true → execute block A  
If condition is false → execute block B
```

---

# Decision Statements in C#

C# provides several decision-making constructs.

The most common ones are:

- `if`
- `else if`
- `else`

These statements allow developers to build complex decision-making logic.

---

# The `if` Statement

The `if` statement executes a block of code **only when a condition is true**.

### Syntax

```csharp
if (condition)
{
    // code to execute if condition is true
}
```

### Example

```csharp
int score = 80;

if (score > 50)
{
    Console.WriteLine("You passed the exam.");
}
```

### Explanation

If the condition `score > 50` is **true**, the message will be displayed.

---

# The `if-else` Statement

The `if-else` statement allows a program to execute one block if the condition is true, and another block if it is false.

### Syntax

```csharp
if (condition)
{
    // code when condition is true
}
else
{
    // code when condition is false
}
```

### Example

```csharp
int age = 16;

if (age >= 18)
{
    Console.WriteLine("You can vote.");
}
else
{
    Console.WriteLine("You cannot vote yet.");
}
```

---

# The `else if` Statement

The `else if` statement allows evaluation of **multiple conditions**.

### Syntax

```csharp
if (condition1)
{
    // code block 1
}
else if (condition2)
{
    // code block 2
}
else
{
    // default block
}
```

### Example

```csharp
int marks = 75;

if (marks >= 90)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 70)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 50)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Fail");
}
```

---

# Boolean Expressions

Decision statements rely on **Boolean expressions**.

A Boolean expression always evaluates to:

```
true
false
```

Examples:

```
x > 10
age >= 18
score == 100
temperature < 30
```

These expressions determine which block of code will execute.

---

# Why Decision Statements Are Important

Decision statements are essential for building real-world applications.

They enable programs to perform tasks such as:

- Business rule evaluation
- Game logic
- Input validation
- Scientific calculations
- Automated system responses

Without decision statements, programs would execute code sequentially without any intelligence or adaptability.

---

# Real-World Applications

Decision statements are used in many types of software systems.

### Business Applications
- Determining discounts
- Validating transactions
- Processing payments

### Gaming Applications
- Player health checks
- Level progression
- Enemy behavior logic

### Scientific Applications
- Data analysis
- Experiment conditions
- Simulation decisions

---

# Key Learning Outcomes

From this module, the following concepts were learned:

- Understanding **branching logic**
- Using **if statements** to evaluate conditions
- Implementing **if-else structures**
- Handling multiple conditions using **else if**
- Writing **Boolean expressions**
- Controlling program execution flow

These concepts form the foundation of decision-making in programming.

---

# Conclusion

Decision statements are one of the most fundamental constructs in programming. By using `if`, `else if`, and `else`, developers can create programs that react dynamically to different conditions.

These techniques will be used in **nearly every application**, from small utilities to large enterprise systems.

Mastering decision statements is a crucial step toward becoming a skilled software developer.