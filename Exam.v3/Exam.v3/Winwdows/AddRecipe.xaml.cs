using Exam.v3.Model;
using Exam.v3.ViewModel;
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

namespace Exam.v3.Winwdows
{
    /// <summary>
    /// Логика взаимодействия для AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Window
    {
        public Recipe Recipe { get; set; }
        //public List dishTypes { get; set; }
        public AddRecipe(Recipe r)
        {
            InitializeComponent();
            Recipe = r;
            DataContext = Recipe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
