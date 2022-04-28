<b>Avalanche.StatusCode.HResult</b> contains message descriptions that be used to create status code and event messages,
[[git]](https://github.com/tagcode/Avalanche.StatusCode), 
[[www]](https://avalanche.fi/Avalanche.Core/Avalanche.StatusCode/docs/hresult/).

Add package reference to .csproj.
```xml
<PropertyGroup>
    <RestoreAdditionalProjectSources>https://avalanche.fi/Avalanche.Core/nupkg/index.json</RestoreAdditionalProjectSources>
</PropertyGroup>
<ItemGroup>
    <PackageReference Include="Avalanche.StatusCodes.HResult"/>
</ItemGroup>
```

```csharp
IMessage statusCode = HResult.COR_E_ARGUMENT.New();
```

[HResult](https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-erref/0642cb2f-2075-4469-918c-4441e69c548a) is microsoft's status code.


HResult message descriptions can throw exceptions with message attached.

```csharp
try
{
    HResult.E_NOTIMPL.Throw();
}
catch (NotImplementedException e)
{
    WriteLine(e); // 
}
```

<b>HResult.Messages</b> is [table](https://avalanche.fi/Avalanche.Core/Avalanche.Message/docs/messagedescriptions/index.html) that be queried by code.

```csharp
// Get by code
IMessageDescription messageDescription = HResult.Messages.Codes[0x00000000];
// Print template text
WriteLine(messageDescription.Template); // "Operation successful"
```

Table can be queried by key.

```csharp
// Get by key
IMessageDescription messageDescription = HResult.Messages.Keys["NULL.S_OK"];
// Print template text
WriteLine(messageDescription.Template); // "Operation successful"
```

<b>HResultIds</b> contains int constants.

```csharp
// Get code
int hresult = HResultIds.COR_E_ARGUMENT;
// Print code
WriteLine("0x{0:X8}", hresult); // "0x80070057"
```

HResult uses following bit semantics.

| Bit     | Mask       | Description       | 
|:--------||:----------|-------------------|
| 0-15    | 0x000FF0FF | Code              |
| 16-26   | 0x07FF0000 | Facility          |
| 27      | 0x08000000 | 0=StatusCode, 1=Display text |
| 28      | 0x10000000 | Reserved |
| 29      | 0x20000000 | 0=Microsoft, 1=3rd party code |
| 30      | 0x40000000 | ? Information ?   |
| 31      | 0x80000000 | 0=Good, 1=Bad     |

HResult severity flags.

| Value| Code       | Description |
|:-----|:-----------|:------------|
| Good      | 0x00000000 | Operation was successful. |
| Bad       | 0x80000000 | Operation failed. |
| SeverityMask | 0x80000000 | Bit mask when checking for Bad result. |
