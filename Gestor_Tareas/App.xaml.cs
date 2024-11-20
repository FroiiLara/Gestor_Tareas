using Gestor_Tareas.Views;

namespace Gestor_Tareas
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new Login());  
        }
    }
}
