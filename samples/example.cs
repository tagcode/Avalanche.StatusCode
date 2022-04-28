using Avalanche.Message;
using Avalanche.StatusCode;
using static System.Console;

class example
{
    public static void Run()
    {
        {
            // Get by key
            IMessageDescription messageDescription = HResult.Messages.Keys["NULL.S_OK"];
            // Print template text
            WriteLine(messageDescription.Template); // "Operation successful"
        }
        {
            // Get by key
            IMessageDescription messageDescription = SystemMessages.Messages.Keys["mscorlib.Arg_ParamName_Name"];
            // Print template text
            WriteLine(messageDescription.Template); // "Parameter name: {0}"
        }
        {
            // Argumentize file not found 
            IMessage filenotfound = SystemMessages.IO.FileNotFoundFileName.New("file.txt");
            // Print template text
            WriteLine(filenotfound); // "Could not find file 'file.txt'."
        }
    }
}
