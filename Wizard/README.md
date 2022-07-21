# Wizard

A simple WPF wizard helper that uses page navigation. Open for extension.

## How to use?

Wizard is very simple to use. Here is an example of a simple wizard with 3 pages:

````csharp
Wizard wizard = new(new List<WizardPage>
{
    new Page1(),
    new Page2(),
    new Page3(),
    new Page4()
})
{
    Title = "My Wizard",
};
_ = wizard.ShowDialog();
```
And here's a simplistic page definition:

```xaml
<Page
    x:Class="Page1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d">
    This is the first page.
</Page>

It's up to you to add custom content to theses pages in order to create a functionning wizard.

Also, don't forget to set your base page class to ``Scover.Wizard.WizardPage`` instead of the default ``System.Windows.Controls.Page``.

As an alternative, you can inherit from ``Scover.Wizard.FinishPage`` or ``Scover.Wizard.ChoicePage`` to have the buttons already defined.