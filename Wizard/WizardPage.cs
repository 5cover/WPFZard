using System.Windows.Controls;

namespace Scover.WPFzard;

/// <summary>A wizard page with buttons.</summary>
public abstract class WizardPage : Page
{
    /// <summary>Gets the buttons of this instance.</summary>
    /// <value>The buttons that will be shown below this page.</value>
    public abstract IReadOnlyCollection<WizardButton> Buttons { get; }
}