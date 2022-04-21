# CleanArchitectureWithMVC
Implementing Clean Architecture with MVC

## <a name="Migration"></a> Migration
### Powershell
Adding migrations: Project MVC
```
add-migration InitialCreate -context ApplicationDbContext -OutputDir Migrations
update-database
```
