namespace UxbTransform.UI
{
    partial class ApplicationMapping
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstMappings = new System.Windows.Forms.ListBox();
            this.btnAddModifier = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabMappingDetails = new System.Windows.Forms.TabControl();
            this.tbCommand = new System.Windows.Forms.TabPage();
            this.ucCommandDetails = new UxbTransform.UI.CommandDetails();
            this.tbInput = new System.Windows.Forms.TabPage();
            this.ucInputDetails = new UxbTransform.UI.InputDetails();
            this.btnRemoveModifier = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabMappingDetails.SuspendLayout();
            this.tbCommand.SuspendLayout();
            this.tbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.lstMappings);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Mapping";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(222, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstMappings
            // 
            this.lstMappings.Enabled = false;
            this.lstMappings.FormattingEnabled = true;
            this.lstMappings.Location = new System.Drawing.Point(6, 19);
            this.lstMappings.Name = "lstMappings";
            this.lstMappings.Size = new System.Drawing.Size(291, 121);
            this.lstMappings.TabIndex = 0;
            this.lstMappings.SelectedIndexChanged += new System.EventHandler(this.lstMappings_SelectedIndexChanged);
            // 
            // btnAddModifier
            // 
            this.btnAddModifier.Location = new System.Drawing.Point(10, 201);
            this.btnAddModifier.Name = "btnAddModifier";
            this.btnAddModifier.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifier.TabIndex = 3;
            this.btnAddModifier.Text = "Add Modifier";
            this.btnAddModifier.UseVisualStyleBackColor = true;
            this.btnAddModifier.Click += new System.EventHandler(this.btnAddModifier_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveModifier);
            this.groupBox3.Controls.Add(this.btnAddModifier);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.tabMappingDetails);
            this.groupBox3.Location = new System.Drawing.Point(3, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 230);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mapping Detail";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(221, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabMappingDetails
            // 
            this.tabMappingDetails.Controls.Add(this.tbCommand);
            this.tabMappingDetails.Controls.Add(this.tbInput);
            this.tabMappingDetails.Location = new System.Drawing.Point(6, 19);
            this.tabMappingDetails.Name = "tabMappingDetails";
            this.tabMappingDetails.SelectedIndex = 0;
            this.tabMappingDetails.Size = new System.Drawing.Size(291, 179);
            this.tabMappingDetails.TabIndex = 0;
            // 
            // tbCommand
            // 
            this.tbCommand.Controls.Add(this.ucCommandDetails);
            this.tbCommand.Location = new System.Drawing.Point(4, 22);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Padding = new System.Windows.Forms.Padding(3);
            this.tbCommand.Size = new System.Drawing.Size(283, 153);
            this.tbCommand.TabIndex = 0;
            this.tbCommand.Text = "Command";
            this.tbCommand.UseVisualStyleBackColor = true;
            // 
            // ucCommandDetails
            // 
            this.ucCommandDetails.Location = new System.Drawing.Point(0, 0);
            this.ucCommandDetails.Name = "ucCommandDetails";
            this.ucCommandDetails.Size = new System.Drawing.Size(283, 179);
            this.ucCommandDetails.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.Controls.Add(this.ucInputDetails);
            this.tbInput.Location = new System.Drawing.Point(4, 22);
            this.tbInput.Name = "tbInput";
            this.tbInput.Padding = new System.Windows.Forms.Padding(3);
            this.tbInput.Size = new System.Drawing.Size(283, 153);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "Input";
            this.tbInput.UseVisualStyleBackColor = true;
            // 
            // ucInputDetails
            // 
            this.ucInputDetails.Location = new System.Drawing.Point(0, 0);
            this.ucInputDetails.Name = "ucInputDetails";
            this.ucInputDetails.Size = new System.Drawing.Size(283, 179);
            this.ucInputDetails.TabIndex = 0;
            // 
            // btnRemoveModifier
            // 
            this.btnRemoveModifier.Location = new System.Drawing.Point(104, 201);
            this.btnRemoveModifier.Name = "btnRemoveModifier";
            this.btnRemoveModifier.Size = new System.Drawing.Size(98, 23);
            this.btnRemoveModifier.TabIndex = 7;
            this.btnRemoveModifier.Text = "Remove Modifier";
            this.btnRemoveModifier.UseVisualStyleBackColor = true;
            this.btnRemoveModifier.Click += new System.EventHandler(this.btnRemoveModifier_Click);
            // 
            // ApplicationMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ApplicationMapping";
            this.Size = new System.Drawing.Size(313, 419);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabMappingDetails.ResumeLayout(false);
            this.tbCommand.ResumeLayout(false);
            this.tbInput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstMappings;
        private System.Windows.Forms.TabControl tabMappingDetails;
        private System.Windows.Forms.TabPage tbCommand;
        private System.Windows.Forms.TabPage tbInput;
        private System.Windows.Forms.Button btnAddModifier;
        private CommandDetails ucCommandDetails;
        private InputDetails ucInputDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveModifier;
    }
}
