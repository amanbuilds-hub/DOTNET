# 🧵 Modifying Strings Using Built-in Methods in C#

## 📌 Introduction

In C#, strings are **immutable**, which means once a string is created, it cannot be changed. However, we can **modify strings** by using built-in methods that return a **new modified string**.

This README covers all important string modification methods in C# with examples.

---

## 🔑 Key Concept: Immutability of Strings

* Strings in C# are **read-only**
* Any modification creates a **new string object**
* Original string remains unchanged

```csharp
string name = "Orion";
name.ToUpper();

Console.WriteLine(name); // Output: Orion (unchanged)
```

---

## 🛠️ Common String Modification Methods

### 1. 🔠 ToUpper() and ToLower()

Convert string to uppercase or lowercase.

```csharp
string text = "hello world";

Console.WriteLine(text.ToUpper()); // HELLO WORLD
Console.WriteLine(text.ToLower()); // hello world
```

---

### 2. ✂️ Trim(), TrimStart(), TrimEnd()

Remove whitespace from strings.

```csharp
string text = "   Hello   ";

Console.WriteLine(text.Trim());      // "Hello"
Console.WriteLine(text.TrimStart()); // "Hello   "
Console.WriteLine(text.TrimEnd());   // "   Hello"
```

---

### 3. 🔄 Replace()

Replace characters or substrings.

```csharp
string text = "I like Java";

string result = text.Replace("Java", "C#");

Console.WriteLine(result); // I like C#
```

---

### 4. 🧩 Substring()

Extract part of a string.

```csharp
string text = "Programming";

Console.WriteLine(text.Substring(0, 6)); // Progra
Console.WriteLine(text.Substring(3));    // gramming
```

---

### 5. ➕ Concatenation (Concat & + operator)

Combine strings.

```csharp
string first = "Hello";
string second = "World";

Console.WriteLine(first + " " + second); // Hello World
Console.WriteLine(string.Concat(first, " ", second)); // Hello World
```

---

### 6. 🔍 Contains(), StartsWith(), EndsWith()

Check string content.

```csharp
string text = "CSharp Programming";

Console.WriteLine(text.Contains("Sharp")); // true
Console.WriteLine(text.StartsWith("C"));   // true
Console.WriteLine(text.EndsWith("ing"));   // true
```

---

### 7. 🪓 Remove()

Remove part of a string.

```csharp
string text = "HelloWorld";

Console.WriteLine(text.Remove(5)); // Hello
```

---

### 8. 🔤 Insert()

Insert text at a specific position.

```csharp
string text = "HelloWorld";

Console.WriteLine(text.Insert(5, " ")); // Hello World
```

---

### 9. 🔗 Split()

Split string into array.

```csharp
string text = "apple,banana,mango";

string[] fruits = text.Split(',');

foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

---

### 10. 🔁 Join()

Join array into string.

```csharp
string[] words = { "C#", "is", "awesome" };

string result = string.Join(" ", words);

Console.WriteLine(result); // C# is awesome
```

---

## ⚡ Best Practice: Use StringBuilder for Heavy Modifications

Since strings are immutable, frequent modifications can impact performance.

Use **StringBuilder** for better efficiency.

```csharp
using System.Text;

StringBuilder sb = new StringBuilder("Hello");

sb.Append(" World");
sb.Replace("World", "C#");

Console.WriteLine(sb.ToString()); // Hello C#
```

---

## 📊 Summary

| Method      | Purpose                   |
| ----------- | ------------------------- |
| ToUpper()   | Convert to uppercase      |
| ToLower()   | Convert to lowercase      |
| Trim()      | Remove spaces             |
| Replace()   | Replace text              |
| Substring() | Extract part              |
| Concat()    | Combine strings           |
| Remove()    | Delete part               |
| Insert()    | Add text                  |
| Split()     | Break into array          |
| Join()      | Combine array into string |

---

## 🚀 Conclusion

* Strings in C# are **immutable**
* Use built-in methods to create modified copies
* Prefer **StringBuilder** for performance-heavy operations

---

## 💡 Tip

> Always remember:
> **"String modification in C# = Creating a new string"**

---

## 📂 Folder Structure Example

```
StringMethods/
│── Program.cs
│── README.md
```

---

## 🧑‍💻 Author

**Aman Kumar Verma (Orion)**
Passionate Developer 🚀

---
