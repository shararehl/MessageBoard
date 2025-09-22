# MessageBoard Console Application
A console-based C# application simulating a **project message board** where users can post updates, read project timelines, follow projects, and view their personalized wall.
---

## Features

- **Posting**: Users post messages to specific projects.
- **Reading**: View all messages posted to a project.
- **Following**: Users follow projects to receive updates.
- **Wall**: Aggregated view of messages from followed projects.

---

## Architecture

Built using **Clean Architecture** principles:

- **Domain Layer**: Core entities (`User`, `Project`, `Message`)
- **Application Layer**: CQRS commands/queries, MediatR handlers, DTOs, Validators
- **Infrastructure Layer**: In-memory repositories
- **API Layer**: Console interface

### 🛠️ Technologies Used

- .NET 9
- MediatR
- FluentValidation
- [AutoMapper]

---

## Example Command

Alice -> @Moonshot I'm working on the login screen
Bob -> @Moonshot I'll start on the password reset
Bob -> @Apollo Has anyone thought about the next release demo?

Moonshot
Charlie follows Moonshot
Charlie wall

