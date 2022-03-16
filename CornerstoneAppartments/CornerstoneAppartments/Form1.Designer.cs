
namespace CornerstoneAppartments
{
    partial class CornerstoneApparments
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bedroomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOneBed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTwoBed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThreeBed = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLakeView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPondView = new System.Windows.Forms.ToolStripMenuItem();
            this.bathroomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOneBath = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTwoBath = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThreeBath = new System.Windows.Forms.ToolStripMenuItem();
            this.gbViews = new System.Windows.Forms.GroupBox();
            this.radLakeView = new System.Windows.Forms.RadioButton();
            this.radPondView = new System.Windows.Forms.RadioButton();
            this.gbBedrooms = new System.Windows.Forms.GroupBox();
            this.radThreeBed = new System.Windows.Forms.RadioButton();
            this.radTwoBed = new System.Windows.Forms.RadioButton();
            this.radOneBed = new System.Windows.Forms.RadioButton();
            this.gbBathrooms = new System.Windows.Forms.GroupBox();
            this.radThreeBath = new System.Windows.Forms.RadioButton();
            this.radTwoBath = new System.Windows.Forms.RadioButton();
            this.radOneBath = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbViews.SuspendLayout();
            this.gbBedrooms.SuspendLayout();
            this.gbBathrooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bedroomsToolStripMenuItem,
            this.apartmentsToolStripMenuItem,
            this.bathroomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bedroomsToolStripMenuItem
            // 
            this.bedroomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOneBed,
            this.menuTwoBed,
            this.menuThreeBed});
            this.bedroomsToolStripMenuItem.Name = "bedroomsToolStripMenuItem";
            this.bedroomsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bedroomsToolStripMenuItem.Text = "Bedrooms";
            // 
            // menuOneBed
            // 
            this.menuOneBed.Name = "menuOneBed";
            this.menuOneBed.Size = new System.Drawing.Size(132, 22);
            this.menuOneBed.Text = "1 Bedroom";
            this.menuOneBed.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // menuTwoBed
            // 
            this.menuTwoBed.Name = "menuTwoBed";
            this.menuTwoBed.Size = new System.Drawing.Size(132, 22);
            this.menuTwoBed.Text = "2 Bedroom";
            this.menuTwoBed.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // menuThreeBed
            // 
            this.menuThreeBed.Name = "menuThreeBed";
            this.menuThreeBed.Size = new System.Drawing.Size(132, 22);
            this.menuThreeBed.Text = "3 Bedroom";
            this.menuThreeBed.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // apartmentsToolStripMenuItem
            // 
            this.apartmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLakeView,
            this.menuPondView});
            this.apartmentsToolStripMenuItem.Name = "apartmentsToolStripMenuItem";
            this.apartmentsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.apartmentsToolStripMenuItem.Text = "Apartments";
            // 
            // menuLakeView
            // 
            this.menuLakeView.Name = "menuLakeView";
            this.menuLakeView.Size = new System.Drawing.Size(130, 22);
            this.menuLakeView.Text = "Lake View";
            this.menuLakeView.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // menuPondView
            // 
            this.menuPondView.Name = "menuPondView";
            this.menuPondView.Size = new System.Drawing.Size(130, 22);
            this.menuPondView.Text = "Pond View";
            this.menuPondView.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // bathroomsToolStripMenuItem
            // 
            this.bathroomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOneBath,
            this.menuTwoBath,
            this.menuThreeBath});
            this.bathroomsToolStripMenuItem.Name = "bathroomsToolStripMenuItem";
            this.bathroomsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.bathroomsToolStripMenuItem.Text = "Bathrooms";
            // 
            // menuOneBath
            // 
            this.menuOneBath.Name = "menuOneBath";
            this.menuOneBath.Size = new System.Drawing.Size(107, 22);
            this.menuOneBath.Text = "1 Bath";
            this.menuOneBath.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // menuTwoBath
            // 
            this.menuTwoBath.Name = "menuTwoBath";
            this.menuTwoBath.Size = new System.Drawing.Size(107, 22);
            this.menuTwoBath.Text = "2 Bath";
            this.menuTwoBath.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // menuThreeBath
            // 
            this.menuThreeBath.Name = "menuThreeBath";
            this.menuThreeBath.Size = new System.Drawing.Size(107, 22);
            this.menuThreeBath.Text = "3 Bath";
            this.menuThreeBath.Click += new System.EventHandler(this.handleShowInfo);
            // 
            // gbViews
            // 
            this.gbViews.Controls.Add(this.radLakeView);
            this.gbViews.Controls.Add(this.radPondView);
            this.gbViews.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbViews.Location = new System.Drawing.Point(40, 54);
            this.gbViews.Name = "gbViews";
            this.gbViews.Size = new System.Drawing.Size(200, 100);
            this.gbViews.TabIndex = 1;
            this.gbViews.TabStop = false;
            this.gbViews.Text = "Appartment View";
            // 
            // radLakeView
            // 
            this.radLakeView.AutoSize = true;
            this.radLakeView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLakeView.Location = new System.Drawing.Point(7, 49);
            this.radLakeView.Name = "radLakeView";
            this.radLakeView.Size = new System.Drawing.Size(84, 18);
            this.radLakeView.TabIndex = 1;
            this.radLakeView.TabStop = true;
            this.radLakeView.Text = "Lake View";
            this.radLakeView.UseVisualStyleBackColor = true;
            this.radLakeView.CheckedChanged += new System.EventHandler(this.handleRentChange);
            // 
            // radPondView
            // 
            this.radPondView.AutoSize = true;
            this.radPondView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPondView.Location = new System.Drawing.Point(7, 23);
            this.radPondView.Name = "radPondView";
            this.radPondView.Size = new System.Drawing.Size(86, 18);
            this.radPondView.TabIndex = 0;
            this.radPondView.TabStop = true;
            this.radPondView.Text = "Pond View";
            this.radPondView.UseVisualStyleBackColor = true;
            this.radPondView.CheckedChanged += new System.EventHandler(this.handleRentChange);
            // 
            // gbBedrooms
            // 
            this.gbBedrooms.Controls.Add(this.radThreeBed);
            this.gbBedrooms.Controls.Add(this.radTwoBed);
            this.gbBedrooms.Controls.Add(this.radOneBed);
            this.gbBedrooms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBedrooms.Location = new System.Drawing.Point(404, 54);
            this.gbBedrooms.Name = "gbBedrooms";
            this.gbBedrooms.Size = new System.Drawing.Size(200, 100);
            this.gbBedrooms.TabIndex = 2;
            this.gbBedrooms.TabStop = false;
            this.gbBedrooms.Text = "Bedroooms";
            // 
            // radThreeBed
            // 
            this.radThreeBed.AutoSize = true;
            this.radThreeBed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radThreeBed.Location = new System.Drawing.Point(7, 75);
            this.radThreeBed.Name = "radThreeBed";
            this.radThreeBed.Size = new System.Drawing.Size(96, 18);
            this.radThreeBed.TabIndex = 2;
            this.radThreeBed.TabStop = true;
            this.radThreeBed.Text = "3 Bedrooms";
            this.radThreeBed.UseVisualStyleBackColor = true;
            this.radThreeBed.CheckedChanged += new System.EventHandler(this.handleRentChange);
            // 
            // radTwoBed
            // 
            this.radTwoBed.AutoSize = true;
            this.radTwoBed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radTwoBed.Location = new System.Drawing.Point(7, 49);
            this.radTwoBed.Name = "radTwoBed";
            this.radTwoBed.Size = new System.Drawing.Size(89, 18);
            this.radTwoBed.TabIndex = 1;
            this.radTwoBed.TabStop = true;
            this.radTwoBed.Text = "2 Bedroom";
            this.radTwoBed.UseVisualStyleBackColor = true;
            this.radTwoBed.CheckedChanged += new System.EventHandler(this.handleRentChange);
            // 
            // radOneBed
            // 
            this.radOneBed.AutoSize = true;
            this.radOneBed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radOneBed.Location = new System.Drawing.Point(7, 23);
            this.radOneBed.Name = "radOneBed";
            this.radOneBed.Size = new System.Drawing.Size(89, 18);
            this.radOneBed.TabIndex = 0;
            this.radOneBed.TabStop = true;
            this.radOneBed.Text = "1 Bedroom";
            this.radOneBed.UseVisualStyleBackColor = true;
            this.radOneBed.CheckedChanged += new System.EventHandler(this.handleRentChange);
            // 
            // gbBathrooms
            // 
            this.gbBathrooms.Controls.Add(this.radThreeBath);
            this.gbBathrooms.Controls.Add(this.radTwoBath);
            this.gbBathrooms.Controls.Add(this.radOneBath);
            this.gbBathrooms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBathrooms.Location = new System.Drawing.Point(40, 241);
            this.gbBathrooms.Name = "gbBathrooms";
            this.gbBathrooms.Size = new System.Drawing.Size(200, 100);
            this.gbBathrooms.TabIndex = 3;
            this.gbBathrooms.TabStop = false;
            this.gbBathrooms.Text = "Bathrooms";
            // 
            // radThreeBath
            // 
            this.radThreeBath.AutoSize = true;
            this.radThreeBath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radThreeBath.Location = new System.Drawing.Point(7, 75);
            this.radThreeBath.Name = "radThreeBath";
            this.radThreeBath.Size = new System.Drawing.Size(92, 18);
            this.radThreeBath.TabIndex = 0;
            this.radThreeBath.TabStop = true;
            this.radThreeBath.Text = "3 Bathroom";
            this.radThreeBath.UseVisualStyleBackColor = true;
            this.radThreeBath.CheckedChanged += new System.EventHandler(this.handleRentChange);
            // 
            // radTwoBath
            // 
            this.radTwoBath.AutoSize = true;
            this.radTwoBath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radTwoBath.Location = new System.Drawing.Point(7, 49);
            this.radTwoBath.Name = "radTwoBath";
            this.radTwoBath.Size = new System.Drawing.Size(92, 18);
            this.radTwoBath.TabIndex = 0;
            this.radTwoBath.TabStop = true;
            this.radTwoBath.Text = "2 Bathroom";
            this.radTwoBath.UseVisualStyleBackColor = true;
            this.radTwoBath.CheckedChanged += new System.EventHandler(this.handleRentChange);
            // 
            // radOneBath
            // 
            this.radOneBath.AutoSize = true;
            this.radOneBath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radOneBath.Location = new System.Drawing.Point(7, 22);
            this.radOneBath.Name = "radOneBath";
            this.radOneBath.Size = new System.Drawing.Size(92, 18);
            this.radOneBath.TabIndex = 0;
            this.radOneBath.TabStop = true;
            this.radOneBath.Text = "1 Bathroom";
            this.radOneBath.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(404, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 14);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // CornerstoneApparments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbBathrooms);
            this.Controls.Add(this.gbBedrooms);
            this.Controls.Add(this.gbViews);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CornerstoneApparments";
            this.Text = "CornerstoneApparments";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbViews.ResumeLayout(false);
            this.gbViews.PerformLayout();
            this.gbBedrooms.ResumeLayout(false);
            this.gbBedrooms.PerformLayout();
            this.gbBathrooms.ResumeLayout(false);
            this.gbBathrooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bedroomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOneBed;
        private System.Windows.Forms.ToolStripMenuItem menuTwoBed;
        private System.Windows.Forms.ToolStripMenuItem menuThreeBed;
        private System.Windows.Forms.ToolStripMenuItem apartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLakeView;
        private System.Windows.Forms.ToolStripMenuItem menuPondView;
        private System.Windows.Forms.ToolStripMenuItem bathroomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOneBath;
        private System.Windows.Forms.ToolStripMenuItem menuTwoBath;
        private System.Windows.Forms.ToolStripMenuItem menuThreeBath;
        private System.Windows.Forms.GroupBox gbViews;
        private System.Windows.Forms.RadioButton radLakeView;
        private System.Windows.Forms.RadioButton radPondView;
        private System.Windows.Forms.GroupBox gbBedrooms;
        private System.Windows.Forms.RadioButton radThreeBed;
        private System.Windows.Forms.RadioButton radTwoBed;
        private System.Windows.Forms.RadioButton radOneBed;
        private System.Windows.Forms.GroupBox gbBathrooms;
        private System.Windows.Forms.RadioButton radThreeBath;
        private System.Windows.Forms.RadioButton radTwoBath;
        private System.Windows.Forms.RadioButton radOneBath;
        private System.Windows.Forms.Label lblTotal;
    }
}

