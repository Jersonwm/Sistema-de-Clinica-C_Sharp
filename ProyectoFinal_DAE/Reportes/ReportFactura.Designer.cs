namespace ProyectoFinal_DAE.Reportes
{
    partial class ReportFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetCita = new ProyectoFinal_DAE.DataSetCita();
            this.detalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleFacturaTableAdapter = new ProyectoFinal_DAE.DataSetCitaTableAdapters.DetalleFacturaTableAdapter();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new ProyectoFinal_DAE.DataSetCitaTableAdapters.FacturaTableAdapter();
            this.totalPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalPagarTableAdapter = new ProyectoFinal_DAE.DataSetCitaTableAdapters.TotalPagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.detalleFacturaBindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.facturaBindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.totalPagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal_DAE.Reportes.ImformeFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetCita
            // 
            this.dataSetCita.DataSetName = "DataSetCita";
            this.dataSetCita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleFacturaBindingSource
            // 
            this.detalleFacturaBindingSource.DataMember = "DetalleFactura";
            this.detalleFacturaBindingSource.DataSource = this.dataSetCita;
            // 
            // detalleFacturaTableAdapter
            // 
            this.detalleFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.dataSetCita;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // totalPagarBindingSource
            // 
            this.totalPagarBindingSource.DataMember = "TotalPagar";
            this.totalPagarBindingSource.DataSource = this.dataSetCita;
            // 
            // totalPagarTableAdapter
            // 
            this.totalPagarTableAdapter.ClearBeforeFill = true;
            // 
            // ReportFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.ReportFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetCita dataSetCita;
        private System.Windows.Forms.BindingSource detalleFacturaBindingSource;
        private DataSetCitaTableAdapters.DetalleFacturaTableAdapter detalleFacturaTableAdapter;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private DataSetCitaTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.BindingSource totalPagarBindingSource;
        private DataSetCitaTableAdapters.TotalPagarTableAdapter totalPagarTableAdapter;
    }
}