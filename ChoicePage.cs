namespace Scover.WPFZard;

/// <summary>A wizard page that gathers information and allows users to make choices.</summary>
public class ChoicePage : WizardPage
{
    /// <inheritdoc/>
    /// <remarks>Includes the "Back", "Next", and "Cancel" buttons.</remarks>
    public override IReadOnlyCollection<WizardButton> Buttons { get; } = new WizardButton[]
    {
        new(WizardButtonType.Back),
        new(WizardButtonType.Next)
        {
            IsDefault = true
        },
        new(WizardButtonType.Cancel)
        {
            IsCancel = true
        }
    };
}