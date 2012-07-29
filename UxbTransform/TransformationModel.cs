using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public class TransformationModel
    {
        public ApplicationSet Applications { get; set; }
        public IEnumerable<Device> Devices { get; set; }
    }
}
