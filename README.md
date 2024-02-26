<H1 align="center">Controle de Acesso</H1>
<p align="center">🚀 Projeto de criação de uma estrutura de Controle de Acesso para referências futuras</p>

## Recursos Utilizados

* NET 4.7.0
* Entity Framework

## Criação do Banco de Dados.

 Criar Banco de Dados DEVMEDIAEntities.

## Execução do Entity Framework nas IDE's: VS 2015/2017:

<details>
  <summary>Clique para mostrar conteúdo</summary>
  
 Ao realizar os comandos:
 
  ```
    Enable-Migrations
  ```
  e
  
  ```
    Update-Database -Verbose
  ```
  
Nas versões mais recentes do Visual Studio (2015/2017), se faz necessário criar uma nova instância do localdb do sql no seu computador. A qual poderá ser criado da seguinte maneira:

Passo 1: Abrir o cmd e executar o seguinte comando:
  ```
  SqlLocalDB.exe create "Local"
  ```
Passo 2: Executar a instance com seguinte comando:
  ```
  SqlLocalDb.exe start
  ```
  
Passo 3: Ir até o 'Package Manager Console' e executar o seguinte comando:
  ```
  Update-Database -Verbose
  ```

## Alteração da String de conexão

Configurar a connectionStrings com banco de dados local onde 'name' será utilizado como referência para conexão com Entity Framework
```
Web.Config
```
```
<connectionStrings>
  <add name="DEVMEDIAEntities" connectionString="Data Source=(localdb)\Local;Initial Catalog=DEVMEDIAEntities;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```

</details>

 


## Resultado 




<div align="center">
 <h3>Login</h3>
<img src="https://github.com/lucasmargui/ASP_Controle_Acesso/assets/157809964/13aa059e-085e-4d34-83ae-7cccb7542353" style="width:100%">
</div>








<div align="center">
  <h3>Home</h3>
<img src="https://github.com/lucasmargui/ASP_Controle_Acesso/assets/157809964/6be73396-7d9e-49f4-b115-5213c7aae000" style="width:100%">
</div>




<div align="center">
  <h3>Usuários</h3>
<img src="https://github.com/lucasmargui/ASP_Controle_Acesso/assets/157809964/8a2388e7-80a5-4947-bbd4-4f37a4eaaf39" style="width:100%">
</div>



