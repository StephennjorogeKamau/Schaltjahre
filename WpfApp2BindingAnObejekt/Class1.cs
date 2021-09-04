using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2BindingAnObejekt
{
    class Class1 : MainWindow
    {
        public int MyProgress { get; set; }
        public Class1()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slider1.Value > 50) txb2.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }
    }
}
