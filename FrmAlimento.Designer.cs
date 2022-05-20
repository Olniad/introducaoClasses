namespace introducaoClasses_09
{
    partial class FrmAlimento
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmPrefeito = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.txtIgredientes = new System.Windows.Forms.TextBox();
            this.txtValorAumento = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIgredientes = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.lblRuaAV = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmLojaToolStripMenuItem
            // 
            this.frmLojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrmPrefeito,
            this.exibirFrmAlimento,
            this.exibirFrmLoja});
            this.frmLojaToolStripMenuItem.Name = "frmLojaToolStripMenuItem";
            this.frmLojaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.frmLojaToolStripMenuItem.Text = "Menu";
            // 
            // exibirFrmPrefeito
            // 
            this.exibirFrmPrefeito.Name = "exibirFrmPrefeito";
            this.exibirFrmPrefeito.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmPrefeito.Text = "FrmPrefeito";
            this.exibirFrmPrefeito.Click += new System.EventHandler(this.exibirFrmPrefeito_Click);
            // 
            // exibirFrmAlimento
            // 
            this.exibirFrmAlimento.Name = "exibirFrmAlimento";
            this.exibirFrmAlimento.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmAlimento.Text = "FrmAlimento";
            this.exibirFrmAlimento.Click += new System.EventHandler(this.exibirFrmAlimento_Click);
            // 
            // exibirFrmLoja
            // 
            this.exibirFrmLoja.Name = "exibirFrmLoja";
            this.exibirFrmLoja.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmLoja.Text = "FrmLoja";
            this.exibirFrmLoja.Click += new System.EventHandler(this.exibirFrmLoja_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(235, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCalorias
            // 
            this.txtCalorias.Location = new System.Drawing.Point(235, 141);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(287, 20);
            this.txtCalorias.TabIndex = 2;
            // 
            // txtIgredientes
            // 
            this.txtIgredientes.Location = new System.Drawing.Point(235, 95);
            this.txtIgredientes.Name = "txtIgredientes";
            this.txtIgredientes.Size = new System.Drawing.Size(287, 20);
            this.txtIgredientes.TabIndex = 3;
            // 
            // txtValorAumento
            // 
            this.txtValorAumento.Location = new System.Drawing.Point(235, 227);
            this.txtValorAumento.Name = "txtValorAumento";
            this.txtValorAumento.Size = new System.Drawing.Size(287, 20);
            this.txtValorAumento.TabIndex = 6;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(235, 183);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(287, 20);
            this.txtValorCompra.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(232, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblIgredientes
            // 
            this.lblIgredientes.AutoSize = true;
            this.lblIgredientes.Location = new System.Drawing.Point(232, 79);
            this.lblIgredientes.Name = "lblIgredientes";
            this.lblIgredientes.Size = new System.Drawing.Size(59, 13);
            this.lblIgredientes.TabIndex = 9;
            this.lblIgredientes.Text = "Igredientes";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(232, 125);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(44, 13);
            this.lblCalorias.TabIndex = 11;
            this.lblCalorias.Text = "Calorias";
            // 
            // lblRuaAV
            // 
            this.lblRuaAV.AutoSize = true;
            this.lblRuaAV.Location = new System.Drawing.Point(232, 167);
            this.lblRuaAV.Name = "lblRuaAV";
            this.lblRuaAV.Size = new System.Drawing.Size(84, 13);
            this.lblRuaAV.TabIndex = 13;
            this.lblRuaAV.Text = "Valor de compra";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(232, 211);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(136, 13);
            this.lblComplemento.TabIndex = 15;
            this.lblComplemento.Text = "Valor com 10% de aumento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(235, 286);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 36);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(392, 286);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 36);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblRuaAV);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.lblIgredientes);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtValorAumento);
            this.Controls.Add(this.txtIgredientes);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlimento";
            this.Text = ",";
            this.Load += new System.EventHandler(this.FrmAlimento_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.TextBox txtIgredientes;
        private System.Windows.Forms.TextBox txtValorAumento;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIgredientes;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.Label lblRuaAV;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmPrefeito;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmAlimento;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmLoja;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}