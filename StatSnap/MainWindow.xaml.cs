using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StatSnap;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CalculateStats_Click(object sender, RoutedEventArgs e)
    {
        int[] statsNumberList = new int[] { 1, 4, 3, 4, 5, 7, 7, 8, 9, 10 };

        var sortedArray = statsNumberList.OrderBy(n => n).ToArray();
        int highestNumber = sortedArray.Max();
        int lowestNumber = sortedArray.Min();

        double medianValue;
        int middleNumber = sortedArray.Length / 2;

        if (sortedArray.Length % 2 == 0)
        {
            medianValue = (sortedArray[middleNumber - 1] + sortedArray[middleNumber]) / 2.0;
        }
        else
        {
            medianValue = sortedArray[middleNumber];
        }

        var freq = new Dictionary<int, int>();
        foreach (var item in sortedArray)
        {
            if (freq.ContainsKey(item))
                freq[item]++;
            else
                freq[item] = 1;
        }

        int modeValue = freq.OrderByDescending(f => f.Value).First().Key;

        // Update the UI
        LowestTextBlock.Text = $"Lowest Number: {lowestNumber}";
        HighestTextBlock.Text = $"Highest Number: {highestNumber}";
        MedianTextBlock.Text = $"Median Value: {medianValue}";
        ModeTextBlock.Text = $"Mode Value: {modeValue}";
    }
}