# To learn in this module :


### Add packages to your .NET project
.NET comes with many core libraries that handle everything from managing files to HTTP to compressing files. There's also a huge ecosystem of third-party libraries. You can use NuGet, the .NET package manager, to install these libraries and use them in your application.

### Evaluate a package
Before you install a library, you might want to inspect the dependencies on which it relies. These dependencies might encourage you to use the package, or they might deter you. Here are some factors to consider when you select a dependency for your project:

**Size**: The number of dependencies might create a large footprint. If you're on a limited bandwidth or have other hardware limitations, this factor might be a concern.
**Licensing**: You need to ensure that the license granted for the library covers your intended use, whether that use is commercial, personal, or academic.
**Active maintenance**: It might be a problem if your package relies on a dependency that isn't actively maintained. The dependency could be deprecated or not updated for a long time.

**To ensure that you can use a package, all dependencies are crawled and downloaded when you run the dotnet add package <package name> command.**


### Install a package
There are several ways to install packages. There's a built-in command line and graphical user interface for a package manager in Visual Studio and Visual Studio for Mac. You can manually add package references to your project file, or you can install them through a command-line interface (CLI) tool such as **Paket** or the **.NET Core CLI**.

A typical installation command looks like this:**dotnet add package <name of package>**. When you run the add package command, the command-line tool connects to a global registry, fetches the package, and stores it in a cached folder location that all projects can use.

### Find a package
Individual developers might use the global registry at NuGet.org to find and download packages that they need for their apps.

### After Installation
The installed packages are listed in the **dependencies** section of your **.csproj** file. If you want to see what packages are in the folder, you can enter **dotnet list package**.

*dotnet list package* : This command lists only the top-level packages, and not dependencies of those packages that we call transitive packages. 

#### .NET CLI
**dotnet list package --include-transitive**

Including transitives allows you to see dependencies along with all the packages you installed. If you run dotnet list package --include-transitive, you might get this output:

### Restrore Dependencies
When you create or clone a project, the included dependencies aren't downloaded or installed until you build your project. You can manually restore dependencies, and project-specific tools that are specified in the project file, by running the **dotnet restore** command. In most cases, you don't need to explicitly use the command. NuGet restore runs implicitly, if necessary, when you run commands like **new, build,** and **run**.


### Clean up dependencies
To remove a package from your project, use the **remove** command, like so: **dotnet remove package <name of dependency>**. This command removes the package from your project's **.csproj** file.


### Manage Dependency updates 
## Upgrade app Dependencies
- In the DotNetDependencies.csproj file, look at the dependencies. It should look like this code:

XML
<ItemGroup>
    <PackageReference Include="Humanizer" Version="2.7.9" />
</ItemGroup>

- To see installed dependencies, run this command:

.NET CLI
**dotnet list package**

The command should output the requested version and the final resolved (installed) version.

Output
Top-level Package      Requested   Resolved
> Humanizer            2.7.9        2.7.9

- To see what dependencies are outdated, run this command:

.NET CLI
**dotnet list package --outdated**

The output should look something like the following output. You might get different values in the Latest column.

Output
Project `DotNetDependencies` has the following updates to its packages
   [net8.0]:
   Top-level Package      Requested   Resolved   Latest
   > Humanizer            2.7.9       2.7.9      2.11.10

- By default, this command checks for the latest stable version. To check for prerelease packages, append --include-prerelease to the previous command:

.NET CLI
**dotnet list package --outdated --include-prerelease**

- You can, with some level of confidence, update to the Latest version. Doing so ensures the dependencies get the latest features and patches in that major version. To install the latest version, run the following command:

.NET CLI
**dotnet add package Humanizer**

If you want to upgrade to a specific version of the dependency, you can append the --version parameter and specify the specific version.

.NET CLI
**dotnet add package Humanizer --version 2.11.10**

Lastly, you can also install the latest prerelease package by appending the --prerelease parameter.

.NET CLI
**dotnet add package Humanizer --prerelease**

