namespace UxbTransform.UI.PropertySetters
{
    partial class Int32Setter
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
            this.lblProperty = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(3, 4);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(46, 13);
            this.lblProperty.TabIndex = 2;
            this.lblProperty.Text = "Property";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(110, 1);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(150, 20);
            this.txtInt.TabIndex = 3;
            // 
            // Int32Setter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblProperty);
            this.Name = "Int32Setter";
            this.Size = new System.Drawing.Size(263, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.TextBox txtInt;
    }
}
