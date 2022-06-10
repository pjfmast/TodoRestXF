using System;
using TodoRestXF.Data;
using TodoRestXF.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoRestXF
{
    public partial class App : Application
    {
        public static TodoItemManager TodoManager { get; private set; }

        public App()
        {
            InitializeComponent();

            TodoManager = new TodoItemManager(new RestService());
            MainPage = new NavigationPage(new TodoListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
