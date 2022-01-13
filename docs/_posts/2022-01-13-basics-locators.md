---
layout: post
title: Locators
category: basics
---
### Locators
In a number of places, you can specify a filter string which defines what entities to filter/affect in the request. This string representation is referred to as locator in the scope of the TeamCity REST API:
```csharp
var builds = await client.Builds
	.WithLocator(new BuildLocator()
	{
		Agent = new AgentLocator() {Name = "linux-blade-076-vm-13"},
		Count = 50
	})
	.GetAsync();
```
This query is similar to `https://buildserver.mycompany.net/app/rest/builds?locator=agent:(name:linux-blade-076-vm-13),count:50`