
namespace CornerstoneAppartments
{
    partial class InformationForm
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformation.Location = new System.Drawing.Point(101, 132);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(181, 95);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Information Label";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformation.Click += new System.EventHandler(this.lblInformation_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblInformation);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
    }
}