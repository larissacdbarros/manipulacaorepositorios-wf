using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApp4
{
    public partial class ManipulacaoDiretorios : Form
    {
        public ManipulacaoDiretorios()
        {
            InitializeComponent();
        }

        private void btnNovaPasta_Click(object sender, EventArgs e)
        {
            //criar nova pasta
            string pastaCriada = @"D:\" + txtNomeCriar.Text;
            if (!Directory.Exists(pastaCriada)) 
            {
                Directory.CreateDirectory(pastaCriada);
            }
            else
            {
                MessageBox.Show("Pasta já existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //deletar pasta
            string pastaDeletada = @"D:\" + txtNomeDel.Text;
                
            if (Directory.Exists(pastaDeletada))
            {
                Directory.Delete(pastaDeletada);
            }
            else
            {
                MessageBox.Show("Pasta não existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            //mover de uma pasta para outra
            string arquivoOrigem = Path.Combine(@"D:\" + txtPastaOrigem.Text, txtNomeArquivo.Text);
            string arquivoDestino = Path.Combine(@"D:\" + txtPastaDestino.Text, txtNomeArquivo.Text);
              
            
            File.Move(arquivoOrigem, arquivoDestino);


            
        }
    }
}
