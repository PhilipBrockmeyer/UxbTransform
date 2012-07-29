using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("FlickGesture")]
    public class FlickGesture : Gesture
    {
        List<PointF> _pointData;
        ButtonState _previousState;
        
        private readonly Single AngleThreshold;
        private readonly Single DistanceThreshold;

        public FlickGesture()
        {
            AngleThreshold = 0.35f;
            DistanceThreshold = 0.05f;
            _previousState = ButtonState.Up;
            _pointData = new List<PointF>();
        }

        [UserProperty]
        public ButtonDeviceComponent Button { get; set; }

        [UserProperty]
        public PositionalDeviceComponent Cursor { get; set; }

        [UserProperty]
        public Direction FlickDirection { get; set; }

        public override Boolean IsGestureActivated()
        {
            if (Button == null)
                return false;

            if (Cursor == null)
                return false;

            if (Button.State != _previousState)
            {
                _previousState = Button.State;

                if (Button.State == ButtonState.Down)
                    _pointData.Clear();
                else
                    return IsFlick();
            }

            if (Button.State == ButtonState.Down)
                _pointData.Add(new PointF(Cursor.X, Cursor.Y));

            return false;
        }

        private Boolean IsFlick()
        {
            PointF startPoint = _pointData.First();
            PointF finalPoint = _pointData.Last();
            PointF referencePoint = new PointF(startPoint.X, 0f);
            PointF vector = new PointF(finalPoint.X - startPoint.X, finalPoint.Y - startPoint.Y);
            PointF referenceVector = new PointF(referencePoint.X - startPoint.X, referencePoint.Y - startPoint.Y);
            Single vectorLength = (Single)Math.Sqrt((Double)(vector.X * vector.X + vector.Y * vector.Y));
            if (vectorLength < DistanceThreshold)
                return false;

            Single referenceVectorLength = (Single)Math.Sqrt((Double)(referenceVector.X * referenceVector.X + referenceVector.Y * referenceVector.Y));
            Single dotProduct = (vector.X * referenceVector.X + vector.Y * referenceVector.Y);
            var radians = Math.Acos(dotProduct / (vectorLength * referenceVectorLength));

            if (finalPoint.X - startPoint.X < 0)
                radians = (2f * Math.PI) - radians;

                        switch (FlickDirection)
            {
                case Direction.Up:
                    if (radians > 2f * Math.PI - AngleThreshold || radians < AngleThreshold)
                        return true;
                    break;

                case Direction.Down:
                    if (radians > Math.PI - AngleThreshold && radians < Math.PI + AngleThreshold)
                        return true;
                    break;

                case Direction.Left:
                    if (radians > 1.5f * Math.PI - AngleThreshold && radians < 1.5f * Math.PI + AngleThreshold)
                        return true;
                    break;

                case Direction.Right:
                    if (radians > 0.5f * Math.PI - AngleThreshold && radians < 0.5f * Math.PI + AngleThreshold)
                        return true;

                    break;
                default:
                    return false;
            }

            return false;
        }


        public override String ToString()
        {
            return "flicks " + Enum.GetName(typeof(Direction), FlickDirection);
        }
    }
}
