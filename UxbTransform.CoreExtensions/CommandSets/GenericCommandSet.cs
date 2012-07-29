using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.Commands;
using UxbTransform.CoreExtensions.Commands;

namespace UxbTransform.Applications
{
    [CommandSet("Generic Commands", "GenericCommandSet")]
    public class GenericCommandSet : CommandSet
    {
        CommandDescriptor _keyPressCommand;
        CommandDescriptor _keyMapCommand;
        CommandDescriptor _mouseClickCommand;
        CommandDescriptor _mouseMoveCommand;
        CommandDescriptor _mouseControlCommand;

        CommandDescriptor _upCommand;
        CommandDescriptor _downCommand;
        CommandDescriptor _leftCommand;
        CommandDescriptor _rightCommand;

        public CommandDescriptor KeyPressCommand { get { return _keyPressCommand; } }
        public CommandDescriptor KeyMapCommand { get { return _keyMapCommand; } }
        public CommandDescriptor MouseClickCommand { get { return _mouseClickCommand; } }
        public CommandDescriptor MouseMoveCommand { get { return _mouseMoveCommand; } }
        public CommandDescriptor MouseControlCommand { get { return _mouseControlCommand; } }

        public CommandDescriptor UpCommand { get { return _upCommand; } }
        public CommandDescriptor DownCommand { get { return _downCommand; } }
        public CommandDescriptor LeftCommand { get { return _leftCommand; } }
        public CommandDescriptor RightCommand { get { return _rightCommand; } }

        public GenericCommandSet()
        {
            _keyPressCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand(),
                ActionText = "Key Press"
            };

            _keyMapCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyMapCommand(),
                ActionText = "Key Map"
            };

            _mouseClickCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new MouseClickCommand(),
                ActionText = "Mouse Click"
            };

            _mouseMoveCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new MouseMoveCommand(),
                ActionText = "Mouse Move"
            };

            _mouseControlCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new MouseControlCommand(),
                ActionText = "Control Mouse"
            };

            _upCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Up, AllowUserProperties = false },
                ActionText = "Up"
            };

            _downCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Down, AllowUserProperties = false },
                ActionText = "Down"
            };

            _leftCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Left, AllowUserProperties = false },
                ActionText = "Left"
            };

            _rightCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Right, AllowUserProperties = false },
                ActionText = "Right"
            };
        }
    }
}
