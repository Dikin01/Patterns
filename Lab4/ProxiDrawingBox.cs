using System.Windows;
using System.Windows.Input;

namespace Lab4
{
    public class ProxiDrawingBox : AbstractDrawingBox
    {
        private AbstractDrawingBox? realDrawingBox;

        public ProxiDrawingBox()
        {
            Content = "Proxi";
            Width = 100;
            Height = 20;
            Margin = new Thickness(200, 100, 0, 0);

            HorizontalAlignment = HorizontalAlignment.Left;
            VerticalAlignment = VerticalAlignment.Top;

            MouseRightButtonUp += DrawImage;
        }

        public override void Release(object sender, MouseButtonEventArgs e)
        {
            IsHold = false;

            initializeRealBox();

            realDrawingBox?.Release(sender, e);
            CopyDrawingBox(realDrawingBox);
        }

        public override void Take(object sender, MouseButtonEventArgs e)
        {
            IsHold = true;

            initializeRealBox();

            realDrawingBox?.Take(this, e);
            CopyDrawingBox(realDrawingBox);
        }

        public override void Move(object sender, MouseEventArgs e)
        {
            if (IsMouseOver)
            {
                if (realDrawingBox == null)
                {
                    realDrawingBox = new DrawingBox(this);
                    CopyDrawingBox(realDrawingBox);
                }
            }

            if (IsHold)
            {
                initializeRealBox();
                realDrawingBox?.Move(sender, e);
                CopyDrawingBox(realDrawingBox);
            }

        }

        public override void DrawImage(object sender, MouseButtonEventArgs e)
        {
            initializeRealBox();

            realDrawingBox?.DrawImage(sender, e);

            CopyDrawingBox(realDrawingBox);
        }

        private void CopyDrawingBox(AbstractDrawingBox? box)
        {
            if (box is null)
                return;

            Height = box.Height;
            Width = box.Width;
            Content = box.Content;
            Background = box.Background;
            Margin = box.Margin;
            HorizontalAlignment = box.HorizontalAlignment;
            VerticalAlignment = box.VerticalAlignment;
            IsHold = box.IsHold;
        }

        private void initializeRealBox()
        {
            if (realDrawingBox is null)
            {
                realDrawingBox = new DrawingBox(this);
            }
        }




    }
}
