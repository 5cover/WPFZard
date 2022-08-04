using System;
using System.Collections.Generic;
using System.Windows;

using Scover.WPFzard;

namespace WPFzardExample;

/// <summary>Interaction logic for App.xaml</summary>
public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        Wizard wizard = new(new List<WizardPage>
        {
            new PageRestorePoint(),
            new PageScriptsReadyToExecute(),
            new PageExecutingScripts(),
            new PageCompleted()
        })
        {
            Title = "My Wizard",
        };
        Environment.ExitCode = Convert.ToInt32(wizard.ShowDialog());
    }
}