namespace ProjetoLocateCar
{
    partial class frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVeículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.locarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desalocarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClienteToolStripMenuItem,
            this.cadastroDeVeículoToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.controleDeAcessoToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(846, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            this.cadastroDeClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClienteToolStripMenuItem1});
            this.cadastroDeClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeClienteToolStripMenuItem.Image")));
            this.cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            this.cadastroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(105, 34);
            this.cadastroDeClienteToolStripMenuItem.Text = "Cliente";
            this.cadastroDeClienteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cadastroDeClienteToolStripMenuItem1
            // 
            this.cadastroDeClienteToolStripMenuItem1.Name = "cadastroDeClienteToolStripMenuItem1";
            this.cadastroDeClienteToolStripMenuItem1.Size = new System.Drawing.Size(264, 34);
            this.cadastroDeClienteToolStripMenuItem1.Text = "Cadastro de cliente";
            this.cadastroDeClienteToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeClienteToolStripMenuItem1_Click);
            // 
            // cadastroDeVeículoToolStripMenuItem
            // 
            this.cadastroDeVeículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeVeículoToolStripMenuItem1,
            this.locarVeículoToolStripMenuItem,
            this.desalocarVeículoToolStripMenuItem});
            this.cadastroDeVeículoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeVeículoToolStripMenuItem.Image")));
            this.cadastroDeVeículoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeVeículoToolStripMenuItem.Name = "cadastroDeVeículoToolStripMenuItem";
            this.cadastroDeVeículoToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cadastroDeVeículoToolStripMenuItem.Size = new System.Drawing.Size(108, 34);
            this.cadastroDeVeículoToolStripMenuItem.Text = "Veículo";
            // 
            // cadastroDeVeículoToolStripMenuItem1
            // 
            this.cadastroDeVeículoToolStripMenuItem1.Name = "cadastroDeVeículoToolStripMenuItem1";
            this.cadastroDeVeículoToolStripMenuItem1.Size = new System.Drawing.Size(306, 34);
            this.cadastroDeVeículoToolStripMenuItem1.Text = "Cadastro de veículo";
            this.cadastroDeVeículoToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeVeículoToolStripMenuItem1_Click);
            // 
            // locarVeículoToolStripMenuItem
            // 
            this.locarVeículoToolStripMenuItem.Name = "locarVeículoToolStripMenuItem";
            this.locarVeículoToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.locarVeículoToolStripMenuItem.Text = "Alugar/Comprar veículo";
            this.locarVeículoToolStripMenuItem.Click += new System.EventHandler(this.locarVeículoToolStripMenuItem_Click);
            // 
            // desalocarVeículoToolStripMenuItem
            // 
            this.desalocarVeículoToolStripMenuItem.Name = "desalocarVeículoToolStripMenuItem";
            this.desalocarVeículoToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.desalocarVeículoToolStripMenuItem.Text = "Devolver veículo";
            this.desalocarVeículoToolStripMenuItem.Click += new System.EventHandler(this.desalocarVeículoToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.fornecedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedorToolStripMenuItem.Image")));
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(145, 34);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.cadastroToolStripMenuItem.Text = "Cadastro de fornecedor";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // controleDeAcessoToolStripMenuItem
            // 
            this.controleDeAcessoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controleDeAcessoToolStripMenuItem.Image")));
            this.controleDeAcessoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.controleDeAcessoToolStripMenuItem.Name = "controleDeAcessoToolStripMenuItem";
            this.controleDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.controleDeAcessoToolStripMenuItem.Text = "Controle de acesso";
            this.controleDeAcessoToolStripMenuItem.Click += new System.EventHandler(this.controleDeAcessoToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backupToolStripMenuItem.Image")));
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(108, 34);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 111);
            this.label1.TabIndex = 8;
            this.label1.Text = "Potencial Cars";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(21, 252);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1255, 641);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 87);
            this.button3.TabIndex = 33;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(285, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 57);
            this.label2.TabIndex = 8;
            this.label2.Text = "Venda e aluguel de carros";
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmprincipal";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVeículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem locarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desalocarVeículoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem controleDeAcessoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
    }
}