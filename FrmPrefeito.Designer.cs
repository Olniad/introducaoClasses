namespace introducaoClasses_09
{
    partial class FrmPrefeito
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDtNascimento = new System.Windows.Forms.TextBox();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblRuaAV = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtrRuaAV = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmPrefeito = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(445, 211);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(287, 20);
            this.txtDtNascimento.TabIndex = 71;
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(442, 195);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(95, 13);
            this.lblDtNascimento.TabIndex = 70;
            this.lblDtNascimento.Text = "Dt. de Nascimento";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(445, 169);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(287, 20);
            this.txtPais.TabIndex = 69;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(445, 76);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(287, 20);
            this.txtCidade.TabIndex = 68;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(442, 149);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 67;
            this.lblPais.Text = "País";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(442, 107);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 66;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(442, 60);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 65;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(30, 288);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 64;
            this.lblBairro.Text = "Bairro";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(30, 239);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 63;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblRuaAV
            // 
            this.lblRuaAV.AutoSize = true;
            this.lblRuaAV.Location = new System.Drawing.Point(30, 195);
            this.lblRuaAV.Name = "lblRuaAV";
            this.lblRuaAV.Size = new System.Drawing.Size(45, 13);
            this.lblRuaAV.TabIndex = 62;
            this.lblRuaAV.Text = "Rua/Av";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(30, 153);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 61;
            this.lblCEP.Text = "CEP";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(30, 107);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 60;
            this.lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 59;
            this.lblNome.Text = "Nome";
            // 
            // txtrRuaAV
            // 
            this.txtrRuaAV.Location = new System.Drawing.Point(33, 211);
            this.txtrRuaAV.Name = "txtrRuaAV";
            this.txtrRuaAV.Size = new System.Drawing.Size(276, 20);
            this.txtrRuaAV.TabIndex = 58;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(33, 255);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(276, 20);
            this.txtComplemento.TabIndex = 57;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(33, 304);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(276, 20);
            this.txtBairro.TabIndex = 56;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(445, 123);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(287, 20);
            this.txtEstado.TabIndex = 55;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(33, 123);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(276, 20);
            this.txtCPF.TabIndex = 54;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(33, 169);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(276, 20);
            this.txtCEP.TabIndex = 53;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(33, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 36);
            this.button2.TabIndex = 50;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 72;
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
            // FrmPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtDtNascimento);
            this.Controls.Add(this.lblDtNascimento);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblRuaAV);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtrRuaAV);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "FrmPrefeito";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDtNascimento;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblRuaAV;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtrRuaAV;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmPrefeito;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmAlimento;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmLoja;
    }
}

