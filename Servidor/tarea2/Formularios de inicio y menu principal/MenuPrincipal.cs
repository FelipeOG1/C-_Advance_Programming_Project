

namespace tarea2


{


    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();



        }


        private void btnRegistrarRestaurantes_Click(object sender, EventArgs e)
        {

            RegistrarRestaurante restaurante = new RegistrarRestaurante();


            restaurante.ShowDialog();

        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            RegistrarCategoria categoria = new RegistrarCategoria();
            categoria.ShowDialog();

        }

        private void btnRegistrarPlato_Click(object sender, EventArgs e)
        {
            RegistrarPlato plato = new RegistrarPlato();
            plato.ShowDialog();

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente cliente = new RegistrarCliente();
            cliente.ShowDialog();
        }

        private void btnRegistrarPlatosRestaurante_Click(object sender, EventArgs e)
        {
            RegistrarPlatosRestaurante platosRestaurante = new RegistrarPlatosRestaurante();
            platosRestaurante.ShowDialog();

        }

        private void btnRegistrarExtras_Click(object sender, EventArgs e)
        {
            RegistrarExtras extras = new RegistrarExtras();
            extras.ShowDialog();
        }

        private void btnConsultarRestaurante_Click(object sender, EventArgs e)
        {
            ConsultarRestaurante restaurante = new ConsultarRestaurante();
            restaurante.ShowDialog();


        }

        private void btnConsultarCategoria_Click(object sender, EventArgs e)
        {
            ConsultarCategoria categoria = new ConsultarCategoria();
            categoria.ShowDialog();

        }

        private void btnConsultarPlato_Click(object sender, EventArgs e)
        {
            ConsultarPlato plato = new ConsultarPlato();
            plato.ShowDialog();

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente cliente = new ConsultarCliente();
            cliente.ShowDialog();


        }

        private void btnConsultarPlatosRestaurante_Click(object sender, EventArgs e)
        {
            ConsultarPlatosRestaurante consultarRestaurante = new ConsultarPlatosRestaurante();
            consultarRestaurante.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarExtras consultarExtras = new ConsultarExtras();
            consultarExtras.ShowDialog();
        }


    }
}