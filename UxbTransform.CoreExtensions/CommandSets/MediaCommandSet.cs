using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform;
using UxbTransform.Applications;
using UxbTransform.Commands;

namespace UxbTransform.Applications
{
    [CommandSet("Media Commands", "MediaCommandSet")]
    public class MediaCommandSet : CommandSet
    {
        CommandDescriptor _selectCommand;
        CommandDescriptor _backCommand;
        CommandDescriptor _nextTrackCommand;
        CommandDescriptor _previousTrackCommand;
        CommandDescriptor _playPauseCommand;
        CommandDescriptor _volumeDownCommand;
        CommandDescriptor _volumeUpCommand;
        CommandDescriptor _volumeMuteCommand;

        public CommandDescriptor SelectCommand { get { return _selectCommand; } }
        public CommandDescriptor BackCommand { get { return _backCommand; } }
        public CommandDescriptor NextTrackCommand { get { return _nextTrackCommand; } }
        public CommandDescriptor PreviousTrackCommand { get { return _previousTrackCommand; } }
        public CommandDescriptor VolumeUpCommand { get { return _volumeUpCommand; } }
        public CommandDescriptor VolumeDownCommand { get { return _volumeDownCommand; } }
        public CommandDescriptor VolumeMuteCommand { get { return _volumeMuteCommand; } }
        public CommandDescriptor PlayPauseCommand { get { return _playPauseCommand; } }

        public MediaCommandSet()
        {
            _selectCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.Enter, AllowUserProperties = false },
                ActionText = "Select"
            };

            _backCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.Back, AllowUserProperties = false },
                ActionText = "Back"
            };

            _nextTrackCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.MediaNextTrack, AllowUserProperties = false },
                ActionText = "Next Track"
            };

            _previousTrackCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.MediaPreviousTrack, AllowUserProperties = false },
                ActionText = "Previous Track"
            };

            _playPauseCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.MediaPlayPause, AllowUserProperties = false },
                ActionText = "Play/Pause"
            };

            _volumeDownCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.VolumeDown, AllowUserProperties = false },
                ActionText = "Volume Down"
            };

            _volumeUpCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyMapCommand() { Key = System.Windows.Forms.Keys.VolumeUp, AllowUserProperties = false },
                ActionText = "Volume Up"
            };

            _volumeMuteCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.VolumeMute, AllowUserProperties = false },
                ActionText = "Mute"
            };        
        }
    }
}
