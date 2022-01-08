# TeamCity API
||Badge|
|------|:------:|
|**Target Frameworks**|[![Targets](https://img.shields.io/badge/.NET%20Standard-2.0-green.svg)](https://docs.microsoft.com/ru-ru/dotnet/standard/net-standard)
|**Nuget**|[![](http://img.shields.io/nuget/v/TeamCityAPI.svg)](http://www.nuget.org/packages/TeamCityAPI)
|**Downloads**|[![](https://img.shields.io/nuget/dt/TeamCityAPI.svg)](https://www.nuget.org/packages/TeamCityAPI/)
|**Issues**|[![](https://img.shields.io/github/issues/ISBronny/TeamCityAPI.svg)](https://github.com/ISBronny/TeamCityAPI/issues)

You can read about TeamCity REST API [here](https://www.jetbrains.com/help/teamcity/rest/teamcity-rest-api-documentation.html).

## Install
##### Package manager:
```
Install-Package TeamCityAPI -Version 0.1.1
```

##### .NET CLI:
```
dotnet add package TeamCityAPI --version 0.1.1
```
NuGet: https://www.nuget.org/packages/TeamCityAPI/0.1.1

## How to use
### TeamCityClient
Create **TeamCityClient** using your server address:
```csharp
var client = TeamCityClient("https://buildserver.mycompany.net");
```
Log in using a token or username and password:
```csharp
client.UseToken("myToken");
client.UseLoginAndPass("myLogin", "myPassword");
```
### Models
**TeamCityClient** contains properties, accessing which you can build requests to TeamCity and receive models:
```csharp
var query = client.Builds;
Builds res = await query.GetAsync();
```
The **GetAsync** method returns the **Builds** entity, which we would get by making a GET request `https://buildserver.mycompany.net/app/rest/builds`

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

### Includes
You can get children in request:
```csharp
var query = client.Builds
	.Include(b => b.Build)
		.ThenInclude(x => x.Artifacts)
	.Include(x => x.Build)
		 .ThenInclude(x => x.Agent)
```
This query is similar to `https://buildserver.mycompany.net/app/rest/builds?fields=$short,build($short,artifacts($short),agent($short))`

Also there are two include types: **short** and **long**.
Models can contain simple fields (bool, string, int, etc.) and composite (other models). If we use **IncludeType.Short**, then only simple fields will be loaded, and composite fields will be **null**. If we use **IncludeType.Long** then the composite fields will be loaded as well.
Short include:
```csharp
var query = client.TestOccurrences
                .Include(x => x.TestOccurrence, IncludeType.Short)
                .WithLocator(new TestOccurrenceLocator()
                {
                    Count = 1,
                    Build = new BuildLocator { Id = 156770153}
                });
var tests = await query.GetAsync();
```
This returns object:
```xml
<testOccurrences count="1" href="https://buildserver.mycompany.net/app/rest/testOccurrences?locator=build:(id:156770153),count:1&fields=$short,testOccurrence($short)" nextHref="/app/rest/testOccurrences?fields=$short,testOccurrence($short)&locator=build:(id:156770153),count:1,start:1">
  <testOccurrence id="build:(id:156770020),id:34195" name="TestName" status="UNKNOWN" ignored="true" href="/app/rest/testOccurrences/build:(id:156770020),id:34195"/>
</testOccurrences>
```
Long include:
```csharp
var query = client.TestOccurrences
                .Include(x => x.TestOccurrence, IncludeType.Long)
                .WithLocator(new TestOccurrenceLocator()
                {
                    Count = 1,
                    Build = new BuildLocator { Id = 156770153}
                });
var tests = await query.GetAsync();
```
This returns object:
```xml
<testOccurrences count="1" href="https://buildserver.mycompany.net/app/rest/testOccurrences?locator=build:(id:156770153),count:1&fields=$short,testOccurrence($long)" nextHref="/app/rest/testOccurrences?fields=$short,testOccurrence($long)&locator=build:(id:156770153),count:1,start:1">
  <testOccurrence id="build:(id:156770020),id:34195" name="TestName" status="UNKNOWN" ignored="true" href="/app/rest/testOccurrences/build:(id:156770020),id:34195">
    <ignoreDetails>Not implemented</ignoreDetails>
    <test id="-1831283233637679723" name="TestName" href="/app/rest/tests/id:-1831283233637679723"/>
    <build id="156770020" buildTypeId="1234567" number="213.0.20211217.221911-eap09d" status="SUCCESS" state="finished" branchName="refs/heads/net213" defaultBranch="true" href="/app/rest/builds/id:156770020" webUrl="https://buildserver.mycompany.net/viewLog.html?buildId=156770020&buildTypeId=1234567">
      <finishOnAgentDate>20211218T014303+0300</finishOnAgentDate>
    </build>
  </testOccurrence>
</testOccurrences>
```
