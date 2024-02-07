<H1 align="center">Controle de Acesso</H1>
<p align="center">🚀 Projeto de criação de uma estrutura de Controle de Acesso para referências futuras</p>

## Recursos Utilizados

* NET 4.7.0
* Entity Framework

 ## Criação do Banco de Dados.

 Criar Banco de Dados DEVMEDIAEntities.

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

## Resultado 

### Login
<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1204883256416141364/image.png?ex=65d659f9&is=65c3e4f9&hm=8b0d6d99de2993d2b5a5b3e9efb142b9010201dcb01d8f1c44fe8e4da6294e2e&" alt="">

### Home
<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1204883384304795669/image.png?ex=65d65a18&is=65c3e518&hm=98616cd0aa33844658bd6e3b4604f1bf8583de5ed21b0e2708e202da78263df8&" alt="">

### Usuários
<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1204883458422341652/image.png?ex=65d65a2a&is=65c3e52a&hm=ce7b333d34c77b171141dde32894d1da6679b972e42dbe36207a7b039ec0ee11&" alt="">
