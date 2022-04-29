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
                MessageBox.Show("Pasta crida com sucesso!");
            }
            else
            {
                MessageBox.Show("Pasta já existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtNomeCriar.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //deletar pasta
            string pastaDeletada = @"D:\" + txtNomeDel.Text;
                
            if (Directory.Exists(pastaDeletada))
            {
                Directory.Delete(pastaDeletada);
                MessageBox.Show("Pasta deletada com sucesso");
            }
            else
            {
                MessageBox.Show("Pasta não existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtNomeDel.Clear();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            //mover de uma pasta para outra
            string pastaOrigem = Path.Combine(@"D:\" + txtPastaOrigem.Text, txtNomeArquivo.Text);
            string pastaDestino = Path.Combine(@"D:\" + txtPastaDestino.Text, txtNomeArquivo.Text);
            File.Move(pastaOrigem, pastaDestino);
            MessageBox.Show("Arquivo movido com sucesso!");

            txtNomeArquivo.Clear();
            txtPastaDestino.Clear();
            txtPastaOrigem.Clear();

            //não consegui fazer a validação
            //if (File.Exists(txtNomeArquivo.Text))
            //{
            //    if(Directory.Exists(pastaOrigem) && Directory.Exists(pastaDestino))
            //    {
            //        File.Move(pastaOrigem, pastaDestino);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Diretorio não existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Arquivo não existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

                        
        }

        private void ManipulacaoDiretorios_Load(object sender, EventArgs e)
        {

        }
    }
}
