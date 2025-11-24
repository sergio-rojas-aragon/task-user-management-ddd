# task-user-management-ddd
Proyect from ERP Flow with clean architecture and domain driven design

```
dotnet ef migrations add IdentityInit --context AuthDbContext --project src/TUM.Infrastructure --startup-project src/TUM.Api
```


create migrations

```
dotnet ef dbcontext list --project ./src/TUM.Infrastructure --startup-project ./src/TUM.Api
```


create migrations according to dbcontext

```
dotnet ef database update --context AuthDbContext --project src/TUM.Infrastructure --startup-project src/TUM.Api
```

