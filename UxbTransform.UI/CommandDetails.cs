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
    public partial class CommandDetails : UserControl
    {
        CommandConfiguration _model;

        public CommandDetails()
        {
            InitializeComponent();
        }

        public void Initialize(CommandConfiguration model)
        {
            _model = model;

            MoveModelToView();
        }

        public void MoveModelToView()
        {
            if (_model == null)
            {
                Clear();
                return;
            }

            SetCommandSet();
            SetCommand();
            SetProperties();
        }

        private void Clear()
        {
            cboCommand.Items.Clear();
            cboCommandSet.Items.Clear();
            pnlProperties.Controls.Clear();
        }

        public void MoveViewToModel()
        {
            List<PropertySetterConfiguration> setters = new List<PropertySetterConfiguration>();
            foreach (IPropertySetterUI item in pnlProperties.Controls)
            {
                setters.Add(item.GetValue());
            }

            if (cboCommandSet.SelectedItem == null)
                _model.CommandSet = null;
            else
                _model.CommandSet = ((CommandSetInfo)cboCommandSet.SelectedItem).Key;

            if (cboCommand.SelectedItem == null)
                _model.Name = null;
            else
                _model.Name = ((CommandDescriptor)cboCommand.SelectedItem).Name;

            _model.Properties = setters;
        }

        private void SetProperties()
        {
            foreach (IPropertySetterUI setter in pnlProperties.Controls.Cast<IPropertySetterUI>())
            {
                var prop = _model.Properties.Where(p => p.Property == setter.Property).Single();
                setter.SetValue(prop.Value);
            }
        }

        private void SetCommand()
        {
            if (_model.Name == null)
                return;

            CommandDescriptor command = null;

            try
            {
                command = (from item in cboCommand.Items.Cast<CommandDescriptor>()
                           where item.Name == _model.Name
                           select item).Single();
            }
            catch (InvalidOperationException)
            {
                return;
            }

            cboCommand.SelectedItem = command;
        }

        private void SetCommandSet()
        {
            FillCommandSets();

            if (_model.CommandSet == null)
                return;

            CommandSetInfo selectedCommandSet = null;

            try
            {
                selectedCommandSet = (from item in cboCommandSet.Items.Cast<CommandSetInfo>()
                                      where item.Key == _model.CommandSet
                                      select item).Single();
            }
            catch (InvalidOperationException)
            {
                return;
            }

            cboCommandSet.SelectedItem = selectedCommandSet;
        }

        private void FillCommandSets()
        {
            cboCommandSet.Items.Clear();

            foreach (var commandSet in ServiceLocator.GetCommandSets())
                cboCommandSet.Items.Add(commandSet);
        }

        private void FillCommands()
        {
            cboCommand.Items.Clear();

            foreach (CommandDescriptor command in ((CommandSetInfo)cboCommandSet.SelectedItem)
                                                        .CommandSet
                                                        .FindCommands())
            {
                cboCommand.Items.Add(command);
            }
        }

        private void FillProperties(Command cmd)
        {
            pnlProperties.Controls.Clear();

            if (!cmd.AllowUserProperties)
                return;

            foreach (var prop in cmd.GetType().GetProperties())
            {
                if (prop.GetCustomAttributes(typeof(UserPropertyAttribute), true).Count() == 0)
                    continue;

                var setterControl = ServiceLocator.GetPropertyUI(prop.PropertyType);

                PropertySetterConfiguration setterConfig = new PropertySetterConfiguration();
                setterConfig.Property = prop.Name;
                setterConfig.Value = null;
                setterControl.Initialize(setterConfig);
                pnlProperties.Controls.Add((Control)setterControl);
            }
        }

        private void SelectCommandSet()
        {
            FillCommands();
        }

        private void SelectCommand()
        {
            Command cmd = ((CommandDescriptor)cboCommand.SelectedItem).CreateCommandInstance();

            FillProperties(cmd);
        }

        private void cboCommandSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCommandSet();
        }

        private void cboCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCommand();
        }
    }
}
