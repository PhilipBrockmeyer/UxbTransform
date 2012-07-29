namespace UxbTransform.UI
{
    partial class CommandDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandDetails));
            this.cboCommandSet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCommand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProperties = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cboCommandSet
            // 
            this.cboCommandSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommandSet.FormattingEnabled = true;
            resources.ApplyResources(this.cboCommandSet, "cboCommandSet");
            this.cboCommandSet.Name = "cboCommandSet";
            this.cboCommandSet.SelectedIndexChanged += new System.EventHandler(this.cboCommandSet_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboCommand
            // 
            this.cboCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommand.FormattingEnabled = true;
            resources.ApplyResources(this.cboCommand, "cboCommand");
            this.cboCommand.Name = "cboCommand";
            this.cboCommand.SelectedIndexChanged += new System.EventHandler(this.cboCommand_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pnlProperties
            // 
            resources.ApplyResources(this.pnlProperties, "pnlProperties");
            this.pnlProperties.Name = "pnlProperties";
            // 
            // CommandDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCommandSet);
            this.Name = "CommandDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCommandSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlProperties;
    }
}
