using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TabControlSample
{
    public class MyContentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate AnotherTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            MyInfo info = item as MyInfo;
            if (info == null) return null;

            if (info.Content.Contains("3"))
            {
                return AnotherTemplate;
            }
            else
            {
                return DefaultTemplate;
            }
        }
    }
}
