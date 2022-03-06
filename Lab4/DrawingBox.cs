using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Lab4
{
    public class DrawingBox : AbstractDrawingBox
    {
        public DrawingBox()
        {
            Content = "Real object";
            Width = 100;
            Height = 20;
            Margin = new Thickness(400, 100, 0, 0);

            HorizontalAlignment = HorizontalAlignment.Left;
            VerticalAlignment = VerticalAlignment.Top;
            IsHold = false;

            MouseRightButtonUp += DrawImage;
        }

        public DrawingBox(AbstractDrawingBox button)
        {
            Content = "Create real object";
            Width = button.Width;
            Height = button.Height;
            Margin = button.Margin;
            Background = button.Background;

            HorizontalAlignment = button.HorizontalAlignment;
            VerticalAlignment = button.VerticalAlignment;

            IsHold = button.IsHold;
        }

        public override void Take(object sender, MouseButtonEventArgs e)
        {
            IsHold = true;
            capturePosition = e.GetPosition(sender as IInputElement);
        }

        public override void Move(object sender, MouseEventArgs e)
        {
            if (IsHold)
            {
                var pos = e.GetPosition(sender as Grid);
                pos.Offset(-capturePosition.X, -capturePosition.Y);
                Margin = new Thickness(pos.X, pos.Y, 0, 0);
            }
        }

        public override void Release(object sender, MouseButtonEventArgs e)
        {
            IsHold = false;
        }

        public override void DrawImage(object sender, MouseButtonEventArgs e)
        {
            if (Image is null)
            {
                Image = System.Drawing.Image.FromFile(ImagePath);
                Height = Image.Height;
                Width = Image.Width;

                BitmapImage theImage = new BitmapImage
                (new Uri(ImagePath, UriKind.Absolute));

                ImageBrush myImageBrush = new ImageBrush(theImage);

                Background = myImageBrush;
            }
        }
    }
}
