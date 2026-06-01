# Bank_System

Lightweight .NET banking system scaffold focused on project structure only.

## Current framework

- `src/BankSystem.Api` - ASP.NET Core entry point
- `src/BankSystem.Domain` - Core domain models and business rules
- `src/BankSystem.Application` - Use cases and application services
- `src/BankSystem.Infrastructure` - Data access and external integrations

## Solution

- `BankSystem.slnx`

## Build

From the repository root:

```powershell
dotnet build BankSystem.slnx
```

## Initial decisions

- Runtime: Modern .NET (`net10.0`)
- Architecture style: Modular monolith (single deployable API, clean internal modules)
- Primary database target: PostgreSQL (confirmed)
- Security: Deferred for now
- Scope: Framework-only scaffold (no heavy business logic yet)

## Database recommendation

Recommended default: PostgreSQL (selected).

Why:

- Free and open-source with strong production reliability
- Excellent EF Core support and cross-platform behavior
- Easy to run locally and in cloud environments

If you expect tight Microsoft ecosystem integration (Azure SQL features, Windows-first administration, or existing SQL Server tooling), SQL Server is also a strong option.