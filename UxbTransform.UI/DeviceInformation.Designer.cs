namespace UxbTransform.UI
{
    partial class DeviceInformation
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
            this.pnlRead = new System.Windows.Forms.Panel();
            this.lblDeviceType1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.chkIsConnected1 = new System.Windows.Forms.CheckBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblDeviceType2 = new System.Windows.Forms.Label();
            this.chkIsConnected2 = new System.Windows.Forms.CheckBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.bntSave = new System.Windows.Forms.Button();
            this.pnlRead.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRead
            // 
            this.pnlRead.Controls.Add(this.lblDeviceType1);
            this.pnlRead.Controls.Add(this.btnEdit);
            this.pnlRead.Controls.Add(this.lblIndex);
            this.pnlRead.Controls.Add(this.chkIsConnected1);
            this.pnlRead.Controls.Add(this.lblDeviceName);
            this.pnlRead.Location = new System.Drawing.Point(0, 0);
            this.pnlRead.Name = "pnlRead";
            this.pnlRead.Size = new System.Drawing.Size(252, 100);
            this.pnlRead.TabIndex = 0;
            // 
            // lblDeviceType1
            // 
            this.lblDeviceType1.AutoSize = true;
            this.lblDeviceType1.Location = new System.Drawing.Point(157, 7);
            this.lblDeviceType1.Name = "lblDeviceType1";
            this.lblDeviceType1.Size = new System.Drawing.Size(68, 13);
            this.lblDeviceType1.TabIndex = 5;
            this.lblDeviceType1.Text = "Device Type";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(159, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(4, 33);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(42, 13);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "Index 1";
            // 
            // chkIsConnected1
            // 
            this.chkIsConnected1.AutoSize = true;
            this.chkIsConnected1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsConnected1.Enabled = false;
            this.chkIsConnected1.Location = new System.Drawing.Point(7, 56);
            this.chkIsConnected1.Name = "chkIsConnected1";
            this.chkIsConnected1.Size = new System.Drawing.Size(78, 17);
            this.chkIsConnected1.TabIndex = 1;
            this.chkIsConnected1.Text = "Connected";
            this.chkIsConnected1.UseVisualStyleBackColor = true;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(4, 7);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(103, 13);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "No Device Selected";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.lblDeviceType2);
            this.pnlEdit.Controls.Add(this.chkIsConnected2);
            this.pnlEdit.Controls.Add(this.txtIndex);
            this.pnlEdit.Controls.Add(this.txtDeviceName);
            this.pnlEdit.Controls.Add(this.bntSave);
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(250, 100);
            this.pnlEdit.TabIndex = 1;
            // 
            // lblDeviceType2
            // 
            this.lblDeviceType2.AutoSize = true;
            this.lblDeviceType2.Location = new System.Drawing.Point(157, 10);
            this.lblDeviceType2.Name = "lblDeviceType2";
            this.lblDeviceType2.Size = new System.Drawing.Size(68, 13);
            this.lblDeviceType2.TabIndex = 4;
            this.lblDeviceType2.Text = "Device Type";
            // 
            // chkIsConnected2
            // 
            this.chkIsConnected2.AutoSize = true;
            this.chkIsConnected2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsConnected2.Enabled = false;
            this.chkIsConnected2.Location = new System.Drawing.Point(7, 60);
            this.chkIsConnected2.Name = "chkIsConnected2";
            this.chkIsConnected2.Size = new System.Drawing.Size(78, 17);
            this.chkIsConnected2.TabIndex = 3;
            this.chkIsConnected2.Text = "Connected";
            this.chkIsConnected2.UseVisualStyleBackColor = true;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(7, 33);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(145, 20);
            this.txtIndex.TabIndex = 2;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(7, 7);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(145, 20);
            this.txtDeviceName.TabIndex = 1;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(160, 72);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(87, 23);
            this.bntSave.TabIndex = 0;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // DeviceInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRead);
            this.Controls.Add(this.pnlEdit);
            this.Name = "DeviceInformation";
            this.Size = new System.Drawing.Size(250, 100);
            this.pnlRead.ResumeLayout(false);
            this.pnlRead.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRead;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.CheckBox chkIsConnected1;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.CheckBox chkIsConnected2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblDeviceType2;
        private System.Windows.Forms.Label lblDeviceType1;
    }
}
