﻿namespace BmsSoftware.Modulos.Servicos
{
    partial class FrmProdutoVendaCidadeNFe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoVendaCidadeNFe));
            this.DataGriewDados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntDateSelecFinal = new System.Windows.Forms.Button();
            this.bntDateSelecInicial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.msktDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msktDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTransportador = new System.Windows.Forms.ComboBox();
            this.txtCidade1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkNFeEnviada = new System.Windows.Forms.CheckBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkAgruparProduto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGriewDados
            // 
            this.DataGriewDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGriewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column2});
            this.DataGriewDados.Location = new System.Drawing.Point(12, 214);
            this.DataGriewDados.Name = "DataGriewDados";
            this.DataGriewDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGriewDados.Size = new System.Drawing.Size(918, 344);
            this.DataGriewDados.TabIndex = 273;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 500;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(94, 185);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 274;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(175, 185);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 275;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 277;
            this.label9.Text = "Vendedor:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(15, 69);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(395, 21);
            this.cbFuncionario.TabIndex = 276;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntDateSelecFinal);
            this.groupBox1.Controls.Add(this.bntDateSelecInicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.msktDataFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msktDataInicial);
            this.groupBox1.Location = new System.Drawing.Point(428, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 70);
            this.groupBox1.TabIndex = 278;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // bntDateSelecFinal
            // 
            this.bntDateSelecFinal.FlatAppearance.BorderSize = 0;
            this.bntDateSelecFinal.Location = new System.Drawing.Point(228, 34);
            this.bntDateSelecFinal.Name = "bntDateSelecFinal";
            this.bntDateSelecFinal.Size = new System.Drawing.Size(26, 21);
            this.bntDateSelecFinal.TabIndex = 179;
            this.bntDateSelecFinal.UseVisualStyleBackColor = true;
            this.bntDateSelecFinal.Click += new System.EventHandler(this.bntDateSelecFinal_Click);
            // 
            // bntDateSelecInicial
            // 
            this.bntDateSelecInicial.FlatAppearance.BorderSize = 0;
            this.bntDateSelecInicial.Location = new System.Drawing.Point(109, 34);
            this.bntDateSelecInicial.Name = "bntDateSelecInicial";
            this.bntDateSelecInicial.Size = new System.Drawing.Size(26, 21);
            this.bntDateSelecInicial.TabIndex = 178;
            this.bntDateSelecInicial.UseVisualStyleBackColor = true;
            this.bntDateSelecInicial.Click += new System.EventHandler(this.bntDateSelecInicial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 177;
            this.label1.Text = "Final";
            // 
            // msktDataFinal
            // 
            this.msktDataFinal.Location = new System.Drawing.Point(143, 35);
            this.msktDataFinal.Mask = "00/00/0000";
            this.msktDataFinal.Name = "msktDataFinal";
            this.msktDataFinal.Size = new System.Drawing.Size(79, 20);
            this.msktDataFinal.TabIndex = 176;
            this.msktDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 175;
            this.label4.Text = "Inicial:";
            // 
            // msktDataInicial
            // 
            this.msktDataInicial.Location = new System.Drawing.Point(24, 35);
            this.msktDataInicial.Mask = "00/00/0000";
            this.msktDataInicial.Name = "msktDataInicial";
            this.msktDataInicial.Size = new System.Drawing.Size(79, 20);
            this.msktDataInicial.TabIndex = 174;
            this.msktDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(13, 185);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 279;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(15, 108);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(395, 21);
            this.cbStatus.TabIndex = 281;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 282;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 284;
            this.label2.Text = "Transportador:";
            // 
            // cbTransportador
            // 
            this.cbTransportador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTransportador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTransportador.FormattingEnabled = true;
            this.cbTransportador.Location = new System.Drawing.Point(15, 25);
            this.cbTransportador.Name = "cbTransportador";
            this.cbTransportador.Size = new System.Drawing.Size(395, 21);
            this.cbTransportador.TabIndex = 283;
            // 
            // txtCidade1
            // 
            this.txtCidade1.Location = new System.Drawing.Point(428, 110);
            this.txtCidade1.MaxLength = 100;
            this.txtCidade1.Name = "txtCidade1";
            this.txtCidade1.ReadOnly = true;
            this.txtCidade1.Size = new System.Drawing.Size(502, 20);
            this.txtCidade1.TabIndex = 285;
            this.txtCidade1.Enter += new System.EventHandler(this.txtCidade1_Enter);
            this.txtCidade1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCidade1_MouseDoubleClick);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(425, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 286;
            this.label27.Text = "Cidade/UF:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(807, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 13);
            this.linkLabel1.TabIndex = 287;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpar Dados da Cidade";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkNFeEnviada
            // 
            this.chkNFeEnviada.AutoSize = true;
            this.chkNFeEnviada.Checked = true;
            this.chkNFeEnviada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNFeEnviada.Location = new System.Drawing.Point(426, 189);
            this.chkNFeEnviada.Name = "chkNFeEnviada";
            this.chkNFeEnviada.Size = new System.Drawing.Size(133, 17);
            this.chkNFeEnviada.TabIndex = 288;
            this.chkNFeEnviada.Text = "Somente NFe Enviada";
            this.chkNFeEnviada.UseVisualStyleBackColor = true;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(15, 148);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(395, 21);
            this.cbProduto.TabIndex = 289;
            this.cbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbProduto_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 290;
            this.label14.Text = "Produtos:";
            // 
            // chkAgruparProduto
            // 
            this.chkAgruparProduto.AutoSize = true;
            this.chkAgruparProduto.Checked = true;
            this.chkAgruparProduto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAgruparProduto.Location = new System.Drawing.Point(565, 189);
            this.chkAgruparProduto.Name = "chkAgruparProduto";
            this.chkAgruparProduto.Size = new System.Drawing.Size(121, 17);
            this.chkAgruparProduto.TabIndex = 291;
            this.chkAgruparProduto.Text = "Agrupar por Produto";
            this.chkAgruparProduto.UseVisualStyleBackColor = true;
            // 
            // FrmProdutoVendaCidadeNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 570);
            this.Controls.Add(this.chkAgruparProduto);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chkNFeEnviada);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtCidade1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTransportador);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.DataGriewDados);
            this.Name = "FrmProdutoVendaCidadeNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas de Produtos por Cidade -  NFe";
            this.Load += new System.EventHandler(this.FrmListaServicoProdEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGriewDados;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktDataInicial;
        private System.Windows.Forms.Button bntDateSelecFinal;
        private System.Windows.Forms.Button bntDateSelecInicial;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTransportador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtCidade1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkNFeEnviada;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkAgruparProduto;
    }
}