namespace UxbTransform.UI.PropertySetters
{
    partial class KeyboardKeySetter
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
            this.cboKey = new System.Windows.Forms.ComboBox();
            this.lblProperty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboKey
            // 
            this.cboKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKey.FormattingEnabled = true;
            this.cboKey.Location = new System.Drawing.Point(93, 0);
            this.cboKey.Name = "cboKey";
            this.cboKey.Size = new System.Drawing.Size(150, 21);
            this.cboKey.TabIndex = 0;
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(3, 3);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(25, 13);
            this.lblProperty.TabIndex = 1;
            this.lblProperty.Text = "Key";
            // 
            // KeyboardKeySetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.cboKey);
            this.Name = "KeyboardKeySetter";
            this.Size = new System.Drawing.Size(246, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKey;
        private System.Windows.Forms.Label lblProperty;
    }
}
