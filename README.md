![WPFZard logo](wizard.png)
 
 # WPFZard

A simple WPF wizard helper that uses page navigation. Open for extension.

## How to use?

WPFZard is very simple to use. Here is an example of a simple wizard with 3 pages:

```csharp
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
Since ``Wizard`` inherits from ``Window``, we can use all the common window properties there.

And here's a simplistic page definition:

```xaml
<wizard:WizardPage
    x:Class="Page1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:wizard="clr-namespace:Scover;assembly=Scover.WpfZard"
    mc:Ignorable="d">
    This is the first page.
</wizard:WizardPage>
```

It's up to you to add custom content to theses pages in order to create a functionning wizard.

As an alternative, you can inherit from ``Scover.WPFzard.FinishPage`` or ``Scover.WPFzard.ChoicePage`` to have the buttons already defined.
