using Avalanche.Message;
using Avalanche.StatusCode;
using Avalanche.Template;
using static System.Console;

class system
{
    public static void Run()
    {
        {
            IMessageDescription messageDescription = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"];
        }
        {
            IMessageDescription messageDescription = SystemMessages.Messages.Codes[unchecked((int)0xA34500CB)];
            int code = messageDescription.Code!.Value;
        }
        {
            int? hresult = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"].HResult;
        }
        {
            Type? error = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"].Exception as Type;
        }
        {
            // Get template text
            ITemplateText templateText = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"].Template;
            // Print template text
            WriteLine(templateText); // "Parameter name: {0}"
        }
        {
            // Argumentize file not found 
            IMessage filenotfound = SystemMessages.IO.FileNotFoundFileName.New("file.txt");
            // Print template text
            WriteLine(filenotfound); // "Could not find file 'file.txt'."
        }
        {
            IMessageDescription messageDescription1 = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"];
            IMessageDescription messageDescription2 = SystemMessages.Messages.Codes[unchecked((int)0xA34500CB)];
        }
    }
}
