namespace TransportFinderClient
{
    partial class TransportFinderView
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.chbSpecifyTime = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.grbLocation = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.cmbDestinationLocation = new System.Windows.Forms.ComboBox();
            this.ltvConnections = new System.Windows.Forms.ListView();
            this.clmAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmShare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTime.SuspendLayout();
            this.grbLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(535, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 33);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // grbTime
            // 
            this.grbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTime.Controls.Add(this.chbSpecifyTime);
            this.grbTime.Controls.Add(this.dtpTime);
            this.grbTime.Location = new System.Drawing.Point(39, 113);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(308, 72);
            this.grbTime.TabIndex = 12;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Time";
            // 
            // chbSpecifyTime
            // 
            this.chbSpecifyTime.AutoSize = true;
            this.chbSpecifyTime.Location = new System.Drawing.Point(12, 31);
            this.chbSpecifyTime.Name = "chbSpecifyTime";
            this.chbSpecifyTime.Size = new System.Drawing.Size(115, 21);
            this.chbSpecifyTime.TabIndex = 9;
            this.chbSpecifyTime.Text = "Specify Time:";
            this.chbSpecifyTime.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(147, 31);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(139, 22);
            this.dtpTime.TabIndex = 6;
            // 
            // grbLocation
            // 
            this.grbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocation.Controls.Add(this.button1);
            this.grbLocation.Controls.Add(this.btnSearch);
            this.grbLocation.Controls.Add(this.lblStartLocation);
            this.grbLocation.Controls.Add(this.cmbStartLocation);
            this.grbLocation.Controls.Add(this.cmbDestinationLocation);
            this.grbLocation.Location = new System.Drawing.Point(39, 32);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Size = new System.Drawing.Size(723, 75);
            this.grbLocation.TabIndex = 11;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "Location";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(174, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Von Hier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AbfahrtsTaffle_Click);
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.Location = new System.Drawing.Point(264, 27);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(70, 20);
            this.lblStartLocation.TabIndex = 0;
            this.lblStartLocation.Text = "Nach ->";
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(12, 29);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(156, 24);
            this.cmbStartLocation.TabIndex = 2;
            this.cmbStartLocation.TextUpdate += new System.EventHandler(this.CmbStartLocation_TextUpdate);
            // 
            // cmbDestinationLocation
            // 
            this.cmbDestinationLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDestinationLocation.FormattingEnabled = true;
            this.cmbDestinationLocation.Location = new System.Drawing.Point(340, 24);
            this.cmbDestinationLocation.Name = "cmbDestinationLocation";
            this.cmbDestinationLocation.Size = new System.Drawing.Size(189, 24);
            this.cmbDestinationLocation.TabIndex = 3;
            this.cmbDestinationLocation.TextUpdate += new System.EventHandler(this.CmbDestinationLocation_TextUpdate);
            // 
            // ltvConnections
            // 
            this.ltvConnections.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ltvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAbfahrt,
            this.clmDauer,
            this.clmAnkunft,
            this.clmShare});
            this.ltvConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvConnections.FullRowSelect = true;
            this.ltvConnections.GridLines = true;
            this.ltvConnections.HideSelection = false;
            this.ltvConnections.Location = new System.Drawing.Point(39, 191);
            this.ltvConnections.Name = "ltvConnections";
            this.ltvConnections.Size = new System.Drawing.Size(723, 228);
            this.ltvConnections.TabIndex = 10;
            this.ltvConnections.UseCompatibleStateImageBehavior = false;
            this.ltvConnections.View = System.Windows.Forms.View.Details;
            // 
            // clmAbfahrt
            // 
            this.clmAbfahrt.Text = "Abfahrt";
            this.clmAbfahrt.Width = 150;
            // 
            // clmDauer
            // 
            this.clmDauer.Text = "Dauer";
            this.clmDauer.Width = 150;
            // 
            // clmAnkunft
            // 
            this.clmAnkunft.Text = "Ankunft";
            this.clmAnkunft.Width = 150;
            // 
            // clmShare
            // 
            this.clmShare.Text = "Share";
            this.clmShare.Width = 100;
            // 
            // TransportFinderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.grbLocation);
            this.Controls.Add(this.ltvConnections);
            this.Name = "TransportFinderView";
            this.Text = "TransportFinder";
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.grbLocation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.CheckBox chbSpecifyTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.GroupBox grbLocation;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.ComboBox cmbStartLocation;
        private System.Windows.Forms.ComboBox cmbDestinationLocation;
        private System.Windows.Forms.ListView ltvConnections;
        private System.Windows.Forms.ColumnHeader clmAbfahrt;
        private System.Windows.Forms.ColumnHeader clmDauer;
        private System.Windows.Forms.ColumnHeader clmAnkunft;
        private System.Windows.Forms.ColumnHeader clmShare;
        private System.Windows.Forms.Button button1;
    }
}

