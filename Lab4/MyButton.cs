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
    public class MyButton : AbstractButton
    {
        public override void ButtonUp(object sender, MouseButtonEventArgs e)
        {
            _captured = null;
        }

        public override void ButtonDown(object sender, MouseButtonEventArgs e)
        {
            _captured = e.Source as Button;
            _capturePosition = e.GetPosition(this);
        }

        public override void ButtonMove(object sender, MouseEventArgs e)
        {
            if (_captured != null)
            {
                var pos = e.GetPosition(sender as Grid);
                pos.Offset(-_capturePosition.X, -_capturePosition.Y);
                Margin = new Thickness(pos.X, pos.Y, 0, 0);
            }
        }

        public override void DrawImage(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
