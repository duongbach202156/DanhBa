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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        void UpdateData()
        {
            this.MainTable.ItemsSource = null;
            this.MainTable.ItemsSource = Demo.DanhBa;
        }
        public Window1()
        {
            InitializeComponent();
            ButtonCreate.Click += (s, e) => {
                var item = new DanhBa();
                var frm = new InputFormWindow { 
                    DataContext = item,
                    Title = "Thêm danh bạ"
                };
                if (frm.ShowDialog() == true)
                {
                    Demo.DanhBa.Add(item);
                    UpdateData();
                }
            };
            ButtonDelete.Click += (s, e) => {
                var item = (DanhBa)MainTable.SelectedItem;
                if (item == null)
                {
                    MessageBox.Show("Select an item first", "System");
                    return;
                }

                var res = MessageBox.Show("Are you sure to delete selected item?", "System", MessageBoxButton.YesNo);
                if (res == MessageBoxResult.Yes)
                {
                    Demo.DanhBa.Remove(item);
                    UpdateData();
                }    
            };
            MainTable.MouseDoubleClick += (s, e) => {
                var item = (DanhBa)MainTable.SelectedItem;
                var frm = new InputFormWindow
                {
                    DataContext = item,
                    Title = "Chỉnh sửa danh bạ"
                };
                if (frm.ShowDialog() == true)
                {
                }
            };


            UpdateData();
        }
    }
}
