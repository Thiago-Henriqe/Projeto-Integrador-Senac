
namespace T41N_DoTheEvolution
{
    partial class MenuCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpfCnpjCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.DGVcliente = new System.Windows.Forms.DataGridView();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            this.btnAtualizarCliente = new System.Windows.Forms.Button();
            this.btnVoltarCliente = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPF/CNPJ:";
            // 
            // txtCpfCnpjCliente
            // 
            this.txtCpfCnpjCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCpfCnpjCliente.Location = new System.Drawing.Point(118, 21);
            this.txtCpfCnpjCliente.Name = "txtCpfCnpjCliente";
            this.txtCpfCnpjCliente.Size = new System.Drawing.Size(328, 23);
            this.txtCpfCnpjCliente.TabIndex = 6;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnBuscarCliente.Location = new System.Drawing.Point(452, 19);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarCliente.TabIndex = 7;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // DGVcliente
            // 
            this.DGVcliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.DGVcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcliente.Location = new System.Drawing.Point(12, 59);
            this.DGVcliente.Name = "DGVcliente";
            this.DGVcliente.RowTemplate.Height = 25;
            this.DGVcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcliente.Size = new System.Drawing.Size(776, 333);
            this.DGVcliente.TabIndex = 8;
            this.DGVcliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcliente_CellClick);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnNovoCliente.Location = new System.Drawing.Point(688, 414);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(100, 30);
            this.btnNovoCliente.TabIndex = 11;
            this.btnNovoCliente.Text = "NOVO";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnDeletarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnDeletarCliente.Location = new System.Drawing.Point(12, 414);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnDeletarCliente.TabIndex = 12;
            this.btnDeletarCliente.Text = "DELETAR";
            this.btnDeletarCliente.UseVisualStyleBackColor = false;
            this.btnDeletarCliente.Click += new System.EventHandler(this.btnDeletarCliente_Click);
            // 
            // btnAtualizarCliente
            // 
            this.btnAtualizarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnAtualizarCliente.Location = new System.Drawing.Point(118, 414);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnAtualizarCliente.TabIndex = 13;
            this.btnAtualizarCliente.Text = "ATUALIZAR";
            this.btnAtualizarCliente.UseVisualStyleBackColor = false;
            this.btnAtualizarCliente.Click += new System.EventHandler(this.btnAtualizarCliente_Click);
            // 
            // btnVoltarCliente
            // 
            this.btnVoltarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnVoltarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnVoltarCliente.Location = new System.Drawing.Point(224, 414);
            this.btnVoltarCliente.Name = "btnVoltarCliente";
            this.btnVoltarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnVoltarCliente.TabIndex = 14;
            this.btnVoltarCliente.Text = "VOLTAR";
            this.btnVoltarCliente.UseVisualStyleBackColor = false;
            this.btnVoltarCliente.Click += new System.EventHandler(this.btnVoltarCliente_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(319, 419);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 15;
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnVoltarCliente);
            this.Controls.Add(this.btnAtualizarCliente);
            this.Controls.Add(this.btnDeletarCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.DGVcliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCpfCnpjCliente);
            this.Controls.Add(this.label1);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpfCnpjCliente;
        public System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView DGVcliente;
        public System.Windows.Forms.Button btnNovoCliente;
        public System.Windows.Forms.Button btnDeletarCliente;
        public System.Windows.Forms.Button btnAtualizarCliente;
        public System.Windows.Forms.Button btnVoltarCliente;
        private System.Windows.Forms.Label lblMensagem;
    }
}