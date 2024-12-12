using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace popupbehavior;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var currentDotnetVersion = Environment.Version;
        var currentAvaloniaVersion = typeof(Button).Assembly.GetName().Version;
        RuntimeInfo.Text = $"Running on .NET {currentDotnetVersion} and Avalonia {currentAvaloniaVersion}";
    }

    private void TogglePopup(object sender, RoutedEventArgs e)
    {
        MyPopup.IsOpen ^= true;

        var panel = (Panel)MyPopup.Child!;
        PopupIsOpenStatus.Text = $"Popup is currently {(MyPopup.IsOpen ? "open" : "closed")}\nPopup.PlacementTarget: {MyPopup.PlacementTarget}\n" +
            $"\nHeight: {panel.Height}\nWidth: {panel.Width}" +
            $"\nDesiredSize: {panel.DesiredSize}\nBounds: {panel.Bounds}";
    }
}
