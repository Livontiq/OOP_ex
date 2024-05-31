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

namespace ecx
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        public PageAdd()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(carCost.Text.ToString()) || 
                String.IsNullOrEmpty(carNumber.Text.ToString()) || 
                String.IsNullOrEmpty(carType.Text.ToString()) || 
                String.IsNullOrEmpty(carStatus.Text.ToString()))
            {
                MessageBox.Show("Добавлено");
            }
            else
            {
                var lastId = appFrame.carsList.ToList().Capacity;
                try
                {
                    Cars newcars = new Cars()
                    {
                        id = lastId,
                        carNumber = carNumber.Text.ToString(),
                        carCost = carCost.Text.ToString(),
                        carStatus = carStatus.Text.ToString(),
                        carType = carType.Text.ToString()
                    };
                    appFrame.carsList.Add(newcars);
                    MessageBox.Show("Добавление успешно");
                    appFrame.MainFrame.Navigate(new Page1());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            appFrame.MainFrame.Navigate(new Page1());
        }
    }
}
