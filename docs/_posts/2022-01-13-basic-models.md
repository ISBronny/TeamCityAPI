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

Some TC models are paged. TC returns such models by 100 pieces (unless otherwise specified in the [locator]()). So they implements IAsyncEnumerable.

In this code, the client sends requests asynchronously:
- `https://buildserver.mycompany.net/app/rest/builds?locator=count:100,start:0`
- `https://buildserver.mycompany.net/app/rest/builds?locator=count:100,start:100`
- `https://buildserver.mycompany.net/app/rest/builds?locator=count:100,start:200`
- and so on

Full list of models you can find [here]()