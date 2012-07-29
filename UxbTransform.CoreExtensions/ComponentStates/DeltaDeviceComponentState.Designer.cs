namespace UxbTransform.UI.ComponentStates
{
    partial class DeltaDeviceComponentState
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
            this.chkDelta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkDelta
            // 
            this.chkDelta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDelta.Enabled = false;
            this.chkDelta.Location = new System.Drawing.Point(3, -1);
            this.chkDelta.Name = "chkDelta";
            this.chkDelta.Size = new System.Drawing.Size(207, 20);
            this.chkDelta.TabIndex = 1;
            this.chkDelta.Text = "Delta";
            this.chkDelta.UseVisualStyleBackColor = true;
            // 
            // DeltaDeviceComponentState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkDelta);
            this.Name = "DeltaDeviceComponentState";
            this.Size = new System.Drawing.Size(213, 19);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDelta;
    }
}
