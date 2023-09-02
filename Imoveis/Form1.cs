using Imoveis.Api;
using Imoveis.Models;
using ImoveisApp.Global;
using static System.Windows.Forms.DataFormats;

namespace Imoveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImoveis();
        }

        private void LoadImoveis()
        {
            ApiImoveis api = new ApiImoveis();

            string token = api.GetToken("admin");

            if(rbAluguel.Checked)
            {
                dgvImoveis.DataSource = api.GetAllImoveis(token, "Aluguel", txtSearch.Text);

            }else if(rbComprar.Checked)
            {
                dgvImoveis.DataSource = api.GetAllImoveis(token, "Compra", txtSearch.Text);

            }
            else
            {
                dgvImoveis.DataSource = api.GetAllImoveis(token, null, txtSearch.Text);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void dgvImoveis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ApiImoveis api = new ApiImoveis();
                int id = Convert.ToInt32(dgvImoveis.Rows[dgvImoveis.CurrentRow.Index].Cells["id"].Value);

                if (e.ColumnIndex == dgvImoveis.Columns["Editar"].Index)
                {
                    string token = api.GetToken("admin");
                    Config.edit = true;
                    Config.tempImovel = api.Get(id, token);

                    frmAdd edit = new frmAdd();
                    edit.ShowDialog();

                }
                else if (e.ColumnIndex == dgvImoveis.Columns["Deletar"].Index)
                {
                    DialogResult dialogResult = MessageBox.Show(
                    "Comfirma Exclusão", "Excluir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string token = api.GetToken("admin");
                        bool response = api.Delete(id, token);

                        if (response)
                        {
                            LoadImoveis();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao tentar excluir");
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LoadImoveis();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadImoveis();
 
        }

        private void rbComprar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbComprar.Checked)
            {
               
            }
        }
    }
}