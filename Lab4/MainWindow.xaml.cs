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
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Grid.PreviewMouseMove += OnMouseMove;
            Grid.PreviewMouseLeftButtonDown += OnMouseDown;
            Grid.PreviewMouseLeftButtonUp += OnMouseUp;
        }

        private object? _captured;
        private Point _capturePosition;

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _captured = null;            
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _captured = e.Source as Button;
            _capturePosition = e.GetPosition(Button);            
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_captured != null)
            {
                var pos = e.GetPosition(Grid);                  
                pos.Offset(-_capturePosition.X, -_capturePosition.Y);
                Button.Margin = new Thickness(pos.X, pos.Y, 0, 0);                
            }
        }
    }
}
