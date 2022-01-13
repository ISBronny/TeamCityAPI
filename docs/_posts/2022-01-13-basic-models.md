---
layout: post
title: Models
category: basics
---
**TeamCityClient** contains properties, accessing which you can build requests to TeamCity and receive models:
```csharp
var query = client.Builds;
Builds res = await query.GetAsync();
```
The **GetAsync** method returns the **Builds** entity, which we would get by making a GET request `https://buildserver.mycompany.net/app/rest/builds`