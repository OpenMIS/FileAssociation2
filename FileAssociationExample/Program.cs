namespace BrendanGrant.Helpers.FileAssociation.Example
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
#if NET
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new AssociationGUIForm());
    }
  }
}
