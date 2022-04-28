using Avalanche.Message;
using Avalanche.StatusCode;
using static System.Console;

class hresult
{
    public static void Run()
    {
        {
            IMessage statusCode = HResult.COR_E_ARGUMENT.New();
        }        
        {
            try
            {
                HResult.E_NOTIMPL.Throw();
            }
            catch (NotImplementedException e)
            {
                WriteLine(e); // 
            }
        }
        {
            // Get by code
            IMessageDescription messageDescription = HResult.Messages.Codes[0x00000000];
            // Print template text
            WriteLine(messageDescription.Template); // "Operation successful"
        }
        {
            // Get by key
            IMessageDescription messageDescription = HResult.Messages.Keys["NULL.S_OK"];
            // Print template text
            WriteLine(messageDescription.Template); // "Operation successful"
        }
        {
            // Get code
            int hresult = HResultIds.COR_E_ARGUMENT;
            // Print code
            WriteLine("0x{0:X8}", hresult); // "0x80070057"
        }

    }
}
