using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4
{
    public abstract class AbstractButton : Image
    {
        public object? _captured;
        public Point _capturePosition;

        public abstract void ButtonUp(object sender, MouseButtonEventArgs e);

        public abstract void ButtonDown(object sender, MouseButtonEventArgs e);
        public abstract void ButtonMove(object sender, MouseEventArgs e);

        public abstract void DrawImage(object sender, MouseButtonEventArgs e);
        
    }
}
