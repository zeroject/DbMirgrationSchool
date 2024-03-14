
# EF Migration

## Adding a new Migration

### Step 1
Add your DBset for the new table you wanna add

### Step 2
After adding the new table, run the following commands in the terminal
```
dotnet ef migrations add [migrationName]  
```
```
dotnet ef database update
```  

## Removing a migration and rolling back

### Step 1

first get a list of all current migrations
```
dotnet ef migrations list
```
### Step 2
then revert to the migration you want eith the following command

```
dotnet ef database update [migrationName]
```

## CLI errors
If the CLI is not installed, you can install it by running the following command:
```
dotnet tool install --global dotnet-ef
```
