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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTabs = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomerTabs = new ObjectOrientedPractics.View.Tabs.CustomerTabs();
            this.TabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.CustomersTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(862, 643);
            this.TabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTabs);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ItemsTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsTabPage.Size = new System.Drawing.Size(854, 610);
            this.ItemsTabPage.TabIndex = 2;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabs
            // 
            this.ItemsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabs.Location = new System.Drawing.Point(3, 4);
            this.ItemsTabs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ItemsTabs.Name = "ItemsTabs";
            this.ItemsTabs.Size = new System.Drawing.Size(848, 602);
            this.ItemsTabs.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomerTabs);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 29);
            this.CustomersTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersTabPage.Size = new System.Drawing.Size(854, 610);
            this.CustomersTabPage.TabIndex = 3;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerTabs
            // 
            this.CustomerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTabs.Location = new System.Drawing.Point(3, 4);
            this.CustomerTabs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CustomerTabs.Name = "CustomerTabs";
            this.CustomerTabs.Size = new System.Drawing.Size(848, 602);
            this.CustomerTabs.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 643);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(880, 690);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private View.Tabs.ItemsTabs ItemsTabs;
        private TabPage CustomersTabPage;
        private View.Tabs.CustomerTabs CustomerTabs;
    }
}