using System.Windows;
using MahApps.Metro;
using MahApps.Metro.Controls;

namespace WpfApp3
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : MetroWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void BlueOnWhite(object sender, RoutedEventArgs args)
      => ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Cobalt"), ThemeManager.GetAppTheme("BaseLight"));

    private void RedOnBlack(object sender, RoutedEventArgs args)
      => ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Crimson"), ThemeManager.GetAppTheme("BaseDark"));
  }
}