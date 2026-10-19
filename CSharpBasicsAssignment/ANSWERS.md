# Assignment Answers

## G1. Project File (.csproj)

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

## G2. Does `#region` and `#endregion` Affect the Compiled Output?

No. `#region` and `#endregion` are used to organize code in the editor.
They do not affect the compiled output.

## G3. When Should You Use `///` Instead of `//`

Use `///` for XML documentation comments to describe classes, methods, 
and their paramenters or return vlaues.
Use `//` for regular comments that explain code.

## G4. Why Are There No True Globl Variables in C#?

C# does not support global variables directly.
The closest alternatives are fields declared insid a class or static fields that
can be accessed through the class