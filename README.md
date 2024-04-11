# Contact Manaagement Backend

This is an application that allows the user to manage their information
contacts.

## Run

Set the database connection string to:

```
appsettings.json

 "ConnectionStrings": {
   "DefaultConnection": "Your_Database_Connection"
 },
```

Later, you must do the migrations to your database, enter the 'src' folder and then use this command:

```
dotnet ef database update -p ContactManagement.Infrastructure -s ContactManagement.API
```

If you want to carry out a migration, I leave you the command that can help you:

```
dotnet ef migrations add NewTablesMigration -p ContactManagement.Infrastructure -s  ContactManagement.API -o Migrations
```


