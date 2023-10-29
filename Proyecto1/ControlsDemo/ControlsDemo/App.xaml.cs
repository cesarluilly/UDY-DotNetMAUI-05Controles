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
            MainPage = new ActivityControlsDemo();
        }
    }
}