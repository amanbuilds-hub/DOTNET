# Module: Convert Data Types Using Casting and Conversion Techniques in C#

---

## 🎯 Learning Objectives

By the end of this module, you will be able to:

- Understand C# data types
- Perform implicit and explicit type casting
- Use conversion techniques like Convert, Parse, and TryParse
- Handle errors safely during type conversion
- Apply conversions in real-world programs

---

## 📌 Introduction

In C#, every variable has a data type such as `int`, `double`, `string`, or `bool`.  
Sometimes, we need to convert data from one type to another.

This process is called **Type Conversion**.

### Example:
- Converting `int` → `double`
- Converting `string` → `int`

There are two main techniques:
1. **Casting**
2. **Conversion methods**

---

## 🔹 Understanding Data Types

### Common C# Data Types:

| Type    | Description              | Example     |
|---------|--------------------------|-------------|
| int     | Integer numbers          | 10          |
| double  | Decimal numbers          | 10.5        |
| string  | Text                     | "Hello"     |
| bool    | True/False               | true        |
| char    | Single character         | 'A'         |

---

## 🔹 Implicit Conversion (Automatic)

### ✅ Definition:
Implicit conversion is done automatically by C# when there is **no risk of data loss**.

### 🔁 Rule:
Smaller data type → Larger data type

### 📌 Example:
```csharp
int num = 100;
double result = num;

Console.WriteLine(result); // Output: 100

## 🔹 2. Explicit Conversion (Casting)

### ⚠️ Definition:
Manual conversion from a **larger data type → smaller data type**.

> ❗ Risk of data loss

### 📌 Example:
```csharp
double num = 10.99;
int result = (int)num;

Console.WriteLine(result); // Output: 10


## 🔹 3. Using Convert Class

### 📌 Description:
Provides **safe and flexible conversions**.

### 📌 Example:
```csharp
string str = "200";
int num = Convert.ToInt32(str);

Console.WriteLine(num);

## 🔹 4. Parsing Methods

### 📌 Parse()
```csharp
string str = "45";
int num = int.Parse(str);

⚠️ Issue:
Throws exception if input is invalid

## 🔹 5. TryParse (Safest Method)

```csharp
string str = "abc";
int num;

bool success = int.TryParse(str, out num);

if (success)
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Invalid input");
}

Benefits:
No crash
Safe for user input


## 🔹 6. Boxing and Unboxing

### 📦 Boxing:
# Converting **value type → object**

```csharp
int num = 10;
object obj = num;

### 📤 Unboxing:

Converting object → value type

object obj = 10;
int num = (int)obj;

⚠️ Important:
Unboxing requires explicit casting
Wrong type → runtime error