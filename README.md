<H1 align="center">Access Control</H1>
<p align="center">🚀 Project to create an Access Control structure for future references</p>

## Resources Used

* NET 4.7.0
* Entity Framework


<div align="center">
  <h3>Login</h3>
<img src="https://github.com/lucasmargui/ASP_Controle_Acesso/assets/157809964/13aa059e-085e-4d34-83ae-7cccb7542353" style="width:70%">
</div>


<div align="center">
   <h3>Home</h3>
<img src="https://github.com/lucasmargui/ASP_Controle_Acesso/assets/157809964/6be73396-7d9e-49f4-b115-5213c7aae000" style="width:70%">
</div>


<div align="center">
   <h3>Users</h3>
<img src="https://github.com/lucasmargui/ASP_Controle_Acesso/assets/157809964/8a2388e7-80a5-4947-bbd4-4f37a4eaaf39" style="width:70%">
</div>

## Database Create.

  Create DEVMEDIAEntities Database.

## Entity Framework execution in IDE's: VS 2015/2017:

<details>
   <summary>Click to show content</summary>
  
  When executing the commands:
 
   ```
     Enable-Migrations
   ```
   It is
  
   ```
     Update-Database -Verbose
   ```
  
In the most recent versions of Visual Studio (2015/2017), it is necessary to create a new instance of sql localdb on your computer. Which can be created in the following way:

Step 1: Open cmd and execute the following command:
   ```
   SqlLocalDB.exe create "Local"
   ```
Step 2: Run the instance with the following command:
   ```
   SqlLocalDb.exe start
   ```
  
Step 3: Go to the 'Package Manager Console' and execute the following command:
   ```
   Update-Database -Verbose
   ```

## Changing the connection string

Configure connectionStrings with local database where 'name' will be used as a reference for connecting to Entity Framework
```
Web.Config
```
```
<connectionStrings>
   <add name="DEVMEDIAEntities" connectionString="Data Source=(localdb)\Local;Initial Catalog=DEVMEDIAEntities;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```

</details>

 
