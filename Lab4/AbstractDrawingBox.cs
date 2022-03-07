using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab4
{
    public abstract class AbstractDrawingBox : Button
    {
        public System.Drawing.Image? Image;
        protected string ImagePath = "C:/Users/User/Desktop/Patterns/Lab4/Untitled.jpeg";
        protected Point capturePosition;
        public bool IsHold { protected set; get; }
        public ImageBrush? imageBrush { get; private set; }
        public abstract void Release(object sender, MouseButtonEventArgs e);

        public abstract void Take(object sender, MouseButtonEventArgs e);
        public abstract void Move(object sender, MouseEventArgs e);

        public abstract void DrawImage(object sender, MouseButtonEventArgs e);

    }
}
