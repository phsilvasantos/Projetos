﻿namespace BmsSoftware.Modulos.Relatorio
{
    partial class FrmCapaCarnecs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EMPRESACollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARQUIVOBINARIOCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESACollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARQUIVOBINARIOCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EMPRESACollectionBindingSource
            // 
            this.EMPRESACollectionBindingSource.DataMember = "EMPRESACollection";
            // 
            // ARQUIVOBINARIOCollectionBindingSource
            // 
            this.ARQUIVOBINARIOCollectionBindingSource.DataMember = "ARQUIVOBINARIOCollection";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EMPRESACollectionBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ARQUIVOBINARIOCollectionBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BmsSoftware.Modulos.Relatorio.CapaCarnePagamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmCapaCarnecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 437);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmCapaCarnecs";
            this.Text = "Capa do Carnê de Pagamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCapaCarnecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESACollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARQUIVOBINARIOCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EMPRESACollectionBindingSource;
        private System.Windows.Forms.BindingSource ARQUIVOBINARIOCollectionBindingSource;
    }
}