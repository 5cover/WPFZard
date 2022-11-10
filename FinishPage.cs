namespace Scover.WPFZard;

/// <summary>A wizard page that concludes the wizard.</summary>
public class FinishPage : WizardPage
{
    /// <inheritdoc/>
    /// <remarks>Includes the "Finish" and "Cancel" buttons.</remarks>
    public override IReadOnlyCollection<WizardButton> Buttons { get; } = new WizardButton[]
    {
        new(WizardButtonType.Finish)
        {
            IsDefault = true
        },
        new(WizardButtonType.Cancel)
        {
            IsCancel = true
        }
    };
}