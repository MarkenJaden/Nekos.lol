using Microsoft.JSInterop;

namespace Nekos.Utils;

public class JsConsole(IJSRuntime jSRuntime)
{
    public async Task LogAsync(string message)
    {
        await jSRuntime.InvokeVoidAsync("console.log", message);
    }
}