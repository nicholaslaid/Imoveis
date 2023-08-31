namespace Imoveis
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtValor = new TextBox();
            txtTipo = new TextBox();
            txtQuartos = new TextBox();
            txtBanheiros = new TextBox();
            txtVagas = new TextBox();
            txtSalas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSalvar = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(108, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 0;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(108, 100);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(150, 31);
            txtCidade.TabIndex = 1;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(108, 161);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(150, 31);
            txtBairro.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(108, 221);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 3;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(108, 279);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(150, 31);
            txtTipo.TabIndex = 4;
            // 
            // txtQuartos
            // 
            txtQuartos.Location = new Point(108, 346);
            txtQuartos.Name = "txtQuartos";
            txtQuartos.Size = new Size(150, 31);
            txtQuartos.TabIndex = 5;
            // 
            // txtBanheiros
            // 
            txtBanheiros.Location = new Point(108, 400);
            txtBanheiros.Name = "txtBanheiros";
            txtBanheiros.Size = new Size(150, 31);
            txtBanheiros.TabIndex = 6;
            // 
            // txtVagas
            // 
            txtVagas.Location = new Point(108, 453);
            txtVagas.Name = "txtVagas";
            txtVagas.Size = new Size(150, 31);
            txtVagas.TabIndex = 7;
            // 
            // txtSalas
            // 
            txtSalas.Location = new Point(108, 519);
            txtSalas.Name = "txtSalas";
            txtSalas.Size = new Size(153, 31);
            txtSalas.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 37);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 10;
            label2.Text = "Cidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 161);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 11;
            label3.Text = "Bairro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 224);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 12;
            label4.Text = "Valor";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 279);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 13;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 346);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 14;
            label6.Text = "Quartos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 400);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 15;
            label7.Text = "Banheiros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 453);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 16;
            label8.Text = "Vagas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 522);
            label9.Name = "label9";
            label9.Size = new Size(52, 25);
            label9.TabIndex = 17;
            label9.Text = "Salas";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(330, 224);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(500, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 589);
            Controls.Add(btnCancel);
            Controls.Add(btnSalvar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalas);
            Controls.Add(txtVagas);
            Controls.Add(txtBanheiros);
            Controls.Add(txtQuartos);
            Controls.Add(txtTipo);
            Controls.Add(txtValor);
            Controls.Add(txtBairro);
            Controls.Add(txtCidade);
            Controls.Add(txtId);
            Name = "frmAdd";
            Text = "frmAdd";
            FormClosing += frmAdd_FormClosing;
            Load += frmAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtValor;
        private TextBox txtTipo;
        private TextBox txtQuartos;
        private TextBox txtBanheiros;
        private TextBox txtVagas;
        private TextBox txtSalas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSalvar;
        private Button btnCancel;
    }
}