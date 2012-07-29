namespace UxbTransform
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ntfNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuMainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucDeviceManagement = new UxbTransform.UI.DeviceManagement();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucApplicationManager = new UxbTransform.UI.ApplicationManager();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.xmlUI1 = new UxbTransform.UI.XmlUI();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.logUI1 = new UxbTransform.UI.LogUI();
            this.mnuMainMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntfNotifyIcon
            // 
            this.ntfNotifyIcon.ContextMenuStrip = this.mnuMainMenu;
            this.ntfNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfNotifyIcon.Icon")));
            this.ntfNotifyIcon.Text = "notifyIcon1";
            this.ntfNotifyIcon.Visible = true;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.reconnectToDevicesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMainMenu.Name = "contextMenuStrip1";
            this.mnuMainMenu.Size = new System.Drawing.Size(177, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showToolStripMenuItem.Text = "Show/Hide";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // reconnectToDevicesToolStripMenuItem
            // 
            this.reconnectToDevicesToolStripMenuItem.Name = "reconnectToDevicesToolStripMenuItem";
            this.reconnectToDevicesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reconnectToDevicesToolStripMenuItem.Text = "Reconnect Devices";
            this.reconnectToDevicesToolStripMenuItem.Click += new System.EventHandler(this.reconnectToDevicesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 442);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucDeviceManagement);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Devices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucDeviceManagement
            // 
            this.ucDeviceManagement.Location = new System.Drawing.Point(0, 0);
            this.ucDeviceManagement.Name = "ucDeviceManagement";
            this.ucDeviceManagement.Size = new System.Drawing.Size(485, 416);
            this.ucDeviceManagement.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucApplicationManager);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(485, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Applications";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucApplicationManager
            // 
            this.ucApplicationManager.Location = new System.Drawing.Point(-2, -2);
            this.ucApplicationManager.Name = "ucApplicationManager";
            this.ucApplicationManager.Size = new System.Drawing.Size(485, 418);
            this.ucApplicationManager.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.xmlUI1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(485, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xml";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // xmlUI1
            // 
            this.xmlUI1.Location = new System.Drawing.Point(0, 0);
            this.xmlUI1.Name = "xmlUI1";
            this.xmlUI1.Size = new System.Drawing.Size(485, 418);
            this.xmlUI1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.logUI1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(485, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(195, 446);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(96, 23);
            this.btnApplyChanges.TabIndex = 2;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reconnect Devices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reconnectToDevicesToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(417, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // logUI1
            // 
            this.logUI1.Location = new System.Drawing.Point(0, 0);
            this.logUI1.Name = "logUI1";
            this.logUI1.Size = new System.Drawing.Size(485, 418);
            this.logUI1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApplyChanges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Uxb Input Transformer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mnuMainMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntfNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToDevicesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UxbTransform.UI.DeviceManagement ucDeviceManagement;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Button button1;
        private UxbTransform.UI.ApplicationManager ucApplicationManager;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage3;
        private UxbTransform.UI.XmlUI xmlUI1;
        private System.Windows.Forms.TabPage tabPage4;
        private UxbTransform.UI.LogUI logUI1;
    }
}

