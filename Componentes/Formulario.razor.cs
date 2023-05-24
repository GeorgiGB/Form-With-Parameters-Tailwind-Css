using FormPersonalizable.Data;

namespace FormPersonalizable.Componentes
{
    public partial class Formulario
    {
        private Usuario usuario = new();

        public string selectionOption { get; set; }

        private bool isToggled;
        private string toggledButton => isToggled ? "bg-blue-500 text-white rounded p-2" : "bg-gray-500 text-white rounded p-2";
        private void ToggleState()
        {
            isToggled = !isToggled;
        }

        public void LimpiarYActualizarFormulario()
        {
            usuario.Nombre = string.Empty;
            usuario.Apellidos = string.Empty;
            usuario.Correo = string.Empty;
            usuario.Telefono = string.Empty;
            StateHasChanged();
        }
    }
}
