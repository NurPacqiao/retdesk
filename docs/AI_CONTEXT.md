# Project Context: RetDesk (Multi-Tenant SaaS)

## 1. Project Overview & Goal

I am building **RetDesk**, a multi-tenant field-service management SaaS. This is a portfolio project designed to bridge the gap from "intern" to "engineer who can design and ship a multi-tenant SaaS end-to-end."
The focus is on strict multi-tenant data isolation, clean architecture, and eventually AI-augmented features.

## 2. My Profile & Learning Style

- **Current Skills:** ASP.NET Core, EF Core, React, TypeScript, Zustand, Vitest, Docker, Nx (from previous internship).
- **Learning Rhythm:** I follow a strict **Study → Explain → Build → Break → Fix → Document** cycle.
- **AI Instructions:**
  - Do not just give me code to copy-paste.
  - After every logical chunk of work (ending in a Git commit), provide a **"Checkpoint & Self-Check"** section.
  - This section must include: Core Concepts, Self-Check Questions, and a Break/Fix Challenge.
  - I need to be able to explain the "why" behind the code for interviews.

## 3. Tech Stack & Architecture

- **Backend:** .NET 10 (ASP.NET Core Web API), EF Core 10, PostgreSQL 16 (via Docker).
- **Architecture:** Monolith with Clean Boundaries. Projects:
  - `RetDesk.Api` (Host)
  - `RetDesk.Domain` (Entities, logic)
  - `RetDesk.Infrastructure` (EF Core, external services)
  - `RetDesk.Application` (DTOs, services)
- **Database Strategy:** Shared-database, shared-schema multi-tenancy. Every tenant-specific entity will have a `CompanyId`. Will use EF Core Global Query Filters for isolation.
- **Frontend (Future):** React, TS, Vite (not started yet).

## 4. Project Rules & Anti-Patterns

- **Do not** touch pgvector/embeddings/AI yet (Week 5).
- **Do not** touch SignalR, Redis, or background workers yet (Week 4).
- **Do not** let optional infrastructure block the MVP.
- **Do not** use microservices or complex CQRS. Keep it a well-organized monolith.
- **Git Workflow:** Feature branches (e.g., `feat/domain-modeling`). Commit often.

## 5. Current Progress (As of [Insert Date])

- **Environment Setup:** Complete. `docker-compose.yml` is running PostgreSQL 16 (healthcheck active).
- **Git:** `.gitignore` is active (untracked `bin/obj`). Main branch is stable. Currently on branch `feat/domain-modeling`.
- **API Connection:** Complete. `AppDbContext` is wired up to PostgreSQL via `UseNpgsql`. Swagger is running and confirmed working.
- **Domain Modeling (Partial):** Created `BaseEntity`, `Company`, `User`, `WorkOrder`. Generated the `InitialCreate` migration and applied it to the database.

## 6. Immediate Next Steps (What we are doing right now)

1. Create the remaining 7 entities in `RetDesk.Domain.Entities` (Customer, Location, Project, Task, Comment, ActivityLog, KnowledgeDocument).
2. Implement EF Core Global Query Filters in `AppDbContext` for tenant isolation (using `CompanyId`).
3. Set up `IEntityTypeConfiguration<T>` classes to configure unique indexes (e.g., `CompanyId` + `Email`).
4. Create a "Break/Fix" challenge around cross-tenant data leakage.
5. Generate a new migration for these changes.

## 7. Useful Commands for this Project

- Start DB: `docker compose up -d`
- Check DB health: `docker compose ps`
- Run API: `dotnet run --project src/RetDesk.Api`
- Add Migration: `dotnet ef migrations add <Name> -p src/RetDesk.Infrastructure -s src/RetDesk.Api`
- Update DB: `dotnet ef database update -p src/RetDesk.Infrastructure -s src/RetDesk.Api`
