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
            ObjectOrientedPractics.Model.PriorityOrder priorityOrder1 = new ObjectOrientedPractics.Model.PriorityOrder();
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTabs = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomerTabs = new ObjectOrientedPractics.View.Tabs.CustomerTabs();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.PriorityOrdersTabPage = new System.Windows.Forms.TabPage();
            this.PriorityOrdersTab = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.TabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.PriorityOrdersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.CustomersTabPage);
            this.TabControl.Controls.Add(this.CartsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Controls.Add(this.PriorityOrdersTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(760, 487);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTabs);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(752, 459);
            this.ItemsTabPage.TabIndex = 2;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabs
            // 
            this.ItemsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabs.Location = new System.Drawing.Point(3, 3);
            this.ItemsTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsTabs.Name = "ItemsTabs";
            this.ItemsTabs.Size = new System.Drawing.Size(746, 453);
            this.ItemsTabs.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomerTabs);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 24);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersTabPage.Size = new System.Drawing.Size(752, 459);
            this.CustomersTabPage.TabIndex = 3;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerTabs
            // 
            this.CustomerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTabs.Location = new System.Drawing.Point(3, 4);
            this.CustomerTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerTabs.Name = "CustomerTabs";
            this.CustomerTabs.Size = new System.Drawing.Size(746, 451);
            this.CustomerTabs.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 24);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(752, 459);
            this.CartsTabPage.TabIndex = 4;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Location = new System.Drawing.Point(3, 3);
            this.CartsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(746, 453);
            this.CartsTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.OrdersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 24);
            this.OrdersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersTabPage.Size = new System.Drawing.Size(752, 459);
            this.OrdersTabPage.TabIndex = 5;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTab.Location = new System.Drawing.Point(3, 2);
            this.OrdersTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(746, 455);
            this.OrdersTab.TabIndex = 0;
            // 
            // PriorityOrdersTabPage
            // 
            this.PriorityOrdersTabPage.Controls.Add(this.PriorityOrdersTab);
            this.PriorityOrdersTabPage.Location = new System.Drawing.Point(4, 24);
            this.PriorityOrdersTabPage.Name = "PriorityOrdersTabPage";
            this.PriorityOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PriorityOrdersTabPage.Size = new System.Drawing.Size(752, 459);
            this.PriorityOrdersTabPage.TabIndex = 6;
            this.PriorityOrdersTabPage.Text = "Priority Orders";
            this.PriorityOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            this.PriorityOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityOrdersTab.Location = new System.Drawing.Point(3, 3);
            this.PriorityOrdersTab.Name = "PriorityOrdersTab";
            priorityOrder1.Address = address1;
            priorityOrder1.Amount = 0;
            priorityOrder1.CreationDate = "20.10.2023 21:53:58";
            priorityOrder1.IsPriority = false;
            priorityOrder1.OrderStatus = OrderStatus.New;
            priorityOrder1.RequestedDeliveryDate = new System.DateTime(((long)(0)));
            priorityOrder1.RequestedDeliveryTime = null;
            this.PriorityOrdersTab.PriorityOrder = priorityOrder1;
            this.PriorityOrdersTab.Size = new System.Drawing.Size(746, 453);
            this.PriorityOrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 487);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(776, 526);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.PriorityOrdersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private View.Tabs.ItemsTabs ItemsTabs;
        private TabPage CustomersTabPage;
        private View.Tabs.CustomerTabs CustomerTabs;
        private View.Tabs.CartsTab CartsTabs;
        private TabPage CartsTabPage;
        private View.Tabs.CartsTab CartsTab;
        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage PriorityOrdersTabPage;
        private View.Tabs.PriorityOrdersTab PriorityOrdersTab;
    }
}