namespace Imoveis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvImoveis = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            qtd_quartos = new DataGridViewTextBoxColumn();
            qtd_banheiros = new DataGridViewTextBoxColumn();
            qtd_vagas = new DataGridViewTextBoxColumn();
            qtd_salas = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Deletar = new DataGridViewButtonColumn();
            label1 = new Label();
            txtSearch = new TextBox();
            rbAluguel = new RadioButton();
            rbComprar = new RadioButton();
            rbAny = new RadioButton();
            label2 = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImoveis).BeginInit();
            SuspendLayout();
            // 
            // dgvImoveis
            // 
            dgvImoveis.AllowUserToAddRows = false;
            dgvImoveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImoveis.Columns.AddRange(new DataGridViewColumn[] { id, cidade, bairro, tipo, valor, qtd_quartos, qtd_banheiros, qtd_vagas, qtd_salas, Editar, Deletar });
            dgvImoveis.Location = new Point(21, 79);
            dgvImoveis.Name = "dgvImoveis";
            dgvImoveis.RowHeadersWidth = 62;
            dgvImoveis.RowTemplate.Height = 33;
            dgvImoveis.Size = new Size(1268, 389);
            dgvImoveis.TabIndex = 0;
            dgvImoveis.CellClick += dgvImoveis_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Visible = false;
            id.Width = 8;
            // 
            // cidade
            // 
            cidade.DataPropertyName = "cidade";
            cidade.HeaderText = "cidade";
            cidade.MinimumWidth = 8;
            cidade.Name = "cidade";
            cidade.Width = 150;
            // 
            // bairro
            // 
            bairro.DataPropertyName = "bairro";
            bairro.HeaderText = "bairro";
            bairro.MinimumWidth = 8;
            bairro.Name = "bairro";
            bairro.Width = 150;
            // 
            // tipo
            // 
            tipo.DataPropertyName = "type";
            tipo.HeaderText = "tipo";
            tipo.MinimumWidth = 8;
            tipo.Name = "tipo";
            tipo.Width = 150;
            // 
            // valor
            // 
            valor.DataPropertyName = "value";
            valor.HeaderText = "valor";
            valor.MinimumWidth = 8;
            valor.Name = "valor";
            valor.Width = 150;
            // 
            // qtd_quartos
            // 
            qtd_quartos.DataPropertyName = "qtd_de_quartos";
            qtd_quartos.HeaderText = "qtd_quartos";
            qtd_quartos.MinimumWidth = 8;
            qtd_quartos.Name = "qtd_quartos";
            qtd_quartos.Width = 150;
            // 
            // qtd_banheiros
            // 
            qtd_banheiros.DataPropertyName = "qtd_de_banheiros";
            qtd_banheiros.HeaderText = "qtd_banheiros";
            qtd_banheiros.MinimumWidth = 8;
            qtd_banheiros.Name = "qtd_banheiros";
            qtd_banheiros.Width = 150;
            // 
            // qtd_vagas
            // 
            qtd_vagas.DataPropertyName = "qtd_de_vagas";
            qtd_vagas.HeaderText = "qtd_vagas";
            qtd_vagas.MinimumWidth = 8;
            qtd_vagas.Name = "qtd_vagas";
            qtd_vagas.Width = 150;
            // 
            // qtd_salas
            // 
            qtd_salas.DataPropertyName = "qtd_de_salas";
            qtd_salas.HeaderText = "qtd_salas";
            qtd_salas.MinimumWidth = 8;
            qtd_salas.Name = "qtd_salas";
            qtd_salas.Width = 150;
            // 
            // Editar
            // 
            Editar.DataPropertyName = "Editar";
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 150;
            // 
            // Deletar
            // 
            Deletar.DataPropertyName = "Deletar";
            Deletar.HeaderText = "Deletar";
            Deletar.MinimumWidth = 8;
            Deletar.Name = "Deletar";
            Deletar.UseColumnTextForButtonValue = true;
            Deletar.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 499);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Procurar";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(96, 499);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(875, 31);
            txtSearch.TabIndex = 2;
            // 
            // rbAluguel
            // 
            rbAluguel.AutoSize = true;
            rbAluguel.Location = new Point(96, 557);
            rbAluguel.Name = "rbAluguel";
            rbAluguel.Size = new Size(87, 29);
            rbAluguel.TabIndex = 3;
            rbAluguel.TabStop = true;
            rbAluguel.Text = "Alguel";
            rbAluguel.UseVisualStyleBackColor = true;
            // 
            // rbComprar
            // 
            rbComprar.AutoSize = true;
            rbComprar.Location = new Point(189, 561);
            rbComprar.Name = "rbComprar";
            rbComprar.Size = new Size(107, 29);
            rbComprar.TabIndex = 4;
            rbComprar.TabStop = true;
            rbComprar.Text = "Comprar";
            rbComprar.UseVisualStyleBackColor = true;
            // 
            // rbAny
            // 
            rbAny.AutoSize = true;
            rbAny.Location = new Point(302, 561);
            rbAny.Name = "rbAny";
            rbAny.Size = new Size(164, 29);
            rbAny.TabIndex = 5;
            rbAny.TabStop = true;
            rbAny.Text = "Sem preferencia";
            rbAny.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 561);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 6;
            label2.Text = "Tipo";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1021, 499);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(215, 74);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Procurar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 613);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(rbAny);
            Controls.Add(rbComprar);
            Controls.Add(rbAluguel);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvImoveis);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImoveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvImoveis;
        private Label label1;
        private TextBox txtSearch;
        private RadioButton rbAluguel;
        private RadioButton rbComprar;
        private RadioButton rbAny;
        private Label label2;
        private Button btnSearch;
        private Button btnAdd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn bairro;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn qtd_quartos;
        private DataGridViewTextBoxColumn qtd_banheiros;
        private DataGridViewTextBoxColumn qtd_vagas;
        private DataGridViewTextBoxColumn qtd_salas;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Deletar;
    }
}