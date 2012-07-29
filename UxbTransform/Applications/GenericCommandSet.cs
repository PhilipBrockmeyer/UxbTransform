using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.Commands;
using System.ComponentModel.Composition;

namespace UxbTransform.CommandSets
{
    [CommandSet("Generic Application", "GenericCommandSet")]
    public class GenericCommandSet : CommandSet
    {
        CommandDescriptor _keyPressCommand;
        CommandDescriptor _keyMapCommand;
        //CommandDescriptor _customCommand;
        CommandDescriptor _mouseClickCommand;
        CommandDescriptor _mouseMoveCommand;

        CommandDescriptor _upCommand;
        CommandDescriptor _downCommand;
        CommandDescriptor _leftCommand;
        CommandDescriptor _rightCommand;

        CommandDescriptor _selectCommand;
        CommandDescriptor _backCommand;
        CommandDescriptor _nextTrackCommand;
        CommandDescriptor _previousTrackCommand;
        CommandDescriptor _playPauseCommand;
        CommandDescriptor _volumeDownCommand;
        CommandDescriptor _volumeUpCommand;
        CommandDescriptor _volumeMuteCommand;

        //public CommandDescriptor CustomCommand { get { return _customCommand; } }
        public CommandDescriptor KeyPressCommand { get { return _keyPressCommand; } }
        public CommandDescriptor KeyMapCommand { get { return _keyMapCommand; } }
        public CommandDescriptor MouseClickCommand { get { return _mouseClickCommand; } }
        public CommandDescriptor MouseMoveCommand { get { return _mouseMoveCommand; } }

        public CommandDescriptor UpCommand { get { return _upCommand; } }
        public CommandDescriptor DownCommand { get { return _downCommand; } }
        public CommandDescriptor LeftCommand { get { return _leftCommand; } }
        public CommandDescriptor RightCommand { get { return _rightCommand; } }

        public CommandDescriptor SelectCommand { get { return _selectCommand; } }
        public CommandDescriptor BackCommand { get { return _backCommand; } }
        public CommandDescriptor NextTrackCommand { get { return _nextTrackCommand; } }
        public CommandDescriptor PreviousTrackCommand { get { return _previousTrackCommand; } }
        public CommandDescriptor VolumeUpCommand { get { return _volumeUpCommand; } }
        public CommandDescriptor VolumeDownCommand { get { return _volumeDownCommand; } }
        public CommandDescriptor VolumeMuteCommand { get { return _volumeMuteCommand; } }
        public CommandDescriptor PlayPauseCommand { get { return _playPauseCommand; } }

        public GenericCommandSet()
        {
            _keyPressCommand = new CommandDescriptor()
            {
                Name = "Key Press",
                CreateCommandInstance = () => new KeyPressCommand()
            };

            _keyMapCommand = new CommandDescriptor()
            {
                Name = "Key Map",
                CreateCommandInstance = () => new KeyMapCommand()
            };

            _mouseClickCommand = new CommandDescriptor()
            {
                Name = "Mouse Click",
                CreateCommandInstance = () => new MouseClickCommand()
            };

            _mouseMoveCommand = new CommandDescriptor()
            {
                Name = "Mouse Move",
                CreateCommandInstance = () => new MouseMoveCommand()
            };

            _upCommand = new CommandDescriptor()
            {
                Name = "Up",
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Up }
            };

            _downCommand = new CommandDescriptor()
            {
                Name = "Down",
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Down }
            };

            _leftCommand = new CommandDescriptor()
            {
                Name = "Left",
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Left }
            };

            _rightCommand = new CommandDescriptor()
            {
                Name = "Right",
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.Right }
            };

            _selectCommand = new CommandDescriptor()
            {
                Name = "Select",
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.Enter }
            };

            _backCommand = new CommandDescriptor()
            {
                Name = "Back",
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.Back }
            };

            _nextTrackCommand = new CommandDescriptor()
            {
                Name = "Next Track",
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.MediaNextTrack }
            };

            _previousTrackCommand = new CommandDescriptor()
            {
                Name = "Previous Track",
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.MediaPreviousTrack }
            };

            _playPauseCommand = new CommandDescriptor()
            {
                Name = "Play/Pause",
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.MediaPlayPause }
            };

            _volumeDownCommand = new CommandDescriptor()
            {
                Name = "Volume Down",
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.VolumeDown }
            };

            _volumeUpCommand = new CommandDescriptor()
            {
                Name = "Volume Up",
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.VolumeUp }
            };

            _volumeMuteCommand = new CommandDescriptor()
            {
                Name = "Mute",
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.VolumeMute }
            };        
        }
    }
}
