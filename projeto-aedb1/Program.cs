using projeto_aedb1.Mock;

namespace projeto_aedb1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MockAutor.CarregaAutor();
            MockGenero.CarregaGenero();
            MockEditora.CarregaEditora();
            MockIdioma.CarregaIdioma();
            MockLivro.CarregaLivro();
            MockGerirUsuarios.CarregaGerirUsuarios();

            Application.Run(new FrmMenu());
        }
    }
}