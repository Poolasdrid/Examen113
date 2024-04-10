using System.Windows.Forms;

namespace trabajadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eMPRESADataSet.trabajadores' Puede moverla o quitarla según sea necesario.
            this.trabajadoresTableAdapter.Fill(this.eMPRESADataSet.trabajadores);

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
