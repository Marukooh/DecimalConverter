using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            LeftSelect.SelectedIndex = 0;
            RightSelect.SelectedIndex = 0;
        }

        private void OnClick(object sender, RoutedEventArgs e)
         {
            string param = null;
            TextBox otherBox = null;
            int paramType = 0, resultType = 0;
            try
            {
                if (sender.Equals(LeftToRightButton))
                {
                    param = LeftBox.Text;
                    otherBox = RightBox;
                    paramType = Convert.ToInt32(LeftSelect.SelectedValue);
                    resultType = Convert.ToInt32(RightSelect.SelectedValue);
                }
                else
                {
                    param = RightBox.Text;
                    otherBox = LeftBox;
                    paramType = Convert.ToInt32(RightSelect.SelectedValue);
                    resultType = Convert.ToInt32(LeftSelect.SelectedValue);
                }

                ConvertValues(param, otherBox, paramType, resultType);
            } 
            catch
            {
                MessageBox.Show("Errore fatale nell'input", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
            }

         }

        private void ConvertValues(string param, TextBox otherBox, int paramType, int resultType)
        {
            Int64 convertedParam = Convert.ToInt64(param, paramType);
            otherBox.Text = Convert.ToString(convertedParam, resultType);
        }
       
    }

}