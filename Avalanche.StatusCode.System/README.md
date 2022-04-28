<b>Avalanche.StatusCodes.System</b> contains mscorlib.txt statuscodes,
[[git]](https://github.com/tagcode/Avalanche.System), 
[[www]](https://avalanche.fi/Avalanche.Core/Avalanche.StatusCode/docs/system/).

Add package reference to .csproj.
```xml
<PropertyGroup>
    <RestoreAdditionalProjectSources>https://avalanche.fi/Avalanche.Core/nupkg/index.json</RestoreAdditionalProjectSources>
</PropertyGroup>
<ItemGroup>
    <PackageReference Include="Avalanche.StatusCodes.System"/>
</ItemGroup>
```

<b>SystemMessages.Messages</b> contains statuscodes and display texts that are automatically
scraped from MIT-licensed [mscorlib.dll](https://github.com/microsoft/referencesource) (Multi-language Standard Common Object Runtime Library).

Each key in [mscorlib.txt](https://raw.githubusercontent.com/microsoft/referencesource/master/mscorlib/mscorlib.txt) is assigned with a message description.

```csharp
IMessageDescription messageDescription = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"];
```

Each key is assigned with a permanent code. Codes have facility value 0x23450000.

```csharp
IMessageDescription messageDescription = SystemMessages.Messages.Codes[unchecked((int)0xA34500CB)];
int code = messageDescription.Code!.Value;
```

Most descriptions are associated with a HResult code. 

```csharp
int? hresult = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"].HResult;
```

Most descriptions have an associated exception type.

```csharp
Type? error = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"].Exception as Type;
```

Descriptions have a template text.

```csharp
// Get template text
ITemplateText templateText = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"].Template;
// Print template text
WriteLine(templateText); // "Parameter name: {0}"
```

And each key is organized by group and is assigned to a class and a field. 

```csharp
// Argumentize file not found 
IMessage filenotfound = SystemMessages.IO.FileNotFoundFileName.New("file.txt");
// Print template text
WriteLine(filenotfound); // "Could not find file 'file.txt'."
```

Note however that there is a heuristic algorithm that chooses class and field name, and is prone to errors, which may be corrected later.
Therefore, it is recommended to not use field reference, but instead refer by <em>Key</em> or by <em>Code</em>.


```csharp
IMessageDescription messageDescription1 = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"];
IMessageDescription messageDescription2 = SystemMessages.Messages.Codes[unchecked((int)0xA34500CB)];
```

