using System;
using Android.App;
using Cirrious.MvvmCross.Droid.Views;


namespace Sample.Droid.Views {
    
    [Activity]
    public class CalendarActivity : MvxActivity {

        protected override void OnViewModelSet() {
            base.OnViewModelSet();
            this.SetContentView(Resource.Layout.Calendar);
        }
    }
}