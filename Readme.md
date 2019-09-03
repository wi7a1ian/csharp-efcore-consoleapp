1. Create project
1. Create initial `DbContext` 'n models
1. Create `DbContextFactory` that uses anything else than InMemory db
1. `cd` to that project folder and run `dotnet ef migrations add InitialCreate`
1. Move `DbContext`, `DbContextFactory`, models and migrations to a separate DAL project
1. Fix namespaces if needed
1. `cd` to that DAL prject folder and run `dotnet ef migrations add SecondMigration`
1. Run `dotnet ef database update`
1. ...
1. Profit!