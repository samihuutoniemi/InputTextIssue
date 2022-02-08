using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Components;

public class InputText2 : InputText
{
    [Parameter]
    public Func<string, string> Formatter { get; set; }

    protected override bool TryParseValueFromString(string value, out string result, [NotNullWhen(false)] out string validationErrorMessage)
    {
        var parseResult = base.TryParseValueFromString(value, out result, out validationErrorMessage);

        return parseResult;
    }

    protected override string FormatValueAsString(string value)
    {
        var result = Formatter?.Invoke(value) ?? value;
        //CurrentValueAsString = result;

        result = base.FormatValueAsString(result);

        return result;
    }
}
