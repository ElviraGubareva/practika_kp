using System;
using System.Windows;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
namespace z2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public ChartValues<double> Values1 { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SeriesCollection series = new SeriesCollection();
                double xMin = double.Parse(textboxXmin.Text);
                double xMax = double.Parse(Xmax.Text);
                double step = double.Parse(Step.Text);
                ChartValues<double> cv1 = new ChartValues<double>();
                ChartValues<double> cv2 = new ChartValues<double>();
                double coord = 0;
                for (double i = xMin; i <= xMax; i += step)
                {
                    double result = Math.Pow(i, 3);
                    cv2.Add(coord++);
                    cv1.Add(result);

                }
                LineSeries line = new LineSeries();
                line.Values = cv1;
                series.Add(line);
                cartChart.Series = series;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cartChart_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
