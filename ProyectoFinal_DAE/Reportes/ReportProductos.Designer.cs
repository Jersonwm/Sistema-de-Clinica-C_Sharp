namespace ProyectoFinal_DAE.Reportes
{
    partial class ReportProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProductos));
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCita = new ProyectoFinal_DAE.DataSetCita();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productoTableAdapter = new ProyectoFinal_DAE.DataSetCitaTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCita)).BeginInit();
            this.SuspendLayout();
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dataSetCitaBindingSource;
            // 
            // dataSetCitaBindingSource
            // 
            this.dataSetCitaBindingSource.DataSource = this.dataSetCita;
            this.dataSetCitaBindingSource.Position = 0;
            // 
            // dataSetCita
            // 
            this.dataSetCita.DataSetName = "DataSetCita";
            this.dataSetCita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal_DAE.Reportes.ImformeProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportProductos";
            this.Text = "Reporte de productos en inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetCita dataSetCita;
        private System.Windows.Forms.BindingSource dataSetCitaBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DataSetCitaTableAdapters.ProductoTableAdapter productoTableAdapter;
    }
}