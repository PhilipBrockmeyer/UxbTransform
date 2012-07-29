using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.DeviceComponents;
using System.ComponentModel.Composition;
using System.Drawing;
using MouseKeyboardLibrary;

namespace UxbTransform.Devices
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Device("Mouse", "MouseDevice")]
    public class MouseDevice : Device
    {
        MouseHook _mouse;

        ButtonDeviceComponent _left;
        ButtonDeviceComponent _right;
        ButtonDeviceComponent _middle;

        DeltaDeviceComponent _wheel;

        PositionalDeviceComponent _cursor;
                
        public ButtonDeviceComponent Left { get { return _left; } }
        public ButtonDeviceComponent Right { get { return _right; } }
        public ButtonDeviceComponent Middle { get { return _middle; } }

        public DeltaDeviceComponent Wheel { get { return _wheel; } }

        public PositionalDeviceComponent Cursor { get { return _cursor; } }

        public MouseDevice()
        {
            _mouse = new MouseHook();

            _left = new ButtonDeviceComponent(this) { Name = "Left", State = ButtonState.Up };
            _right = new ButtonDeviceComponent(this) { Name = "Right", State = ButtonState.Up };
            _middle = new ButtonDeviceComponent(this) { Name = "Middle", State = ButtonState.Up };

            _wheel = new DeltaDeviceComponent(this) { Name = "Wheel" };

            _cursor = new PositionalDeviceComponent(this) { Name = "Cursor" };
        }

        protected override Boolean ConnectImplementation()
        {
            _mouse.Start();

            _mouse.MouseDown += new System.Windows.Forms.MouseEventHandler(_mouse_MouseDown);
            _mouse.MouseUp += new System.Windows.Forms.MouseEventHandler(_mouse_MouseUp);
            _mouse.MouseMove += new System.Windows.Forms.MouseEventHandler(_mouse_MouseMove);
            _mouse.MouseWheel += new System.Windows.Forms.MouseEventHandler(_mouse_MouseWheel);

            return true;
        }

        protected override void DisconnectImplementation()
        {
            _mouse.MouseDown -= _mouse_MouseDown;
            _mouse.MouseUp -= _mouse_MouseUp;
            _mouse.MouseMove -= _mouse_MouseMove;
            _mouse.MouseWheel -= _mouse_MouseWheel;

            _mouse.Stop();
        }

        void _mouse_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Rectangle screenDimensions = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            _cursor.X = (Single)((Single)e.X / (Single)screenDimensions.Width);
            _cursor.Y = (Single)((Single)e.Y / (Single)screenDimensions.Height);

            OnDeviceStateChanged();
        }

        void _mouse_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _wheel.Delta = e.Delta;

            OnDeviceStateChanged();

            _wheel.Delta = 0;
        }

        void _mouse_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    _left.State = ButtonState.Up;
                    break;
                case System.Windows.Forms.MouseButtons.Middle:
                    _middle.State = ButtonState.Up;
                    break;
                case System.Windows.Forms.MouseButtons.None:
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    _right.State = ButtonState.Up;
                    break;
                case System.Windows.Forms.MouseButtons.XButton1:
                    break;
                case System.Windows.Forms.MouseButtons.XButton2:
                    break;
                default:
                    break;
            }

            OnDeviceStateChanged();
        }

        void _mouse_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    _left.State = ButtonState.Down;
                    break;
                case System.Windows.Forms.MouseButtons.Middle:
                    _middle.State = ButtonState.Down;
                    break;
                case System.Windows.Forms.MouseButtons.None:
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    _right.State = ButtonState.Down;
                    break;
                case System.Windows.Forms.MouseButtons.XButton1:
                    break;
                case System.Windows.Forms.MouseButtons.XButton2:
                    break;
                default:
                    break;
            }

            OnDeviceStateChanged();
        }

        public override string ToString()
        {
            return String.Format("Mouse {0}", Index);
        }
    }
}
