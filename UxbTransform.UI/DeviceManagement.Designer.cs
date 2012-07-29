namespace UxbTransform.UI
{
    partial class DeviceManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucDeviceInformation = new UxbTransform.UI.DeviceInformation();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.ucDeviceState = new UxbTransform.UI.GenericDeviceState();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpState.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveDevice);
            this.groupBox1.Controls.Add(this.btnAddDevice);
            this.groupBox1.Controls.Add(this.lstDevices);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Location = new System.Drawing.Point(114, 380);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveDevice.TabIndex = 2;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(8, 380);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(100, 23);
            this.btnAddDevice.TabIndex = 1;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.Location = new System.Drawing.Point(6, 19);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(208, 355);
            this.lstDevices.TabIndex = 0;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.lstDevices_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucDeviceInformation);
            this.groupBox2.Location = new System.Drawing.Point(230, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // ucDeviceInformation
            // 
            this.ucDeviceInformation.Location = new System.Drawing.Point(1, 19);
            this.ucDeviceInformation.Name = "ucDeviceInformation";
            this.ucDeviceInformation.Size = new System.Drawing.Size(250, 100);
            this.ucDeviceInformation.TabIndex = 0;
            // 
            // grpState
            // 
            this.grpState.Controls.Add(this.ucDeviceState);
            this.grpState.Location = new System.Drawing.Point(230, 133);
            this.grpState.Name = "grpState";
            this.grpState.Size = new System.Drawing.Size(252, 278);
            this.grpState.TabIndex = 2;
            this.grpState.TabStop = false;
            this.grpState.Text = "State (Not Connected)";
            // 
            // ucDeviceState
            // 
            this.ucDeviceState.Location = new System.Drawing.Point(1, 20);
            this.ucDeviceState.Name = "ucDeviceState";
            this.ucDeviceState.Size = new System.Drawing.Size(250, 257);
            this.ucDeviceState.TabIndex = 0;
            // 
            // DeviceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpState);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviceManagement";
            this.Size = new System.Drawing.Size(485, 418);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpState.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpState;
        private DeviceInformation ucDeviceInformation;
        private GenericDeviceState ucDeviceState;
    }
}
