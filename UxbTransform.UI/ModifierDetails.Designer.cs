namespace UxbTransform.UI
{
    partial class ModifierDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboModifier = new System.Windows.Forms.ComboBox();
            this.pnlProperties = new System.Windows.Forms.FlowLayoutPanel();
            this.radRequired = new System.Windows.Forms.RadioButton();
            this.radCancel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modifier Type";
            // 
            // cboModifier
            // 
            this.cboModifier.FormattingEnabled = true;
            this.cboModifier.Location = new System.Drawing.Point(82, 3);
            this.cboModifier.Name = "cboModifier";
            this.cboModifier.Size = new System.Drawing.Size(198, 21);
            this.cboModifier.TabIndex = 2;
            this.cboModifier.SelectedIndexChanged += new System.EventHandler(this.cboModifier_SelectedIndexChanged_1);
            // 
            // pnlProperties
            // 
            this.pnlProperties.AutoScroll = true;
            this.pnlProperties.Location = new System.Drawing.Point(0, 53);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(283, 89);
            this.pnlProperties.TabIndex = 4;
            // 
            // radRequired
            // 
            this.radRequired.AutoSize = true;
            this.radRequired.Checked = true;
            this.radRequired.Location = new System.Drawing.Point(6, 30);
            this.radRequired.Name = "radRequired";
            this.radRequired.Size = new System.Drawing.Size(133, 17);
            this.radRequired.TabIndex = 5;
            this.radRequired.TabStop = true;
            this.radRequired.Text = "Required for Command";
            this.radRequired.UseVisualStyleBackColor = true;
            // 
            // radCancel
            // 
            this.radCancel.AutoSize = true;
            this.radCancel.Location = new System.Drawing.Point(146, 30);
            this.radCancel.Name = "radCancel";
            this.radCancel.Size = new System.Drawing.Size(131, 17);
            this.radCancel.TabIndex = 6;
            this.radCancel.Text = "Cancels the Command";
            this.radCancel.UseVisualStyleBackColor = true;
            // 
            // ModifierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radCancel);
            this.Controls.Add(this.radRequired);
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboModifier);
            this.Name = "ModifierDetails";
            this.Size = new System.Drawing.Size(283, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboModifier;
        private System.Windows.Forms.FlowLayoutPanel pnlProperties;
        private System.Windows.Forms.RadioButton radRequired;
        private System.Windows.Forms.RadioButton radCancel;
    }
}
