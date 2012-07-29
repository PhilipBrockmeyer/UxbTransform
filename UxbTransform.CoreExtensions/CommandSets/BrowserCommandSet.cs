using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.Commands;

namespace UxbTransform.CommandSets
{
        [CommandSet("Browser Commands", "BrowserCommandSet")]
        public class BrowserCommandSet : CommandSet
        {
        CommandDescriptor _backCommand;
        CommandDescriptor _forwardCommand;
        CommandDescriptor _homeCommand;
        CommandDescriptor _refreshCommand;
        CommandDescriptor _favoritesCommand;
        CommandDescriptor _searchCommand;
        CommandDescriptor _switchTabCommand;

        public CommandDescriptor BackCommand { get { return _backCommand; } }
        public CommandDescriptor ForwardCommand { get { return _forwardCommand; } }
        public CommandDescriptor HomeCommand { get { return _homeCommand; } }
        public CommandDescriptor RefreshCommand { get { return _refreshCommand; } }
        public CommandDescriptor FavoritesCommand { get { return _favoritesCommand; } }
        public CommandDescriptor SearchCommand { get { return _searchCommand; } }
        public CommandDescriptor SwitchTabCommand { get { return _switchTabCommand; } }

        public BrowserCommandSet()
        {
            _backCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.BrowserBack, AllowUserProperties = false },
                ActionText = "Browse Back"
            };

            _forwardCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.BrowserForward, AllowUserProperties = false },
                ActionText = "Browse Forward"
            };

            _homeCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.BrowserHome, AllowUserProperties = false },
                ActionText = "Home Page"
            };

            _refreshCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.BrowserRefresh, AllowUserProperties = false },
                ActionText = "Refresh"
            };

            _favoritesCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.BrowserFavorites, AllowUserProperties = false },
                ActionText = "Favorites"
            };

            _searchCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new KeyPressCommand() { Key = System.Windows.Forms.Keys.BrowserSearch, AllowUserProperties = false },
                ActionText = "Search"
            };

            _switchTabCommand = new CommandDescriptor()
            {
                CreateCommandInstance = () => new SwitchCommand() 
                {   
                    SwitchKey = System.Windows.Forms.Keys.Tab,
                    ModifierKey = System.Windows.Forms.Keys.ControlKey,
                    ReverseModifierKey = System.Windows.Forms.Keys.ShiftKey,
                    AllowUserProperties = false 
                },

                ActionText = "Switch Tabs"
            };
        }
    }
}
