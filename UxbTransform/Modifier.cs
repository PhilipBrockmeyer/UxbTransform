using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public abstract class Modifier
    {
        public ModificationBehvaior Behavior { get; set; }

        public Boolean AllowsGesture()
        {
            if (Behavior == ModificationBehvaior.Cancel)
                return !IsActive();
            else if (Behavior == ModificationBehvaior.Required)
                return IsActive();

            return true;
        }

        protected abstract Boolean IsActive();
    }
}
