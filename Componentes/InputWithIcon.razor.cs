using Microsoft.AspNetCore.Components;

namespace FormPersonalizable.Componentes
{
    public partial class InputWithIcon
    {
        [Parameter]
        public string IconClass { get; set; }

        [Parameter] 
        public string Value{ get; set; } = string.Empty;

        [Parameter]
        public string Placeholder { get; set; } = string.Empty;

        [Parameter(CaptureUnmatchedValues = true)] 
        public Dictionary<string, object> AdditionalAttributes { get; set; } = new Dictionary<string, object>();

    }
}
