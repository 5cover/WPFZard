using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

using Scover.WPFzard;

namespace WPFzardExample;

/// <summary>Logique d'interaction pour PageExecutingScripts.xaml</summary>
public partial class PageExecutingScripts : WizardPage
{
    private static readonly WizardButton _next = new(WizardButtonType.Next) { IsEnabled = false };

    public PageExecutingScripts() => InitializeComponent();

    public override IReadOnlyCollection<WizardButton> Buttons { get; } = new List<WizardButton>()
    {
        new(WizardButtonType.Back){IsEnabled = false},
        _next,
        new(WizardButtonType.Cancel){IsEnabled = false},
    };

    private async void Page_Loaded(object sender, EventArgs e)
    {
        for (int i = 0; i < 100; i++)
        {
            pbStatus.Value++;
            await Task.Delay(100);
        }
        _next.RaiseEvent(new(ButtonBase.ClickEvent));
    }
}