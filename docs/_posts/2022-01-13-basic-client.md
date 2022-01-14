---
layout: post
title: TeamCityClient
category: basics
---
To work with the TC API, the TeamCityClient class is used.

Create **TeamCityClient** using your server address:
```csharp
var client = TeamCityClient("https://buildserver.mycompany.net");
```
Log in using a token or username and password:
```csharp
client.UseToken("myToken");
client.UseLoginAndPass("myLogin", "myPassword");
```
Now you can methods [methods]() and receive [models]().

