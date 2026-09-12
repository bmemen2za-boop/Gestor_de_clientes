using Capa_negocio;

namespace Gestor_de_clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            CN_Guardar guardar = new CN_Guardar();
            bool resultado = guardar.InsertarUsuario(Txt_nombre.Text, txt_apellido.Text, txt_direccion.Text);

            if (resultado)
            {
                MessageBox.Show("Usuario guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
