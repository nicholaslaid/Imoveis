using Imoveis.Api;
using Imoveis.Models;
using ImoveisApp.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imoveis
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Imoveiss imoveis = new Imoveiss();
            ApiImoveis api = new ApiImoveis();

            imoveis.cidade = txtCidade.Text;
            imoveis.cidade = txtBairro.Text;
            imoveis.type = txtTipo.Text;
            imoveis.value = Convert.ToInt32(txtValor.Text);
            imoveis.qtd_de_banheiros = Convert.ToInt32(txtBanheiros.Text);
            imoveis.qtd_de_quartos = Convert.ToInt32(txtQuartos.Text);
            imoveis.qtd_de_salas = Convert.ToInt32(txtSalas.Text);
            imoveis.qtd_de_vagas = Convert.ToInt32(txtVagas.Text);

            if (Config.edit == true)
            {
                imoveis.id = Convert.ToInt32(txtId.Text);
                api.Update(imoveis);
                Close();
            }
            else
            {
                api.Add(imoveis);
                Close();
            }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            if (Config.edit)
            {
                txtId.Text = Config.tempImovel.id.ToString();
                txtCidade.Text = Config.tempImovel.cidade;
                txtBairro.Text = Config.tempImovel.bairro;
                txtTipo.Text = Config.tempImovel.type;
                txtQuartos.Text = Config.tempImovel.qtd_de_quartos.ToString();
                txtValor.Text = Config.tempImovel.value.ToString();
                txtQuartos.Text = Config.tempImovel.qtd_de_quartos.ToString();
                txtSalas.Text = Config.tempImovel.qtd_de_salas.ToString();
                txtBanheiros.Text = Config.tempImovel.qtd_de_banheiros.ToString();
                txtVagas.Text = Config.tempImovel.qtd_de_vagas.ToString();
            }
        }

        private void frmAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.tempImovel = new Imoveiss();
            Config.edit = false;
        }
    }
}
