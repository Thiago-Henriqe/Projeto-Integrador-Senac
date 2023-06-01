
namespace T41N_DoTheEvolution
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CORRIDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarMotoboyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emAndamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FUNCIONARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MOTOBOYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RELATORIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STATUS = new System.Windows.Forms.Label();
            this.eNTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CORRIDASToolStripMenuItem,
            this.FUNCIONARIOSToolStripMenuItem,
            this.MOTOBOYSToolStripMenuItem,
            this.CLIENTESToolStripMenuItem,
            this.RELATORIOToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 67);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // CORRIDASToolStripMenuItem
            // 
            this.CORRIDASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecionarMotoboyToolStripMenuItem,
            this.emAndamentoToolStripMenuItem});
            this.CORRIDASToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CORRIDASToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.CORRIDASToolStripMenuItem.Name = "CORRIDASToolStripMenuItem";
            this.CORRIDASToolStripMenuItem.Size = new System.Drawing.Size(126, 63);
            this.CORRIDASToolStripMenuItem.Text = "CORRIDAS";
            this.CORRIDASToolStripMenuItem.Visible = false;
            // 
            // selecionarMotoboyToolStripMenuItem
            // 
            this.selecionarMotoboyToolStripMenuItem.Name = "selecionarMotoboyToolStripMenuItem";
            this.selecionarMotoboyToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.selecionarMotoboyToolStripMenuItem.Text = "Selecionar Motoboy";
            this.selecionarMotoboyToolStripMenuItem.Click += new System.EventHandler(this.selecionarMotoboyToolStripMenuItem_Click);
            // 
            // emAndamentoToolStripMenuItem
            // 
            this.emAndamentoToolStripMenuItem.Name = "emAndamentoToolStripMenuItem";
            this.emAndamentoToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.emAndamentoToolStripMenuItem.Text = "Em Andamento";
            this.emAndamentoToolStripMenuItem.Click += new System.EventHandler(this.emAndamentoToolStripMenuItem_Click);
            // 
            // FUNCIONARIOSToolStripMenuItem
            // 
            this.FUNCIONARIOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FUNCIONARIOSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.FUNCIONARIOSToolStripMenuItem.Name = "FUNCIONARIOSToolStripMenuItem";
            this.FUNCIONARIOSToolStripMenuItem.Size = new System.Drawing.Size(178, 63);
            this.FUNCIONARIOSToolStripMenuItem.Text = "FUNCIONARIOS";
            this.FUNCIONARIOSToolStripMenuItem.Visible = false;
            this.FUNCIONARIOSToolStripMenuItem.Click += new System.EventHandler(this.fUNCIONARIOSToolStripMenuItem_Click);
            // 
            // MOTOBOYSToolStripMenuItem
            // 
            this.MOTOBOYSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MOTOBOYSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.MOTOBOYSToolStripMenuItem.Name = "MOTOBOYSToolStripMenuItem";
            this.MOTOBOYSToolStripMenuItem.Size = new System.Drawing.Size(138, 63);
            this.MOTOBOYSToolStripMenuItem.Text = "MOTOBOYS";
            this.MOTOBOYSToolStripMenuItem.Visible = false;
            this.MOTOBOYSToolStripMenuItem.Click += new System.EventHandler(this.mOTOBOYSToolStripMenuItem_Click);
            // 
            // CLIENTESToolStripMenuItem
            // 
            this.CLIENTESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CLIENTESToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem";
            this.CLIENTESToolStripMenuItem.Size = new System.Drawing.Size(115, 63);
            this.CLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.CLIENTESToolStripMenuItem.Visible = false;
            this.CLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // RELATORIOToolStripMenuItem
            // 
            this.RELATORIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.RELATORIOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RELATORIOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(123)))), ((int)(((byte)(41)))));
            this.RELATORIOToolStripMenuItem.Name = "RELATORIOToolStripMenuItem";
            this.RELATORIOToolStripMenuItem.Size = new System.Drawing.Size(146, 63);
            this.RELATORIOToolStripMenuItem.Text = "RELATORIOS";
            this.RELATORIOToolStripMenuItem.Visible = false;
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogarToolStripMenuItem,
            this.eNTRARToolStripMenuItem});
            this.lOGINToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lOGINToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(97, 63);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Visible = false;
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // STATUS
            // 
            this.STATUS.AutoSize = true;
            this.STATUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.STATUS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.STATUS.Location = new System.Drawing.Point(1118, 29);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(22, 25);
            this.STATUS.TabIndex = 2;
            this.STATUS.Text = "  ";
            this.STATUS.Visible = false;
            // 
            // eNTRARToolStripMenuItem
            // 
            this.eNTRARToolStripMenuItem.Name = "eNTRARToolStripMenuItem";
            this.eNTRARToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.eNTRARToolStripMenuItem.Text = "ENTRAR";
            this.eNTRARToolStripMenuItem.Click += new System.EventHandler(this.eNTRARToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.STATUS);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selecionarMotoboyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emAndamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem CORRIDASToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem FUNCIONARIOSToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MOTOBOYSToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem CLIENTESToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem RELATORIOToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        public System.Windows.Forms.Label STATUS;
        private System.Windows.Forms.ToolStripMenuItem eNTRARToolStripMenuItem;
    }
}

