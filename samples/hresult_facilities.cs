using Avalanche.Message;
using Avalanche.StatusCode;
using static System.Console;

class hresult_facilities
{
    public static void Run()
    {
        {
            // Get by facility code
            IMessageDescription messageDescription = HResult.Facilities.Codes[HResultIds.FACILITY_CERT];
            // Print template text
            WriteLine(messageDescription.Template); // "Certificate client or server"
        }
        {
            // Get by key
            IMessageDescription messageDescription = HResult.Facilities.Keys["WINDOWS"];
            // Print template text
            WriteLine(messageDescription.Template); // "Windows subsystem"
        }
        {
            // Get code
            int hresult = HResultIds.FACILITY_CERT;
            // Print code
            WriteLine("0x{0:X8}", hresult); // "0x000B0000"
        }
    }
}
