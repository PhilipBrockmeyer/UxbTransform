using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.Configuration;

namespace UxbTransform.UI
{
    public partial class ApplicationMapping : UserControl
    {
        ApplicationConfiguration _model;

        public ApplicationMapping()
        {
            InitializeComponent();
        }

        public void Initialize(ApplicationConfiguration model)
        {
            _model = model;

            MoveModelToView();
        }

        public void MoveModelToView()
        {
            lstMappings.Items.Clear();

            if (_model == null)
            {
                lstMappings.Enabled = false;
                tabMappingDetails.Enabled = false;
                return;
            }

            lstMappings.Enabled = true;

            foreach (var mapping in _model.GestureMappings)
            {
                lstMappings.Items.Add(mapping);
            }

            if (lstMappings.Items.Count > 0)
                lstMappings.SelectedIndex = 0;
            else
                SelectMapping();
        }

        public void MoveViewToModel()
        {
            MappingConfiguration mapping;

            if (lstMappings.SelectedIndex > -1)
                mapping = (MappingConfiguration)lstMappings.SelectedItem;
            else
                return;

            ucCommandDetails.MoveViewToModel();
            ucInputDetails.MoveViewToModel();

            for (Int32 tabIndex = tabMappingDetails.TabCount - 1; tabIndex > 1; tabIndex--)
            {
                var ucModifierDetails = tabMappingDetails.TabPages[tabIndex].Controls[0] as ModifierDetails;
                ucModifierDetails.MoveViewToModel();
            }
        }

        private void AddMapping()
        {
            MappingConfiguration mapping = new MappingConfiguration();
            _model.AddMapping(mapping);
            MoveModelToView();
            lstMappings.SelectedIndex = lstMappings.Items.Count - 1;
        }

        private void RemoveMapping()
        {
            var mapping = lstMappings.SelectedItem as MappingConfiguration;

            if (mapping == null)
                return;

            _model.RemoveMapping(mapping);
            MoveModelToView();
        }

        private void SelectMapping()
        {
            // Clear input modifier tabs.
            while (tabMappingDetails.TabPages.Count > 2)
            {
                tabMappingDetails.TabPages.RemoveAt(2);
            }

            MappingConfiguration mapping = lstMappings.SelectedItem as MappingConfiguration;

            ucCommandDetails.Initialize(null);
            ucInputDetails.Initialize(null);

            if (mapping == null)
            {
                groupBox3.Enabled = false;
                return;
            }

            if (mapping.Gesture == null)
            {
                groupBox3.Enabled = false;
                return;
            }

            if (mapping.Gesture.Modifiers == null)
            {
                groupBox3.Enabled = false;
                return;
            }

            groupBox3.Enabled = true;

            ucCommandDetails.Initialize(mapping.Command);
            ucInputDetails.Initialize(mapping.Gesture);

            int index = 1;
            foreach (var modifier in mapping.Gesture.Modifiers)
            {
                TabPage modifierTab = new TabPage("Mod " + index.ToString());
                index++;
                ModifierDetails ucModifierDetails = new ModifierDetails();
                tabMappingDetails.TabPages.Add(modifierTab);
                modifierTab.Controls.Add(ucModifierDetails);
                ucModifierDetails.Initialize(modifier);
            }
        }

        private void lstMappings_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectMapping();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MoveViewToModel();
            _model.BuildInputMap();
            MoveModelToView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMapping();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveMapping();
        }

        private void btnAddModifier_Click(object sender, EventArgs e)
        {
            var mapping = lstMappings.SelectedItem as MappingConfiguration;

            if (mapping == null)
                return;

            GestureModifierConfiguartion modifier = new GestureModifierConfiguartion();

            mapping.Gesture.Modifiers.Add(modifier);
            Int32 currentIndex = lstMappings.SelectedIndex;
            MoveModelToView();
            lstMappings.SelectedIndex = currentIndex;
        }

        private void btnRemoveModifier_Click(object sender, EventArgs e)
        {
            var ucModifier = tabMappingDetails.SelectedTab.Controls[0] as ModifierDetails;

            if (ucModifier == null)
                return;

            var mapping = lstMappings.SelectedItem as MappingConfiguration;

            if (mapping == null)
                return;

            mapping.Gesture.Modifiers.Remove(ucModifier.Model);

            Int32 currentIndex = lstMappings.SelectedIndex;
            MoveModelToView();
            lstMappings.SelectedIndex = currentIndex;
        }
    }
}
