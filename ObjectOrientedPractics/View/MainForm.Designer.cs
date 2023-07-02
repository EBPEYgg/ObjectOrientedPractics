namespace ObjectOrientedPractics
{
    partial class MainForm
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
            this.itemsTabs1 = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.SuspendLayout();
            // 
            // itemsTabs1
            // 
            this.itemsTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTabs1.Location = new System.Drawing.Point(0, 0);
            this.itemsTabs1.Margin = new System.Windows.Forms.Padding(0);
            this.itemsTabs1.MinimumSize = new System.Drawing.Size(697, 445);
            this.itemsTabs1.Name = "itemsTabs1";
            this.itemsTabs1.Size = new System.Drawing.Size(697, 445);
            this.itemsTabs1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 444);
            this.Controls.Add(this.itemsTabs1);
            this.MinimumSize = new System.Drawing.Size(713, 483);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private View.Tabs.ItemsTabs itemsTabs1;
    }
}