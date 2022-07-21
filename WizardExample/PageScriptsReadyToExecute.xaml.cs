using System.Collections.Generic;

using Scover.WPFzard;

namespace WPFzardExample;

/// <summary>Logique d'interaction pour PageExecutingScripts.xaml</summary>
public partial class PageScriptsReadyToExecute : WizardPage
{
    public PageScriptsReadyToExecute() => InitializeComponent();

    public override IReadOnlyCollection<WizardButton> Buttons { get; } = new List<WizardButton>()
    {
        new(WizardButtonType.Back),
        new("Execute scripts"),
        new(WizardButtonType.Cancel)
    };
}