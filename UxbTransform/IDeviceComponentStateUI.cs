using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public interface IDeviceComponentStateUI
    {
        void Initialize(DeviceComponent model);
        void UpdateState();
    }
}
