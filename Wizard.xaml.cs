using System.Windows;
using System.Windows.Controls;

namespace Scover.WPFZard;

/// <summary>A Windows wizard that uses page navigation.</summary>
public partial class Wizard : Window
{
    private int _index;

    /// <summary>Initializes a new instance of the <see cref="Wizard"/> class.</summary>
    /// <param name="pages">The pages to add to the wizard.</param>
    /// <exception cref="ArgumentNullException"><paramref name="pages"/> is <see langword="null"/>.</exception>
    public Wizard(IReadOnlyList<WizardPage> pages)
    {
        InitializeComponent();
        Pages = pages ?? throw new ArgumentNullException(nameof(pages));
        PageIndex = 0;
    }

    /// <summary>Gets the pages of this wizard.</summary>
    /// <value>The pages of this wizard.</value>
    public IReadOnlyList<WizardPage> Pages { get; } = new List<WizardPage>();

    /// <summary>Gets or sets the page index.</summary>
    /// <value>The index of the page in <see cref="Pages"/> that is currently being shown.</value>
    protected int PageIndex
    {
        get => _index;
        set
        {
            RemoveButtons();
            AddButtons(value);

            _ = Frame.Navigate(Pages[value]);
            _index = value;
        }
    }

    private void AddButtons(int pageIndex)
    {
        foreach (WizardButton button in Pages[pageIndex].Buttons)
        {
            button.Click += GetClickEvent(button);
            SetVisibility(button, pageIndex);
            button.Style = (Style)Resources["ButtonStyle"];
            _ = Buttons.Children.Add(button);
        }
    }

    private RoutedEventHandler GetClickEvent(WizardButton button) => button.Type switch
    {
        WizardButtonType.Back => (_, _) => --PageIndex,
        WizardButtonType.Cancel => (_, _) => DialogResult = false,
        WizardButtonType.Finish => (_, _) => DialogResult = true,
        _ => (_, _) => ++PageIndex,
    };

    private void RemoveButtons()
    {
        foreach (WizardButton button in Buttons.Children)
        {
            button.Click -= GetClickEvent(button);
        }
        Buttons.Children.Clear();
    }

    private void SetVisibility(WizardButton button, int pageIndex)
    {
        bool isLastPage = pageIndex == Pages.Count - 1;
        bool isFirstPage = pageIndex == 0;

        switch (button.Type)
        {
            case WizardButtonType.Back:
                SetVisibleWhen(!isFirstPage);
                break;

            case WizardButtonType.Cancel:
                SetVisibleWhen(!isLastPage);
                break;

            case WizardButtonType.Finish:
                SetVisibleWhen(isLastPage);
                break;

            case WizardButtonType.Next:
                SetVisibleWhen(!isLastPage);
                break;
        }
        void SetVisibleWhen(bool visibleElseCollapsed) => button.Visibility = visibleElseCollapsed ? Visibility.Visible : Visibility.Collapsed;
    }
}