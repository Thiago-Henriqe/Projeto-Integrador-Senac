
namespace T41N_DoTheEvolution
{
    partial class MenuMotoboy
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
            this.txtCNHMotoboy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarMotoboy = new System.Windows.Forms.Button();
            this.DGVmotoboy = new System.Windows.Forms.DataGridView();
            this.btnDeletarMotoboy = new System.Windows.Forms.Button();
            this.btnAtualizarMotoboy = new System.Windows.Forms.Button();
            this.btnNovoMotoboy = new System.Windows.Forms.Button();
            this.btnVoltarMotoboy = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmotoboy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCNHMotoboy
            // 
            this.txtCNHMotoboy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCNHMotoboy.Location = new System.Drawing.Point(128, 16);
            this.txtCNHMotoboy.Name = "txtCNHMotoboy";
            this.txtCNHMotoboy.Size = new System.Drawing.Size(328, 23);
            this.txtCNHMotoboy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME/CNH:";
            // 
            // btnBuscarMotoboy
            // 
            this.btnBuscarMotoboy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnBuscarMotoboy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarMotoboy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarMotoboy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnBuscarMotoboy.Location = new System.Drawing.Point(462, 10);
            this.btnBuscarMotoboy.Name = "btnBuscarMotoboy";
            this.btnBuscarMotoboy.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarMotoboy.TabIndex = 4;
            this.btnBuscarMotoboy.Text = "BUSCAR";
            this.btnBuscarMotoboy.UseVisualStyleBackColor = false;
            this.btnBuscarMotoboy.Click += new System.EventHandler(this.btnBuscarMotoboy_Click);
            // 
            // DGVmotoboy
            // 
            this.DGVmotoboy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.DGVmotoboy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmotoboy.Location = new System.Drawing.Point(12, 59);
            this.DGVmotoboy.Name = "DGVmotoboy";
            this.DGVmotoboy.RowTemplate.Height = 25;
            this.DGVmotoboy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVmotoboy.Size = new System.Drawing.Size(776, 333);
            this.DGVmotoboy.TabIndex = 5;
            this.DGVmotoboy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMotoboy_CellClick);
            // 
            // btnDeletarMotoboy
            // 
            this.btnDeletarMotoboy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnDeletarMotoboy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarMotoboy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarMotoboy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnDeletarMotoboy.Location = new System.Drawing.Point(12, 414);
            this.btnDeletarMotoboy.Name = "btnDeletarMotoboy";
            this.btnDeletarMotoboy.Size = new System.Drawing.Size(100, 30);
            this.btnDeletarMotoboy.TabIndex = 6;
            this.btnDeletarMotoboy.Text = "DELETAR";
            this.btnDeletarMotoboy.UseVisualStyleBackColor = false;
            this.btnDeletarMotoboy.Click += new System.EventHandler(this.btnDeletarMotoboy_Click);
            // 
            // btnAtualizarMotoboy
            // 
            this.btnAtualizarMotoboy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnAtualizarMotoboy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarMotoboy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarMotoboy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnAtualizarMotoboy.Location = new System.Drawing.Point(118, 414);
            this.btnAtualizarMotoboy.Name = "btnAtualizarMotoboy";
            this.btnAtualizarMotoboy.Size = new System.Drawing.Size(100, 30);
            this.btnAtualizarMotoboy.TabIndex = 7;
            this.btnAtualizarMotoboy.Text = "ATUALIZAR";
            this.btnAtualizarMotoboy.UseVisualStyleBackColor = false;
            this.btnAtualizarMotoboy.Click += new System.EventHandler(this.btnAtualizarMotoboy_Click);
            // 
            // btnNovoMotoboy
            // 
            this.btnNovoMotoboy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnNovoMotoboy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoMotoboy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoMotoboy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnNovoMotoboy.Location = new System.Drawing.Point(688, 414);
            this.btnNovoMotoboy.Name = "btnNovoMotoboy";
            this.btnNovoMotoboy.Size = new System.Drawing.Size(100, 30);
            this.btnNovoMotoboy.TabIndex = 8;
            this.btnNovoMotoboy.Text = "NOVO";
            this.btnNovoMotoboy.UseVisualStyleBackColor = false;
            this.btnNovoMotoboy.Click += new System.EventHandler(this.btnNovoMotoboy_Click);
            // 
            // btnVoltarMotoboy
            // 
            this.btnVoltarMotoboy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnVoltarMotoboy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarMotoboy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarMotoboy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnVoltarMotoboy.Location = new System.Drawing.Point(224, 414);
            this.btnVoltarMotoboy.Name = "btnVoltarMotoboy";
            this.btnVoltarMotoboy.Size = new System.Drawing.Size(100, 30);
            this.btnVoltarMotoboy.TabIndex = 9;
            this.btnVoltarMotoboy.Text = "VOLTAR";
            this.btnVoltarMotoboy.UseVisualStyleBackColor = false;
            this.btnVoltarMotoboy.Click += new System.EventHandler(this.btnVoltarMotoboy_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(291, 419);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 10;
            // 
            // MenuMotoboy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnVoltarMotoboy);
            this.Controls.Add(this.btnNovoMotoboy);
            this.Controls.Add(this.btnAtualizarMotoboy);
            this.Controls.Add(this.btnDeletarMotoboy);
            this.Controls.Add(this.DGVmotoboy);
            this.Controls.Add(this.btnBuscarMotoboy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNHMotoboy);
            this.Name = "MenuMotoboy";
            this.Text = "MenuMotoboy";
            this.Load += new System.EventHandler(this.MenuMotoboy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmotoboy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCNHMotoboy;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarMotoboy;
        private System.Windows.Forms.DataGridView DGVmotoboy;
        public System.Windows.Forms.Button btnDeletarMotoboy;
        public System.Windows.Forms.Button btnNovoMotoboy;
        public System.Windows.Forms.Button btnVoltarMotoboy;
        private System.Windows.Forms.Button btnAtualizarMotoboy;
        private System.Windows.Forms.Label lblMensagem;
    }
}