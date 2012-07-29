using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiimoteLib;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;

namespace UxbTransform.Wiimote.Devices
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Device("Wiimote", "WiimoteDevice")]
    public class WiimoteDevice : Device
    {
        WiimoteLib.Wiimote _wiimote;

        // Wiimote Buttons
        ButtonDeviceComponent _buttonA;
        ButtonDeviceComponent _buttonB;
        ButtonDeviceComponent _buttonMinus;
        ButtonDeviceComponent _buttonPlus;
        ButtonDeviceComponent _buttonUp;
        ButtonDeviceComponent _buttonDown;
        ButtonDeviceComponent _buttonLeft;
        ButtonDeviceComponent _buttonRight;
        ButtonDeviceComponent _button1;
        ButtonDeviceComponent _button2;
        ButtonDeviceComponent _buttonHome;

        public ButtonDeviceComponent ButtonA { get { return _buttonA; } }
        public ButtonDeviceComponent ButtonB { get { return _buttonB; } }
        public ButtonDeviceComponent ButtonMinus { get { return _buttonMinus; } }
        public ButtonDeviceComponent ButtonPlus { get { return _buttonPlus; } }
        public ButtonDeviceComponent ButtonUp { get { return _buttonUp; } }
        public ButtonDeviceComponent ButtonDown { get { return _buttonDown; } }
        public ButtonDeviceComponent ButtonLeft { get { return _buttonLeft; } }
        public ButtonDeviceComponent ButtonRight { get { return _buttonRight; } }
        public ButtonDeviceComponent Button1 { get { return _button1; } }
        public ButtonDeviceComponent Button2 { get { return _button2; } }
        public ButtonDeviceComponent ButtonHome { get { return _buttonHome; } }

        // Classic Controller Buttons
        ButtonDeviceComponent _classicUp;
        ButtonDeviceComponent _classicDown;
        ButtonDeviceComponent _classicLeft;
        ButtonDeviceComponent _classicRight;

        public ButtonDeviceComponent ClassicUp { get { return _classicUp; } }
        public ButtonDeviceComponent ClassicDown { get { return _classicDown; } }
        public ButtonDeviceComponent ClassicLeft { get { return _classicLeft; } }
        public ButtonDeviceComponent ClassicRight { get { return _classicRight; } }

        // Cartesian Inputs
        PositionalDeviceComponent _irComponent;
        AccelerometerDeviceComponent _accelerometer;

        public PositionalDeviceComponent IRComponent { get { return _irComponent; } }
        public AccelerometerDeviceComponent Accelerometer { get { return _accelerometer; } }

        public WiimoteDevice()
        {
            _wiimote = new WiimoteLib.Wiimote();

            _buttonA = new ButtonDeviceComponent(this) { Name = "A" };
            _buttonB = new ButtonDeviceComponent(this) { Name = "B" };
            _buttonMinus = new ButtonDeviceComponent(this) { Name = "Minus" };
            _buttonPlus = new ButtonDeviceComponent(this) { Name = "Plus" };
            _buttonUp = new ButtonDeviceComponent(this) { Name = "Up" };
            _buttonDown = new ButtonDeviceComponent(this) { Name = "Down" };
            _buttonLeft = new ButtonDeviceComponent(this) { Name = "Left" };
            _buttonRight = new ButtonDeviceComponent(this) { Name = "Right" };
            _button1 = new ButtonDeviceComponent(this) { Name = "1" };
            _button2 = new ButtonDeviceComponent(this) { Name = "2" };
            _buttonHome = new ButtonDeviceComponent(this) { Name = "Home" };

            _classicUp = new ButtonDeviceComponent(this) { Name = "Classic Up" };
            _classicDown = new ButtonDeviceComponent(this) { Name = "Classic Down" };
            _classicLeft = new ButtonDeviceComponent(this) { Name = "Classic Left" };
            _classicRight = new ButtonDeviceComponent(this) { Name = "Classic Right" };

            _irComponent = new PositionalDeviceComponent(this) { Name = "IR" };
            _accelerometer = new AccelerometerDeviceComponent(this) { Name = "Accelerometer" };
        }

        void _wiimote_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            _buttonA.State = _wiimote.WiimoteState.ButtonState.A ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonB.State = _wiimote.WiimoteState.ButtonState.B ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonMinus.State = _wiimote.WiimoteState.ButtonState.Minus ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonPlus.State = _wiimote.WiimoteState.ButtonState.Plus ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonUp.State = _wiimote.WiimoteState.ButtonState.Up ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonDown.State = _wiimote.WiimoteState.ButtonState.Down ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonLeft.State = _wiimote.WiimoteState.ButtonState.Left ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonRight.State = _wiimote.WiimoteState.ButtonState.Right ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _button1.State = _wiimote.WiimoteState.ButtonState.One ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _button2.State = _wiimote.WiimoteState.ButtonState.Two ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _buttonHome.State = _wiimote.WiimoteState.ButtonState.Home ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;

            _classicUp.State = _wiimote.WiimoteState.ClassicControllerState.ButtonState.Up ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _classicDown.State = _wiimote.WiimoteState.ClassicControllerState.ButtonState.Down ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _classicRight.State = _wiimote.WiimoteState.ClassicControllerState.ButtonState.Left ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
            _classicLeft.State = _wiimote.WiimoteState.ClassicControllerState.ButtonState.Right ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;

            _irComponent.X = 1.0F - _wiimote.WiimoteState.IRState.Midpoint.X;
            _irComponent.Y = _wiimote.WiimoteState.IRState.Midpoint.Y;

            _accelerometer.XAxis = _wiimote.WiimoteState.AccelState.Values.X;
            _accelerometer.YAxis = _wiimote.WiimoteState.AccelState.Values.Y;
            _accelerometer.ZAxis = _wiimote.WiimoteState.AccelState.Values.Z;

            OnDeviceStateChanged();
        }

        protected override Boolean ConnectImplementation()
        {
            _wiimote.Connect();

            _wiimote.SetReportType(InputReport.IRAccel, true);
            _wiimote.WiimoteChanged += new EventHandler<WiimoteChangedEventArgs>(_wiimote_WiimoteChanged);

            return true;
        }

        protected override void DisconnectImplementation()
        {
            _wiimote.Disconnect();
        }

        public override String ToString()
        {
            return String.Format("Wiimote {0}", Index);
        }
    }
}
