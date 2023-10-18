namespace NXT_Scan_Parser
{
    partial class Form_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenScan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools_Panel = new System.Windows.Forms.Panel();
            this.Num_Change = new System.Windows.Forms.NumericUpDown();
            this.Num_Max = new System.Windows.Forms.NumericUpDown();
            this.Num_Min = new System.Windows.Forms.NumericUpDown();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.Tools_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.SystemColors.Control;
            this.drawBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drawBox.Location = new System.Drawing.Point(0, 59);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(459, 372);
            this.drawBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawBox.TabIndex = 0;
            this.drawBox.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(459, 24);
            this.MenuStrip.TabIndex = 1;
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenScan,
            this.Menu_SaveImage});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(46, 20);
            this.Menu_File.Text = "File";
            // 
            // Menu_OpenScan
            // 
            this.Menu_OpenScan.Name = "Menu_OpenScan";
            this.Menu_OpenScan.Size = new System.Drawing.Size(174, 22);
            this.Menu_OpenScan.Text = "Open scan...";
            this.Menu_OpenScan.Click += new System.EventHandler(this.Menu_OpenScan_Click);
            // 
            // Menu_SaveImage
            // 
            this.Menu_SaveImage.Name = "Menu_SaveImage";
            this.Menu_SaveImage.Size = new System.Drawing.Size(180, 22);
            this.Menu_SaveImage.Text = "Save as image...";
            this.Menu_SaveImage.Click += new System.EventHandler(this.Menu_SaveImage_Click);
            // 
            // Tools_Panel
            // 
            this.Tools_Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Tools_Panel.Controls.Add(this.Num_Change);
            this.Tools_Panel.Controls.Add(this.Num_Max);
            this.Tools_Panel.Controls.Add(this.Num_Min);
            this.Tools_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tools_Panel.Location = new System.Drawing.Point(0, 24);
            this.Tools_Panel.Name = "Tools_Panel";
            this.Tools_Panel.Size = new System.Drawing.Size(459, 35);
            this.Tools_Panel.TabIndex = 2;
            // 
            // Num_Change
            // 
            this.Num_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Change.Location = new System.Drawing.Point(136, 5);
            this.Num_Change.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_Change.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.Num_Change.Name = "Num_Change";
            this.Num_Change.Size = new System.Drawing.Size(61, 26);
            this.Num_Change.TabIndex = 2;
            this.ToolTip.SetToolTip(this.Num_Change, "Increase/Decrease brightness of values");
            this.Num_Change.ValueChanged += new System.EventHandler(this.Num_Change_Changed);
            // 
            // Num_Max
            // 
            this.Num_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Max.Location = new System.Drawing.Point(70, 5);
            this.Num_Max.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_Max.Name = "Num_Max";
            this.Num_Max.Size = new System.Drawing.Size(61, 26);
            this.Num_Max.TabIndex = 1;
            this.ToolTip.SetToolTip(this.Num_Max, "Brightest spot (highest value)\r\nPress CTRL to overwrite other number.");
            this.Num_Max.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_Max.ValueChanged += new System.EventHandler(this.Num_Limits_Changed);
            this.Num_Max.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Num_Scrolled);
            // 
            // Num_Min
            // 
            this.Num_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Min.Location = new System.Drawing.Point(3, 5);
            this.Num_Min.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_Min.Name = "Num_Min";
            this.Num_Min.Size = new System.Drawing.Size(61, 26);
            this.Num_Min.TabIndex = 0;
            this.ToolTip.SetToolTip(this.Num_Min, "Darkest spot (smallest value)\r\nPress CTRL to overwrite other number." +
        "");
            this.Num_Min.ValueChanged += new System.EventHandler(this.Num_Limits_Changed);
            this.Num_Min.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Num_Scrolled);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 10000;
            this.ToolTip.BackColor = System.Drawing.SystemColors.Window;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.ReshowDelay = 100;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 431);
            this.Controls.Add(this.Tools_Panel);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form_Main";
            this.Text = "NXT Scan Parser";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Resize += new System.EventHandler(this.Form_Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Tools_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenScan;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveImage;
        private System.Windows.Forms.Panel Tools_Panel;
        private System.Windows.Forms.NumericUpDown Num_Max;
        private System.Windows.Forms.NumericUpDown Num_Min;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.NumericUpDown Num_Change;
    }
}

