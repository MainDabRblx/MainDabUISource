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
using System.Windows.Shapes;

namespace MainDab
{
    /// <summary>
    /// Interaction logic for CustomDLLSelection.xaml
    /// </summary>
    
    public partial class CustomDLLSelection : Window
    {
        public CustomDLLSelection()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            MainDabWPF.Injection.Functions.exploitdllname = DLLNAME.Text;
            MainDabWPF.Injection.NamedPipes.luapipename = Pipe.Text;
            ((MainWindow)this.Owner).ChangeDLLContentsToCustom();
            this.Visibility = Visibility.Collapsed;
            base.Close();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
            
        }
    }
}
