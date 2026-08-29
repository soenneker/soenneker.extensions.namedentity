[![](https://img.shields.io/nuget/v/soenneker.extensions.namedentity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.namedentity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.namedentity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.namedentity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.namedentity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.namedentity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.namedentity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.namedentity/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.NamedEntity
Projects one `INamedEntity` into a lightweight `IdNamePair`.

## Installation

```bash
dotnet add package Soenneker.Extensions.NamedEntity
```

## Usage

```csharp
using Soenneker.Extensions.NamedEntity;

INamedEntity entity = GetEntity();
IdNamePair pair = entity.ToIdNamePair();

// pair.Id == entity.Id
// pair.Name == entity.Name
```

`ToIdNamePair()` creates a new object containing the current `Id` and `Name`; it does not retain a reference to the entity. The source must be non-null.
