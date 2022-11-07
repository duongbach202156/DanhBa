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

namespace WDFDemo
{
    /// <summary>
    /// Interaction logic for InputFormWindow.xaml
    /// </summary>
    public partial class InputFormWindow : Window
    {
        public InputFormWindow()
        {
            InitializeComponent();

            ButtonCancel.Click += (s, e) => this.Close();
            ButtonSave.Click += (s, e) => {
                var item = (DanhBa)DataContext;
                item.SoDT = SoDTBox.Text;
                item.Ten = TenBox.Text;

                this.DialogResult = true;
            };
        }
    }
}
