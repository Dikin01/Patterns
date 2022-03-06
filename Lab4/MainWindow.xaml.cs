using System.Windows;
using System.Windows.Controls;

namespace Lab4
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            var Button = new ProxiDrawingBox();
            Grid.Children.Add(Button);

            Grid.PreviewMouseMove += Button.Move;
            Grid.PreviewMouseLeftButtonDown += Button.Take;
            Grid.PreviewMouseLeftButtonUp += Button.Release;           
        }
    }
}
