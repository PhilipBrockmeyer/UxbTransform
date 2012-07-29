using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;

namespace UxbTransform
{
    public static class CompositionContainerExtensions
    {
        public static T GetInstance<T>(this CompositionContainer container, Func<Lazy<T, IDictionary<String, Object>>, Boolean> filter)
        {
            var results = container
                .GetExports<T, IDictionary<String, Object>>();

            T result = (from item in results
                        where filter.Invoke(item) == true
                        select item).Single().Value;

            return result;
        }
    }
}
