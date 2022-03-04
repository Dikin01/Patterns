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
using System.Drawing;

namespace Lab4
{
    public class ProxiButton : AbstractButton
    {
        private MyButton myButton;
        private Bitmap image;

        private double height;
        private double width;

        public override void ButtonUp(object sender, MouseButtonEventArgs e)
        {          

            myButton._captured = null;
        }

        public override void ButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (myButton == null)
            {
                myButton = new MyButton();
                image = new Bitmap("back.jpg");
                height = image.Height;
                width = image.Width;
            }
            myButton._captured = e.Source as Button;
            myButton._capturePosition = e.GetPosition(this);
        }

        public override void ButtonMove(object sender, MouseEventArgs e)
        {
            if (_captured != null)
            {
                var pos = e.GetPosition(sender as Grid);
                pos.Offset(-myButton._capturePosition.X, -myButton._capturePosition.Y);
                myButton.Margin = new Thickness(pos.X, pos.Y, 0, 0);
            }
        }

        public override void DrawImage(object sender, MouseButtonEventArgs e)
        {
            if(height == 0 && width == 0)
            {
                height = image.Height;
                width = image.Width;
            }

            BitmapImage theImage = new BitmapImage
                (new Uri("/back.jpg", UriKind.Relative));

            ImageBrush myImageBrush = new ImageBrush(theImage);
            this.Source = theImage;



        }
    }
}
