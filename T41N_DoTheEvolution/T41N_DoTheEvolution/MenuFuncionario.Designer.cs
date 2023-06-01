
namespace T41N_DoTheEvolution
{
    partial class MenuFuncionario
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
            this.txtCpfFuncionario = new System.Windows.Forms.TextBox();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.DGVfuncionario = new System.Windows.Forms.DataGridView();
            this.btnDeletarFuncionario = new System.Windows.Forms.Button();
            this.btnAtualizarFuncionario = new System.Windows.Forms.Button();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.btnVoltarFuncionario = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME/CPF:";
            // 
            // txtCpfFuncionario
            // 
            this.txtCpfFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCpfFuncionario.Location = new System.Drawing.Point(129, 18);
            this.txtCpfFuncionario.Name = "txtCpfFuncionario";
            this.txtCpfFuncionario.Size = new System.Drawing.Size(328, 23);
            this.txtCpfFuncionario.TabIndex = 5;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(463, 15);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarFuncionario.TabIndex = 6;
            this.btnBuscarFuncionario.Text = "BUSCAR";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = false;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // DGVfuncionario
            // 
            this.DGVfuncionario.AllowUserToAddRows = false;
            this.DGVfuncionario.AllowUserToDeleteRows = false;
            this.DGVfuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.DGVfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVfuncionario.Location = new System.Drawing.Point(12, 59);
            this.DGVfuncionario.Name = "DGVfuncionario";
            this.DGVfuncionario.ReadOnly = true;
            this.DGVfuncionario.RowTemplate.Height = 25;
            this.DGVfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVfuncionario.Size = new System.Drawing.Size(776, 333);
            this.DGVfuncionario.TabIndex = 7;
            this.DGVfuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVfuncionario_CellClick);
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnDeletarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(12, 414);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(100, 30);
            this.btnDeletarFuncionario.TabIndex = 8;
            this.btnDeletarFuncionario.Text = "DELETAR";
            this.btnDeletarFuncionario.UseVisualStyleBackColor = false;
            this.btnDeletarFuncionario.Click += new System.EventHandler(this.btnDeletarFuncionario_Click);
            // 
            // btnAtualizarFuncionario
            // 
            this.btnAtualizarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnAtualizarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnAtualizarFuncionario.Location = new System.Drawing.Point(118, 414);
            this.btnAtualizarFuncionario.Name = "btnAtualizarFuncionario";
            this.btnAtualizarFuncionario.Size = new System.Drawing.Size(100, 30);
            this.btnAtualizarFuncionario.TabIndex = 9;
            this.btnAtualizarFuncionario.Text = "ATUALIZAR";
            this.btnAtualizarFuncionario.UseVisualStyleBackColor = false;
            this.btnAtualizarFuncionario.Click += new System.EventHandler(this.btnAtualizarFuncionario_Click);
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnNovoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnNovoFuncionario.Location = new System.Drawing.Point(688, 414);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(100, 30);
            this.btnNovoFuncionario.TabIndex = 10;
            this.btnNovoFuncionario.Text = "NOVO";
            this.btnNovoFuncionario.UseVisualStyleBackColor = false;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // btnVoltarFuncionario
            // 
            this.btnVoltarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnVoltarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnVoltarFuncionario.Location = new System.Drawing.Point(224, 414);
            this.btnVoltarFuncionario.Name = "btnVoltarFuncionario";
            this.btnVoltarFuncionario.Size = new System.Drawing.Size(100, 30);
            this.btnVoltarFuncionario.TabIndex = 11;
            this.btnVoltarFuncionario.Text = "VOLTAR";
            this.btnVoltarFuncionario.UseVisualStyleBackColor = false;
            this.btnVoltarFuncionario.Click += new System.EventHandler(this.btnVoltarFuncionario_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(299, 418);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 12;
            // 
            // MenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnVoltarFuncionario);
            this.Controls.Add(this.btnNovoFuncionario);
            this.Controls.Add(this.btnAtualizarFuncionario);
            this.Controls.Add(this.btnDeletarFuncionario);
            this.Controls.Add(this.DGVfuncionario);
            this.Controls.Add(this.btnBuscarFuncionario);
            this.Controls.Add(this.txtCpfFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "MenuFuncionario";
            this.Text = "MenuFuncionario";
            this.Load += new System.EventHandler(this.MenuFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVfuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarFuncionario;
        public System.Windows.Forms.Button btnDeletarFuncionario;
        public System.Windows.Forms.Button btnNovoFuncionario;
        public System.Windows.Forms.Button btnVoltarFuncionario;
        public System.Windows.Forms.TextBox txtCpfFuncionario;
        private System.Windows.Forms.DataGridView DGVfuncionario;
        private System.Windows.Forms.Button btnAtualizarFuncionario;
        private System.Windows.Forms.Label lblMensagem;
    }
}