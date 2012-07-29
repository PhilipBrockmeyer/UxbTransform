namespace UxbTransform.UI
{
    partial class ButtonDeviceComponentState
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
            this.chkButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkButton
            // 
            this.chkButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkButton.Enabled = false;
            this.chkButton.Location = new System.Drawing.Point(0, 0);
            this.chkButton.Name = "chkButton";
            this.chkButton.Size = new System.Drawing.Size(207, 20);
            this.chkButton.TabIndex = 0;
            this.chkButton.Text = "Button";
            this.chkButton.UseVisualStyleBackColor = true;
            // 
            // ButtonDeviceComponentState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkButton);
            this.Name = "ButtonDeviceComponentState";
            this.Size = new System.Drawing.Size(213, 19);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkButton;
    }
}
