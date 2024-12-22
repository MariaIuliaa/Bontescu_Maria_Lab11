using BontescuMariaLab11.Data;

namespace BontescuMariaLab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            InitializeComponent();
            Database = new ShoppingListDatabase(new RestService());
            //MainPage = new AppShell();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}