
namespace T41N_DoTheEvolution
{
    partial class MenuRelatorio
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
            this.DGVrelatorio = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClienteRelatorio = new System.Windows.Forms.TextBox();
            this.txtMotoboyRelatorio = new System.Windows.Forms.TextBox();
            this.txtFuncionarioRelatorio = new System.Windows.Forms.TextBox();
            this.btnNovoRelatorio = new System.Windows.Forms.Button();
            this.btnImprimirRelatorio = new System.Windows.Forms.Button();
            this.btnExportarRelatorio = new System.Windows.Forms.Button();
            this.btnBuscarRelatorio = new System.Windows.Forms.Button();
            this.btnVoltarRelatorio = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.dtpPeriodoInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodoFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "RELATORIO";
            // 
            // DGVrelatorio
            // 
            this.DGVrelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.DGVrelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVrelatorio.Location = new System.Drawing.Point(388, 49);
            this.DGVrelatorio.Name = "DGVrelatorio";
            this.DGVrelatorio.RowTemplate.Height = 25;
            this.DGVrelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVrelatorio.Size = new System.Drawing.Size(609, 445);
            this.DGVrelatorio.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(25, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 320);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "INFORMACOES DOS RELATORIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(142, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "PERIODO";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(47, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(297, 70);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(57, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "De:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(199, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(73, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(45, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Funcionario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.label8.Location = new System.Drawing.Point(63, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Motoboy:";
            // 
            // txtClienteRelatorio
            // 
            this.txtClienteRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtClienteRelatorio.Location = new System.Drawing.Point(143, 290);
            this.txtClienteRelatorio.Name = "txtClienteRelatorio";
            this.txtClienteRelatorio.Size = new System.Drawing.Size(200, 23);
            this.txtClienteRelatorio.TabIndex = 24;
            // 
            // txtMotoboyRelatorio
            // 
            this.txtMotoboyRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtMotoboyRelatorio.Location = new System.Drawing.Point(142, 322);
            this.txtMotoboyRelatorio.Name = "txtMotoboyRelatorio";
            this.txtMotoboyRelatorio.Size = new System.Drawing.Size(200, 23);
            this.txtMotoboyRelatorio.TabIndex = 25;
            // 
            // txtFuncionarioRelatorio
            // 
            this.txtFuncionarioRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtFuncionarioRelatorio.Location = new System.Drawing.Point(142, 356);
            this.txtFuncionarioRelatorio.Name = "txtFuncionarioRelatorio";
            this.txtFuncionarioRelatorio.Size = new System.Drawing.Size(200, 23);
            this.txtFuncionarioRelatorio.TabIndex = 26;
            // 
            // btnNovoRelatorio
            // 
            this.btnNovoRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnNovoRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovoRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnNovoRelatorio.Location = new System.Drawing.Point(705, 509);
            this.btnNovoRelatorio.Name = "btnNovoRelatorio";
            this.btnNovoRelatorio.Size = new System.Drawing.Size(138, 28);
            this.btnNovoRelatorio.TabIndex = 35;
            this.btnNovoRelatorio.Text = "Novo Relatorio";
            this.btnNovoRelatorio.UseVisualStyleBackColor = false;
            this.btnNovoRelatorio.Click += new System.EventHandler(this.btnNovoRelatorio_Click);
            // 
            // btnImprimirRelatorio
            // 
            this.btnImprimirRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnImprimirRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImprimirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnImprimirRelatorio.Location = new System.Drawing.Point(561, 509);
            this.btnImprimirRelatorio.Name = "btnImprimirRelatorio";
            this.btnImprimirRelatorio.Size = new System.Drawing.Size(138, 28);
            this.btnImprimirRelatorio.TabIndex = 36;
            this.btnImprimirRelatorio.Text = "IMPRIMIR";
            this.btnImprimirRelatorio.UseVisualStyleBackColor = false;
            this.btnImprimirRelatorio.Click += new System.EventHandler(this.btnImprimirRelatorio_Click);
            // 
            // btnExportarRelatorio
            // 
            this.btnExportarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnExportarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportarRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnExportarRelatorio.Location = new System.Drawing.Point(226, 509);
            this.btnExportarRelatorio.Name = "btnExportarRelatorio";
            this.btnExportarRelatorio.Size = new System.Drawing.Size(138, 28);
            this.btnExportarRelatorio.TabIndex = 37;
            this.btnExportarRelatorio.Text = "Exportar";
            this.btnExportarRelatorio.UseVisualStyleBackColor = false;
            this.btnExportarRelatorio.Click += new System.EventHandler(this.btnExportarRelatorio_Click);
            // 
            // btnBuscarRelatorio
            // 
            this.btnBuscarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnBuscarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnBuscarRelatorio.Location = new System.Drawing.Point(122, 420);
            this.btnBuscarRelatorio.Name = "btnBuscarRelatorio";
            this.btnBuscarRelatorio.Size = new System.Drawing.Size(138, 28);
            this.btnBuscarRelatorio.TabIndex = 38;
            this.btnBuscarRelatorio.Text = "BUSCAR";
            this.btnBuscarRelatorio.UseVisualStyleBackColor = false;
            this.btnBuscarRelatorio.Click += new System.EventHandler(this.btnBuscarRelatorio_Click);
            // 
            // btnVoltarRelatorio
            // 
            this.btnVoltarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnVoltarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.btnVoltarRelatorio.Location = new System.Drawing.Point(25, 509);
            this.btnVoltarRelatorio.Name = "btnVoltarRelatorio";
            this.btnVoltarRelatorio.Size = new System.Drawing.Size(138, 28);
            this.btnVoltarRelatorio.TabIndex = 39;
            this.btnVoltarRelatorio.Text = "Voltar";
            this.btnVoltarRelatorio.UseVisualStyleBackColor = false;
            this.btnVoltarRelatorio.Click += new System.EventHandler(this.btnVoltarRelatorio_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(114, 76);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 40;
            // 
            // dtpPeriodoInicial
            // 
            this.dtpPeriodoInicial.CustomFormat = "";
            this.dtpPeriodoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodoInicial.Location = new System.Drawing.Point(92, 199);
            this.dtpPeriodoInicial.Name = "dtpPeriodoInicial";
            this.dtpPeriodoInicial.Size = new System.Drawing.Size(97, 23);
            this.dtpPeriodoInicial.TabIndex = 117;
            // 
            // dtpPeriodoFinal
            // 
            this.dtpPeriodoFinal.CustomFormat = "";
            this.dtpPeriodoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodoFinal.Location = new System.Drawing.Point(242, 199);
            this.dtpPeriodoFinal.Name = "dtpPeriodoFinal";
            this.dtpPeriodoFinal.Size = new System.Drawing.Size(97, 23);
            this.dtpPeriodoFinal.TabIndex = 118;
            // 
            // MenuRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 561);
            this.Controls.Add(this.dtpPeriodoFinal);
            this.Controls.Add(this.dtpPeriodoInicial);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnVoltarRelatorio);
            this.Controls.Add(this.btnBuscarRelatorio);
            this.Controls.Add(this.btnExportarRelatorio);
            this.Controls.Add(this.btnImprimirRelatorio);
            this.Controls.Add(this.btnNovoRelatorio);
            this.Controls.Add(this.txtFuncionarioRelatorio);
            this.Controls.Add(this.txtMotoboyRelatorio);
            this.Controls.Add(this.txtClienteRelatorio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DGVrelatorio);
            this.Controls.Add(this.label1);
            this.Name = "MenuRelatorio";
            this.Text = "MenuRelatorio";
            this.Load += new System.EventHandler(this.MenuRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVrelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVrelatorio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClienteRelatorio;
        private System.Windows.Forms.TextBox txtMotoboyRelatorio;
        private System.Windows.Forms.TextBox txtFuncionarioRelatorio;
        private System.Windows.Forms.Button btnNovoRelatorio;
        private System.Windows.Forms.Button btnImprimirRelatorio;
        private System.Windows.Forms.Button btnExportarRelatorio;
        private System.Windows.Forms.Button btnBuscarRelatorio;
        private System.Windows.Forms.Button btnVoltarRelatorio;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.DateTimePicker dtpPeriodoInicial;
        private System.Windows.Forms.DateTimePicker dtpPeriodoFinal;
    }
}