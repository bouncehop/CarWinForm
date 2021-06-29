namespace RRCAGApp
{
    partial class CarWashEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCarWashSubtotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCarWashPST = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCarWashGST = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCarWashTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msCarWashFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package:";
            // 
            // cboPackage
            // 
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(38, 85);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(180, 24);
            this.cboPackage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fragrance:";
            // 
            // cboFragrance
            // 
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Location = new System.Drawing.Point(259, 85);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(180, 24);
            this.cboFragrance.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstExterior);
            this.groupBox1.Controls.Add(this.lstInterior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 225);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // lstExterior
            // 
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.ItemHeight = 16;
            this.lstExterior.Location = new System.Drawing.Point(241, 66);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExterior.Size = new System.Drawing.Size(180, 116);
            this.lstExterior.TabIndex = 3;
            this.lstExterior.TabStop = false;
            // 
            // lstInterior
            // 
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.ItemHeight = 16;
            this.lstInterior.Location = new System.Drawing.Point(20, 66);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstInterior.Size = new System.Drawing.Size(180, 116);
            this.lstInterior.TabIndex = 2;
            this.lstInterior.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Exterior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interior:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Subtotal:";
            // 
            // lblCarWashSubtotal
            // 
            this.lblCarWashSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashSubtotal.Location = new System.Drawing.Point(358, 380);
            this.lblCarWashSubtotal.Name = "lblCarWashSubtotal";
            this.lblCarWashSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblCarWashSubtotal.TabIndex = 6;
            this.lblCarWashSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "PST:";
            // 
            // lblCarWashPST
            // 
            this.lblCarWashPST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashPST.Location = new System.Drawing.Point(358, 412);
            this.lblCarWashPST.Name = "lblCarWashPST";
            this.lblCarWashPST.Size = new System.Drawing.Size(100, 23);
            this.lblCarWashPST.TabIndex = 8;
            this.lblCarWashPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "GST:";
            // 
            // lblCarWashGST
            // 
            this.lblCarWashGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashGST.Location = new System.Drawing.Point(358, 444);
            this.lblCarWashGST.Name = "lblCarWashGST";
            this.lblCarWashGST.Size = new System.Drawing.Size(100, 23);
            this.lblCarWashGST.TabIndex = 10;
            this.lblCarWashGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total:";
            // 
            // lblCarWashTotal
            // 
            this.lblCarWashTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCarWashTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashTotal.Location = new System.Drawing.Point(358, 476);
            this.lblCarWashTotal.Name = "lblCarWashTotal";
            this.lblCarWashTotal.Size = new System.Drawing.Size(100, 23);
            this.lblCarWashTotal.TabIndex = 12;
            this.lblCarWashTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCarWashFileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msCarWashFileMenu
            // 
            this.msCarWashFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileGenerateInvoice,
            this.mnuFileExit});
            this.msCarWashFileMenu.Name = "msCarWashFileMenu";
            this.msCarWashFileMenu.Size = new System.Drawing.Size(46, 24);
            this.msCarWashFileMenu.Text = "&File";
            // 
            // mnuFileGenerateInvoice
            // 
            this.mnuFileGenerateInvoice.Enabled = false;
            this.mnuFileGenerateInvoice.Name = "mnuFileGenerateInvoice";
            this.mnuFileGenerateInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuFileGenerateInvoice.Size = new System.Drawing.Size(289, 26);
            this.mnuFileGenerateInvoice.Text = "Generate &Invoice";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(289, 26);
            this.mnuFileExit.Text = "&Exit";
            // 
            // CarWashEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 528);
            this.Controls.Add(this.lblCarWashTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCarWashGST);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCarWashPST);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCarWashSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CarWashEntryForm";
            this.ShowIcon = false;
            this.Text = "Car Wash";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCarWashSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCarWashPST;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCarWashGST;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCarWashTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msCarWashFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFileGenerateInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    }
}