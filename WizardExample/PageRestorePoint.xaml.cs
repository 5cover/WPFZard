using System.ComponentModel;
using System.Windows;

using Scover.WPFzard;

namespace WPFzardExample;

/// <summary>Logique d'interaction pour PageRestorePoint.xaml</summary>
public partial class PageRestorePoint : ChoicePage, INotifyPropertyChanged
{
    private bool isSystemRestoreEnabled;

    public PageRestorePoint() => InitializeComponent();

    public event PropertyChangedEventHandler? PropertyChanged;

    public bool IsSystemRestoreEnabled
    {
        get => isSystemRestoreEnabled;
        set
        {
            isSystemRestoreEnabled = value;
            PropertyChanged?.Invoke(this, new(nameof(IsSystemRestoreEnabled)));
        }
    }

    private void ButtonEnableSystemRestore_Click(object sender, RoutedEventArgs e) => IsSystemRestoreEnabled = true;
}