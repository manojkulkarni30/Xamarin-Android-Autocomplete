using Android.App;
using Android.Widget;
using Android.OS;

namespace AutoCompleteApp
{
    [Activity(Label = "Technologies", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            string[] technologies = {
                "Android",
                "ASP.NET MVC",
                "ASP.NET Core",
                "Azure",
                "Angular JS",
                "Big Data",
                "Database",
                "HTML5",
                "Internet of Things",
                "Machine Learning",
                "SQL Server",
                "Xamarin"};

            var autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView);

            var adapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, technologies);

            autoCompleteTextView.Adapter = adapter;
        }
    }
}

