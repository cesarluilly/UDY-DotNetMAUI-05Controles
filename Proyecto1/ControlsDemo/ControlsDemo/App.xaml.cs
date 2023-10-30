using ControlsDemo.Pages;

namespace ControlsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new PresentationControlsDemo();
            //MainPage = new CommandsControlsDemo();
            //MainPage = new InputControlsDemo();
            //MainPage = new TextControlsDemo();
            //MainPage = new ActivityControlsDemo();
            //MainPage = new CollectionsControlsDemo();
            //MainPage = new CollectionsControlsDemo2ListView();
            //MainPage = new CollectionsControlsDemo3CollectionView();
            //MainPage = new CollectionsControlsDemo4Picker();
            //MainPage = new CollectionsControlsDemo5TableView();

            //                                              //Pagina de tipo ContentPage utilizando Navegacion.
            var navPage = new NavigationPage(new Init());
            navPage.BarBackground = Colors.CadetBlue;
            MainPage = navPage;
        }
    }
}