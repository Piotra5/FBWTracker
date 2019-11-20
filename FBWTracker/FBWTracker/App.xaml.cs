using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FBWTracker.Services;
using FBWTracker.Views;
using FBWTracker.Data;
using System.IO;

namespace FBWTracker
{
    public partial class App : Application
    {

        static TrackerDatabase trackerDatabase;
            
        public App()
        {
            InitializeComponent();

            DependencyService.Register<FBWDataStore>();
            MainPage = new MainPage();
        }

        public static TrackerDatabase Database
        {
            get
            {
                if (trackerDatabase == null)
                {
                    trackerDatabase = new TrackerDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FBWSQLite.db3"));
                }
                return trackerDatabase;
            }
        }
        public int ResumeAtTrainingId { get; set; }

        protected override void OnStart()
        {
            //Debug.WriteLine("OnStart");

            //// always re-set when the app starts
            //// users expect this (usually)
            ////			Properties ["ResumeAtTodoId"] = "";
            //if (Properties.ContainsKey("ResumeAtTodoId"))
            //{
            //	var rati = Properties["ResumeAtTodoId"].ToString();
            //	Debug.WriteLine("   rati=" + rati);
            //	if (!String.IsNullOrEmpty(rati))
            //	{
            //		Debug.WriteLine("   rati=" + rati);
            //		ResumeAtTodoId = int.Parse(rati);

            //		if (ResumeAtTodoId >= 0)
            //		{
            //			var todoPage = new TodoItemPage();
            //			todoPage.BindingContext = await Database.GetItemAsync(ResumeAtTodoId);
            //			await MainPage.Navigation.PushAsync(todoPage, false); // no animation
            //		}
            //	}
            //}
        }

        protected override void OnSleep()
        {
            Properties["ResumeAtTrainingId"] = ResumeAtTrainingId;
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            //Debug.WriteLine("OnResume");
            //if (Properties.ContainsKey("ResumeAtTodoId"))
            //{
            //	var rati = Properties["ResumeAtTodoId"].ToString();
            //	Debug.WriteLine("   rati=" + rati);
            //	if (!String.IsNullOrEmpty(rati))
            //	{
            //		Debug.WriteLine("   rati=" + rati);
            //		ResumeAtTodoId = int.Parse(rati);

            //		if (ResumeAtTodoId >= 0)
            //		{
            //			var todoPage = new TodoItemPage();
            //			todoPage.BindingContext = await Database.GetItemAsync(ResumeAtTodoId);
            //			await MainPage.Navigation.PushAsync(todoPage, false); // no animation
            //		}
            //	}
            //}
        }
    }
}
