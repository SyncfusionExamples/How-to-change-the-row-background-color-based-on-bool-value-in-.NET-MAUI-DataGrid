using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void SfDataGrid_CellTapped(object sender, DataGridCellTappedEventArgs e)
        {
            if (e.RowData != null && viewModel.Employees.Contains(e!.RowData))
            {
                int index = viewModel.Employees.IndexOf((e.RowData as Employee)!);
                viewModel.Employees[index].EmployeeStatus = !viewModel.Employees[index].EmployeeStatus;
            }
        }
    }
}
