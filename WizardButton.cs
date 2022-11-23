using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;

namespace Scover.WPFZard;

/// <summary>A wizard button shown below a wizard page.</summary>
public class WizardButton : Button
{
    /// <summary>Initializes a new instance of the <see cref="WizardButton"/> class using the specified <see cref="WizardButtonType"/>.</summary>
    /// <exception cref="InvalidEnumArgumentException">
    /// <paramref name="type"/> is not a valid <see cref="WizardButtonType"/> value.
    /// </exception>
    public WizardButton(WizardButtonType type)
    {
        string resourceName = Enum.GetName(type) ?? throw new InvalidEnumArgumentException(nameof(type), (int)type, typeof(WizardButtonType));
        Content = ButtonContents.ResourceManager.GetString(resourceName)!;
        Debug.Assert(Content is not null, $"Missing resource in {nameof(ButtonContents)}: {resourceName}");
        Type = type;
    }

    /// <summary>Initializes a new instance of the <see cref="WizardButton"/> using the specified content.</summary>
    /// <exception cref="ArgumentNullException"><paramref name="content"/> is <see langword="null"/>.</exception>
    public WizardButton(object content) => Content = content ?? throw new ArgumentNullException(nameof(content));

    /// <summary>Gets the type of this wizard button.</summary>
    /// <value>The type of this wizard button, or <see langword="null"/> if this button has custom content.</value>
    internal WizardButtonType? Type { get; }
}