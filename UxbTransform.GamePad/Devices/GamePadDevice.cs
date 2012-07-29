using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using UxbTransform.DeviceComponents;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel.Composition;
using System.Timers;
using UxbTransform.CoreExtensions.DeviceComponents;

namespace UxbTransform.GamePad.Devices
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Device("Game Pad", "GamePad")]
    public class GamePadDevice : Device
    {
        System.Timers.Timer  _timer;

        ButtonDeviceComponent _buttonA;
        ButtonDeviceComponent _buttonB;
        ButtonDeviceComponent _buttonX;
        ButtonDeviceComponent _buttonY;
        ButtonDeviceComponent _buttonUp;
        ButtonDeviceComponent _buttonDown;
        ButtonDeviceComponent _buttonLeft;
        ButtonDeviceComponent _buttonRight;
        ButtonDeviceComponent _buttonLeftShoulder;
        ButtonDeviceComponent _buttonRightShoulder;
        ButtonDeviceComponent _buttonLeftStick;
        ButtonDeviceComponent _buttonRightStick;
        ButtonDeviceComponent _buttonBack;
        ButtonDeviceComponent _buttonStart;
        ButtonDeviceComponent _buttonCenter;

        JoystickDeviceComponent _leftStick;
        JoystickDeviceComponent _rightStick;

        TriggerDeviceComponent _leftTrigger;
        TriggerDeviceComponent _rightTrigger;

        public ButtonDeviceComponent ButtonA { get { return _buttonA; } }
        public ButtonDeviceComponent ButtonB { get { return _buttonB; } }
        public ButtonDeviceComponent ButtonX { get { return _buttonX; } }
        public ButtonDeviceComponent ButtonY { get { return _buttonY; } }
        public ButtonDeviceComponent ButtonUp { get { return _buttonUp; } }
        public ButtonDeviceComponent ButtonDown { get { return _buttonDown; } }
        public ButtonDeviceComponent ButtonLeft { get { return _buttonLeft; } }
        public ButtonDeviceComponent ButtonRight { get { return _buttonRight; } }
        public ButtonDeviceComponent ButtonLeftShoulder { get { return _buttonLeftShoulder; } }
        public ButtonDeviceComponent ButtonRightShoulder { get { return _buttonRightShoulder; } }
        public ButtonDeviceComponent ButtonLeftStick { get { return _buttonLeftStick; } }
        public ButtonDeviceComponent ButtonRightStick { get { return _buttonRightStick; } }
        public ButtonDeviceComponent ButtonBack { get { return _buttonBack; } }
        public ButtonDeviceComponent ButtonStart { get { return _buttonStart ; } }
        public ButtonDeviceComponent ButtonCenter { get { return _buttonCenter; } }

        public JoystickDeviceComponent LeftStick{ get { return _leftStick; } }
        public JoystickDeviceComponent RightStick { get { return _rightStick; } }

        public TriggerDeviceComponent LeftTrigger { get { return _leftTrigger; } }
        public TriggerDeviceComponent RightTrigger { get { return _rightTrigger; } }

        public GamePadDevice()
        {            
            _buttonA = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "A" };
            _buttonB = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "B" };
            _buttonX = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "X" };
            _buttonY = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Y" };
            _buttonUp = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Up" };
            _buttonDown = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Down" };
            _buttonLeft = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Left" };
            _buttonRight = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Right" };
            _buttonLeftShoulder = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Left Shoulder" };
            _buttonRightShoulder = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Right Shoulder" };
            _buttonLeftStick = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Left Stick" };
            _buttonRightStick = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Right Stick" };
            _buttonBack = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Back" };
            _buttonStart = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Start" };
            _buttonCenter = new ButtonDeviceComponent(this) { State = UxbTransform.DeviceComponents.ButtonState.Up, Name = "Center" };

            _leftStick = new JoystickDeviceComponent(this) { XAxis = 0.0f, YAxis = 0.0f, Name = "Left Analog" };
            _rightStick = new JoystickDeviceComponent(this) { XAxis = 0.0f, YAxis = 0.0f, Name = "Right Analog" };

            _leftTrigger = new TriggerDeviceComponent(this) { Name = "Left Trigger" };
            _rightTrigger = new TriggerDeviceComponent(this) { Name = "Right Trigger" };
        }

        protected override Boolean ConnectImplementation()
        {
            var state = Microsoft.Xna.Framework.Input.GamePad.GetState((PlayerIndex)Index);
            if (state.IsConnected == false)
                return false;

            _timer = new System.Timers.Timer(40);
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(Update);
            _timer.Start();

            return true;
        }

        protected override void DisconnectImplementation()
        {
            _timer.Stop();
        }

        private void Update(Object sender, ElapsedEventArgs e)
        {
            var state = Microsoft.Xna.Framework.Input.GamePad.GetState((PlayerIndex)Index);

            if (state.IsConnected == false)
                return;

            if (ButtonChanged(state.Buttons.A, _buttonA))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.B, _buttonB))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.X, _buttonX))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.Y, _buttonY))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.DPad.Up, _buttonUp))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.DPad.Down, _buttonDown))
            {
                NotifyChanges(state);
                return;
            }
            
            if (ButtonChanged(state.DPad.Left, _buttonLeft))
            {
                NotifyChanges(state);
                return;
            }
            
            if (ButtonChanged(state.DPad.Right, _buttonRight))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.LeftShoulder, _buttonLeftShoulder))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.RightShoulder, _buttonRightShoulder))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.LeftStick, _buttonLeftStick))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.RightStick, _buttonRightStick))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.Back, _buttonBack))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.Start, _buttonStart))
            {
                NotifyChanges(state);
                return;
            }

            if (ButtonChanged(state.Buttons.BigButton, _buttonCenter))
            {
                NotifyChanges(state);
                return;
            }

            if (JoystickChanged(state.ThumbSticks.Left, _leftStick))
            {
                NotifyChanges(state);
                return;
            }

            if (JoystickChanged(state.ThumbSticks.Right, _rightStick))
            {
                NotifyChanges(state);
                return;
            }

            if (TriggerChanged(state.Triggers.Left, _leftTrigger))
            {
                NotifyChanges(state);
                return;
            }

            if (TriggerChanged(state.Triggers.Right, _rightTrigger))
            {
                NotifyChanges(state);
                return;
            }
        }

        private bool TriggerChanged(Single triggerState , TriggerDeviceComponent trigger)
        {
            if (triggerState != trigger.Position)
                return true;

            return false;
        }

        private Boolean JoystickChanged(Vector2 joystickState, JoystickDeviceComponent joystick)
        {
            if (joystickState.X != joystick.XAxis)
                return true;

            if (joystickState.Y != joystick.YAxis)
                return true;

            return false;
        }

        private void NotifyChanges(GamePadState state)
        {
            lock (this)
            {
                _buttonA.State = state.Buttons.A == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonB.State = state.Buttons.B == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonX.State = state.Buttons.X == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonY.State = state.Buttons.Y == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonUp.State = state.DPad.Up == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonDown.State = state.DPad.Down == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonLeft.State = state.DPad.Left == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonRight.State = state.DPad.Right == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonLeftShoulder.State = state.Buttons.LeftShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonRightShoulder.State = state.Buttons.RightShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonLeftStick.State = state.Buttons.LeftStick == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonRightStick.State = state.Buttons.RightStick == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonBack.State = state.Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonStart.State = state.Buttons.Start== Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;
                _buttonCenter.State = state.Buttons.BigButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed ? UxbTransform.DeviceComponents.ButtonState.Down : UxbTransform.DeviceComponents.ButtonState.Up;

                _leftStick.XAxis = state.ThumbSticks.Left.X; _leftStick.YAxis = -1.0f * state.ThumbSticks.Left.Y;
                _rightStick.XAxis = state.ThumbSticks.Right.X; _rightStick.YAxis = -1.0f * state.ThumbSticks.Right.Y;

                _leftTrigger.Position = state.Triggers.Left;
                _rightTrigger.Position = state.Triggers.Right;
            }

            OnDeviceStateChanged();
        }

        private Boolean ButtonChanged(Microsoft.Xna.Framework.Input.ButtonState buttonState, ButtonDeviceComponent _buttonA)
        {
            if (buttonState == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                return _buttonA.State == UxbTransform.DeviceComponents.ButtonState.Down ? false : true;
            else
                return _buttonA.State == UxbTransform.DeviceComponents.ButtonState.Up ? false : true;
        }
    }
}
