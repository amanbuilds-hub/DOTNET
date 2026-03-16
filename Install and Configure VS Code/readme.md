# C# Development Setup using Visual Studio Code

# Overview

This guide explains **how to install and configure C# development environment using Visual Studio Code** on Linux (Arch Linux).

The setup includes:

- Installing .NET SDK
- Installing Visual Studio Code
- Installing required VS Code extensions
- Creating and running a C# project

---

# Step 1 — Update the System
if are using **Arch Linux** 
Before installing any packages, update your system.

```bash
sudo pacman -Syu
```

---

# Step 2 — Install .NET SDK

Install the .NET SDK required to compile and run C# applications.

```bash
sudo pacman -S dotnet-sdk
```

Verify installation:

```bash
dotnet --version
```

If installed correctly, it will display the installed .NET version.

---

# Step 3 — Install Visual Studio Code

Install the official Microsoft Visual Studio Code editor.

```bash
yay -S visual-studio-code-bin
```

Verify installation:

```bash
code --version
```

Launch VS Code:

```bash
code
```

---

# Step 4 — Install C# Extensions in VS Code

Open the **Extensions Panel**.

Shortcut:

```
Ctrl + Shift + X
```

Install the following extensions:

### 1. C# Dev Kit
Provides tools for building, debugging, and managing .NET projects.

### 2. C#
Provides language support including IntelliSense and debugging.

### 3. NuGet Gallery
Allows browsing and installing NuGet packages directly inside VS Code.

---

# Step 5 — Create a New C# Project

Open terminal in VS Code or system terminal and run:

```bash
dotnet new console -o MyFirstApp
```

This command creates a **new C# console application**.

Navigate into the project directory:

```bash
cd MyFirstApp
```

---

# Step 6 — Open Project in VS Code

Open the project folder in Visual Studio Code.

```bash
code .
```

VS Code will automatically detect the **.NET project configuration**.

---

# Step 7 — Run the C# Application

Run the application using the .NET CLI.

```bash
dotnet run
```

Output:

```
Hello, World!
```

---

# Step 8 — Build the Project

To compile the project into executable binaries:

```bash
dotnet build
```

Compiled files will be generated in:

```
bin/Debug/
```

---

# Step 9 — Debug the Application

To debug the application:

1. Open the **Run and Debug** panel.
2. Click **Run and Debug**.
3. Select **.NET Core Launch** configuration.

You can now place **breakpoints** and debug the application.

---

# Useful .NET CLI Commands

| Command | Description |
|-------|-------------|
| `dotnet new` | Create new project |
| `dotnet run` | Build and run application |
| `dotnet build` | Compile project |
| `dotnet restore` | Restore project dependencies |
| `dotnet clean` | Clean build artifacts |

---

# Conclusion

After completing these steps, you will have a fully functional **C# development environment using Visual Studio Code and .NET SDK**.

You can now:

- create C# applications
- build .NET projects
- debug code inside VS Code
- manage packages using NuGet

This setup is suitable for **console applications, web APIs, and enterprise .NET development**.