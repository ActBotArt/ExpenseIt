using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ExpenseIt
{
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что пользователь выбрал элемент в списке
            if (peopleListBox.SelectedItem != null)
            {
                // Создаём экземпляр страницы отчёта, передавая выбранного человека
                ExpenseReportPage expenseReportPage = new ExpenseReportPage(peopleListBox.SelectedItem);

                // Навигация на страницу отчёта
                NavigationService.Navigate(expenseReportPage);
            }
            else
            {
                // Если пользователь не выбрал сотрудника, показываем предупреждение
                MessageBox.Show(
                    "Please select a person from the list.",
                    "Selection Required",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
            }
        }
    }
}
