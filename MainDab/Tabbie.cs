using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MainDab
{
    static class TabFunction
    {
        public static T GetTemplateItem<T>(this Control elem, string name)
        {
            return elem.Template.FindName(name, (FrameworkElement)elem) is T name1 ? name1 : default(T);
        }
    }
}
