# EfCore Database First

## 1. Create a new project

```bash
dotnet new webapi -n EfCoreDatabaseFirst
cd EfCoreDatabaseFirst
```

## 2. Install the required packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

## 3. Create the database (will use docker)

Turn on docker and run the following command to create a new SQL Server container.

```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Password123" -p 1433:1433 --name sql1 -d mcr.microsoft.com/mssql/server:2019-latest
```

To start the container, run the following command.

```bash
docker start sql1
```

```bash
dotnet ef dbcontext scaffold "Server=localhost,1433;Database=EfCoreDatabaseFirst;User Id=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -o Models
```