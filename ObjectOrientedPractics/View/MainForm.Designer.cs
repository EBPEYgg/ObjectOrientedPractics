﻿namespace ObjectOrientedPractics
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
<<<<<<< HEAD
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTabs = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.TabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.SuspendLayout();
=======
            TabControl = new TabControl();
            ItemsTabPage = new TabPage();
            ItemsTabs = new View.Tabs.ItemsTabs();
            CustomersTabPage = new TabPage();
            customerTabs1 = new View.Tabs.CustomerTabs();
            TabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            SuspendLayout();
>>>>>>> 95a8cda86700a5ac3aaca6c3389103d4d5758009
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabPage);
            TabControl.Controls.Add(CustomersTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(754, 482);
            TabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
<<<<<<< HEAD
            this.ItemsTabPage.Controls.Add(this.ItemsTabs);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(689, 416);
            this.ItemsTabPage.TabIndex = 2;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabs
            // 
            this.ItemsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabs.Location = new System.Drawing.Point(3, 3);
            this.ItemsTabs.Name = "ItemsTabs";
            this.ItemsTabs.Size = new System.Drawing.Size(683, 410);
            this.ItemsTabs.TabIndex = 0;
=======
            ItemsTabPage.Controls.Add(ItemsTabs);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(746, 454);
            ItemsTabPage.TabIndex = 2;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabs
            // 
            ItemsTabs.Dock = DockStyle.Fill;
            ItemsTabs.Location = new Point(3, 3);
            ItemsTabs.Name = "ItemsTabs";
            ItemsTabs.Size = new Size(740, 448);
            ItemsTabs.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(customerTabs1);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(746, 454);
            CustomersTabPage.TabIndex = 3;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customerTabs1
            // 
            customerTabs1.Dock = DockStyle.Fill;
            customerTabs1.Location = new Point(3, 3);
            customerTabs1.Name = "customerTabs1";
            customerTabs1.Size = new Size(740, 448);
            customerTabs1.TabIndex = 0;
>>>>>>> 95a8cda86700a5ac3aaca6c3389103d4d5758009
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 482);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(713, 521);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            TabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private View.Tabs.ItemsTabs ItemsTabs;
<<<<<<< HEAD
=======
        private TabPage CustomersTabPage;
        private View.Tabs.CustomerTabs customerTabs1;
>>>>>>> 95a8cda86700a5ac3aaca6c3389103d4d5758009
    }
}