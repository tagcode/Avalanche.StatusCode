<b>Avalanche.StatusCode</b> contains various statuscode constants,
[[git]](https://github.com/tagcode/Avalanche.System), 
[[www]](https://avalanche.fi/Avalanche.Core/Avalanche.StatusCode/docs/index.html).

<b>HResult.Messages</b> is [table](https://avalanche.fi/Avalanche.Core/Avalanche.StatusCode/docs/hresult/index.html) that contains Microsoft's public HResult codes, keys and descriptions (Avalanche.StatusCode.HResult).

```csharp
// Get by key
IMessageDescription messageDescription = HResult.Messages.Keys["NULL.S_OK"];
// Print template text
WriteLine(messageDescription.Template); // "Operation successful"
```

<b>SystemMessages.Messages</b> is [table](https://avalanche.fi/Avalanche.Core/Avalanche.StatusCode/docs/system/index.html) that contains statuscodes that are automatically scraped from mscorlib.dll (Avalanche.StatusCode.System). 

```csharp
// Get by key
IMessageDescription messageDescription = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"];
// Print template text
WriteLine(messageDescription.Template); // "Parameter name: {0}"
```

Each scraped statuscode key has a field, permanently assigned unique code, associated hresult and exception, associated group and description template text.

```csharp
// Argumentize file not found 
IMessage filenotfound = SystemMessages.IO.FileNotFoundFileName.New("file.txt");
// Print template text
WriteLine(filenotfound); // "Could not find file 'file.txt'."
```

