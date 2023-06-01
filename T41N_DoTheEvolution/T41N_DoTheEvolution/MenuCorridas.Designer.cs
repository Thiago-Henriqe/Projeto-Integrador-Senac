
namespace T41N_DoTheEvolution
{
    partial class MenuCorridas
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
            this.btnEditarCorrida = new System.Windows.Forms.Button();
            this.btnFinalizarCorrida = new System.Windows.Forms.Button();
            this.btnExcluirCorrida = new System.Windows.Forms.Button();
            this.DGVcorridas = new System.Windows.Forms.DataGridView();
            this.btnBuscarSolicitante = new System.Windows.Forms.Button();
            this.txtSolicitanteCorrida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCorrida = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcorridas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarCorrida
            // 
            this.btnEditarCorrida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnEditarCorrida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCorrida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnEditarCorrida.Location = new System.Drawing.Point(12, 410);
            this.btnEditarCorrida.Name = "btnEditarCorrida";
            this.btnEditarCorrida.Size = new System.Drawing.Size(154, 30);
            this.btnEditarCorrida.TabIndex = 20;
            this.btnEditarCorrida.Text = "EDITAR/SELECIONAR";
            this.btnEditarCorrida.UseVisualStyleBackColor = false;
            this.btnEditarCorrida.Click += new System.EventHandler(this.btnEditarCorrida_Click);
            // 
            // btnFinalizarCorrida
            // 
            this.btnFinalizarCorrida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnFinalizarCorrida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarCorrida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnFinalizarCorrida.Location = new System.Drawing.Point(278, 410);
            this.btnFinalizarCorrida.Name = "btnFinalizarCorrida";
            this.btnFinalizarCorrida.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizarCorrida.TabIndex = 19;
            this.btnFinalizarCorrida.Text = "FINALIZAR";
            this.btnFinalizarCorrida.UseVisualStyleBackColor = false;
            this.btnFinalizarCorrida.Click += new System.EventHandler(this.btnFinalizarCorrida_Click);
            // 
            // btnExcluirCorrida
            // 
            this.btnExcluirCorrida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnExcluirCorrida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCorrida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnExcluirCorrida.Location = new System.Drawing.Point(172, 410);
            this.btnExcluirCorrida.Name = "btnExcluirCorrida";
            this.btnExcluirCorrida.Size = new System.Drawing.Size(100, 30);
            this.btnExcluirCorrida.TabIndex = 18;
            this.btnExcluirCorrida.Text = "EXCLUIR";
            this.btnExcluirCorrida.UseVisualStyleBackColor = false;
            this.btnExcluirCorrida.Click += new System.EventHandler(this.btnExcluirCorrida_Click);
            // 
            // DGVcorridas
            // 
            this.DGVcorridas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.DGVcorridas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcorridas.Location = new System.Drawing.Point(12, 55);
            this.DGVcorridas.Name = "DGVcorridas";
            this.DGVcorridas.RowTemplate.Height = 25;
            this.DGVcorridas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcorridas.Size = new System.Drawing.Size(776, 333);
            this.DGVcorridas.TabIndex = 17;
            this.DGVcorridas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcorridas_CellClick);
            // 
            // btnBuscarSolicitante
            // 
            this.btnBuscarSolicitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnBuscarSolicitante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarSolicitante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarSolicitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnBuscarSolicitante.Location = new System.Drawing.Point(488, 15);
            this.btnBuscarSolicitante.Name = "btnBuscarSolicitante";
            this.btnBuscarSolicitante.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarSolicitante.TabIndex = 16;
            this.btnBuscarSolicitante.Text = "BUSCAR";
            this.btnBuscarSolicitante.UseVisualStyleBackColor = false;
            this.btnBuscarSolicitante.Click += new System.EventHandler(this.btnBuscarSolicitante_Click);
            // 
            // txtSolicitanteCorrida
            // 
            this.txtSolicitanteCorrida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSolicitanteCorrida.Location = new System.Drawing.Point(154, 17);
            this.txtSolicitanteCorrida.Name = "txtSolicitanteCorrida";
            this.txtSolicitanteCorrida.Size = new System.Drawing.Size(328, 23);
            this.txtSolicitanteCorrida.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "SOLICITANTE:";
            // 
            // btnCancelarCorrida
            // 
            this.btnCancelarCorrida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnCancelarCorrida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCorrida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnCancelarCorrida.Location = new System.Drawing.Point(688, 410);
            this.btnCancelarCorrida.Name = "btnCancelarCorrida";
            this.btnCancelarCorrida.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarCorrida.TabIndex = 21;
            this.btnCancelarCorrida.Text = "CANCELAR";
            this.btnCancelarCorrida.UseVisualStyleBackColor = false;
            this.btnCancelarCorrida.Click += new System.EventHandler(this.btnCancelarCorrida_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(307, 414);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 22;
            // 
            // MenuCorridas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCancelarCorrida);
            this.Controls.Add(this.btnEditarCorrida);
            this.Controls.Add(this.btnFinalizarCorrida);
            this.Controls.Add(this.btnExcluirCorrida);
            this.Controls.Add(this.DGVcorridas);
            this.Controls.Add(this.btnBuscarSolicitante);
            this.Controls.Add(this.txtSolicitanteCorrida);
            this.Controls.Add(this.label1);
            this.Name = "MenuCorridas";
            this.Text = "MenuCorridas";
            this.Load += new System.EventHandler(this.MenuCorridas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcorridas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditarCorrida;
        public System.Windows.Forms.Button btnFinalizarCorrida;
        public System.Windows.Forms.Button btnExcluirCorrida;
        private System.Windows.Forms.DataGridView DGVcorridas;
        public System.Windows.Forms.Button btnBuscarSolicitante;
        private System.Windows.Forms.TextBox txtSolicitanteCorrida;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelarCorrida;
        private System.Windows.Forms.Label lblMensagem;
    }
}