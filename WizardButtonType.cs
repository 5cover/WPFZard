namespace Scover.WPFZard;

/// <summary>The type of a wizard button.</summary>
public enum WizardButtonType
{
    /// <summary>Undoes the effect of the last "Next" button.</summary>
    Back,

    /// <summary>Cancels the wizard and abandons all changes.</summary>
    Cancel,

    /// <summary>Shown on the last page of a wizard. Effectively closes the wizard.</summary>
    Finish,

    /// <summary>Navigates to the next page without commitment.</summary>
    Next
}