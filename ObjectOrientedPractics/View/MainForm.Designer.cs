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
            TabControl = new TabControl();
            ItemsTabPage = new TabPage();
            ItemsTabs = new View.Tabs.ItemsTabs();
            CustomersTabPage = new TabPage();
            TabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabPage);
            TabControl.Controls.Add(CustomersTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(697, 482);
            TabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTabs);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(689, 454);
            ItemsTabPage.TabIndex = 2;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabs
            // 
            ItemsTabs.Dock = DockStyle.Fill;
            ItemsTabs.Location = new Point(3, 3);
            ItemsTabs.Name = "ItemsTabs";
            ItemsTabs.Size = new Size(683, 448);
            ItemsTabs.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(689, 454);
            CustomersTabPage.TabIndex = 3;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 482);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(713, 0);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            TabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private View.Tabs.ItemsTabs ItemsTabs;
        private TabPage CustomersTabPage;
    }
}