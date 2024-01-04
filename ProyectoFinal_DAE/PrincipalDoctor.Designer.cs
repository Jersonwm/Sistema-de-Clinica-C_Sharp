namespace ProyectoFinal_DAE
{
    partial class PrincipalDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalDoctor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasDelDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosEnInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosOfrecidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturaToolStripMenuItem,
            this.expedienteToolStripMenuItem,
            this.servicioToolStripMenuItem,
            this.informeToolStripMenuItem,
            this.generarFacturaToolStripMenuItem1,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(179, 541);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generarFacturaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarFacturaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(172, 43);
            this.generarFacturaToolStripMenuItem.Text = "Cita";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // expedienteToolStripMenuItem
            // 
            this.expedienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.expedienteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expedienteToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.expedienteToolStripMenuItem.Name = "expedienteToolStripMenuItem";
            this.expedienteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.expedienteToolStripMenuItem.Size = new System.Drawing.Size(172, 43);
            this.expedienteToolStripMenuItem.Text = "Expediente";
            this.expedienteToolStripMenuItem.Click += new System.EventHandler(this.expedienteToolStripMenuItem_Click);
            // 
            // servicioToolStripMenuItem
            // 
            this.servicioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.servicioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.servicioToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            this.servicioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.servicioToolStripMenuItem.Size = new System.Drawing.Size(172, 43);
            this.servicioToolStripMenuItem.Text = "Servicio";
            this.servicioToolStripMenuItem.Click += new System.EventHandler(this.servicioToolStripMenuItem_Click);
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.informeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasDelDíaToolStripMenuItem,
            this.productosEnInventarioToolStripMenuItem,
            this.serviciosOfrecidosToolStripMenuItem});
            this.informeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.informeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(172, 43);
            this.informeToolStripMenuItem.Text = "Informe";
            // 
            // citasDelDíaToolStripMenuItem
            // 
            this.citasDelDíaToolStripMenuItem.Name = "citasDelDíaToolStripMenuItem";
            this.citasDelDíaToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.citasDelDíaToolStripMenuItem.Text = "Citas del día";
            this.citasDelDíaToolStripMenuItem.Click += new System.EventHandler(this.citasDelDíaToolStripMenuItem_Click);
            // 
            // productosEnInventarioToolStripMenuItem
            // 
            this.productosEnInventarioToolStripMenuItem.Name = "productosEnInventarioToolStripMenuItem";
            this.productosEnInventarioToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.productosEnInventarioToolStripMenuItem.Text = "Productos en inventario";
            this.productosEnInventarioToolStripMenuItem.Click += new System.EventHandler(this.productosEnInventarioToolStripMenuItem_Click);
            // 
            // serviciosOfrecidosToolStripMenuItem
            // 
            this.serviciosOfrecidosToolStripMenuItem.Name = "serviciosOfrecidosToolStripMenuItem";
            this.serviciosOfrecidosToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.serviciosOfrecidosToolStripMenuItem.Text = "Servicios ofrecidos";
            this.serviciosOfrecidosToolStripMenuItem.Click += new System.EventHandler(this.serviciosOfrecidosToolStripMenuItem_Click);
            // 
            // generarFacturaToolStripMenuItem1
            // 
            this.generarFacturaToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generarFacturaToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarFacturaToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.generarFacturaToolStripMenuItem1.Name = "generarFacturaToolStripMenuItem1";
            this.generarFacturaToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.generarFacturaToolStripMenuItem1.Size = new System.Drawing.Size(172, 43);
            this.generarFacturaToolStripMenuItem1.Text = "Generar Factura";
            this.generarFacturaToolStripMenuItem1.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(172, 43);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(172, 43);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // PrincipalDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PrincipalDoctor";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalDoctor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem servicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasDelDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosEnInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosOfrecidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedienteToolStripMenuItem;
    }
}