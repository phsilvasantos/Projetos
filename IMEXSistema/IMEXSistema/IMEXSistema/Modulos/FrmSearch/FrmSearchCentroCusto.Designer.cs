﻿namespace BmsSoftware.Modulos.FrmSearch
{
    partial class FrmSearchCentroCusto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchCentroCusto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGriewSearch = new System.Windows.Forms.DataGridView();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENTROCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCENTROCUSTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblObsField = new System.Windows.Forms.Label();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGriewSearch);
            this.panel1.Controls.Add(this.lblObsField);
            this.panel1.Controls.Add(this.btnCadFornecedor);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.txtNomePesquisa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 273);
            this.panel1.TabIndex = 0;
            // 
            // DataGriewSearch
            // 
            this.DataGriewSearch.AllowUserToOrderColumns = true;
            this.DataGriewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRICAO,
            this.CENTROCUSTO,
            this.IDCENTROCUSTOS});
            this.DataGriewSearch.Location = new System.Drawing.Point(12, 56);
            this.DataGriewSearch.Name = "DataGriewSearch";
            this.DataGriewSearch.ReadOnly = true;
            this.DataGriewSearch.Size = new System.Drawing.Size(587, 180);
            this.DataGriewSearch.TabIndex = 160;
            this.DataGriewSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewSearch_CellDoubleClick);
            this.DataGriewSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGriewSearch_KeyDown);
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 200;
            // 
            // CENTROCUSTO
            // 
            this.CENTROCUSTO.DataPropertyName = "CENTROCUSTO";
            this.CENTROCUSTO.HeaderText = "Centro de Custo";
            this.CENTROCUSTO.Name = "CENTROCUSTO";
            this.CENTROCUSTO.ReadOnly = true;
            this.CENTROCUSTO.Width = 200;
            // 
            // IDCENTROCUSTOS
            // 
            this.IDCENTROCUSTOS.DataPropertyName = "IDCENTROCUSTOS";
            this.IDCENTROCUSTOS.HeaderText = "Cód.";
            this.IDCENTROCUSTOS.Name = "IDCENTROCUSTOS";
            this.IDCENTROCUSTOS.ReadOnly = true;
            this.IDCENTROCUSTOS.Width = 50;
            // 
            // lblObsField
            // 
            this.lblObsField.AutoSize = true;
            this.lblObsField.ForeColor = System.Drawing.Color.Blue;
            this.lblObsField.Location = new System.Drawing.Point(12, 251);
            this.lblObsField.Name = "lblObsField";
            this.lblObsField.Size = new System.Drawing.Size(32, 13);
            this.lblObsField.TabIndex = 159;
            this.lblObsField.Text = "Obs.:";
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.FlatAppearance.BorderSize = 0;
            this.btnCadFornecedor.Location = new System.Drawing.Point(411, 30);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(26, 21);
            this.btnCadFornecedor.TabIndex = 96;
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(524, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "&Sair";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(443, 27);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(12, 30);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(393, 20);
            this.txtNomePesquisa.TabIndex = 0;
            this.txtNomePesquisa.Enter += new System.EventHandler(this.txtNomePesquisa_Enter);
            this.txtNomePesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomePesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // FrmSearchCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 273);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmSearchCentroCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Centro Custo";
            this.Load += new System.EventHandler(this.FrmSearchFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSearchFornecedor_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCadFornecedor;
        private System.Windows.Forms.Label lblObsField;
        private System.Windows.Forms.DataGridView DataGriewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENTROCUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCENTROCUSTOS;


    }
}