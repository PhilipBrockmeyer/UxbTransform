namespace UxbTransform.UI
{
    partial class InputDetails
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
            this.cboGestureType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProperties = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cboGestureType
            // 
            this.cboGestureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGestureType.FormattingEnabled = true;
            this.cboGestureType.Location = new System.Drawing.Point(82, 3);
            this.cboGestureType.Name = "cboGestureType";
            this.cboGestureType.Size = new System.Drawing.Size(198, 21);
            this.cboGestureType.TabIndex = 0;
            this.cboGestureType.SelectedIndexChanged += new System.EventHandler(this.cboGestureType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gesture Type";
            // 
            // pnlProperties
            // 
            this.pnlProperties.AutoScroll = true;
            this.pnlProperties.Location = new System.Drawing.Point(0, 30);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(283, 112);
            this.pnlProperties.TabIndex = 2;
            // 
            // InputDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboGestureType);
            this.Name = "InputDetails";
            this.Size = new System.Drawing.Size(283, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGestureType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlProperties;
    }
}
