using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Take_Order
{
	public partial class HomeScreen : UIViewController
	{
        FoodListScreen foodListScreen;
        TablesScreen tablesScreen;

		//loads the HomeScreen.xib file and connects it to this object
		public HomeScreen () : base ("HomeScreen", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//---- when the hello world button is clicked
			this.btnFoodList.TouchUpInside += (sender, e) => {
				//---- instantiate a new hello world screen, if it's null (it may not be null if they've navigated
				// backwards from it
                if(this.foodListScreen == null) { this.foodListScreen = new FoodListScreen(); }
				//---- push our hello world screen onto the navigation controller and pass a true so it navigates
                this.NavigationController.PushViewController(this.foodListScreen, true);
			};

			//---- same thing, but for the hello universe screen
			this.btnTables.TouchUpInside += (sender, e) => {
                if(this.tablesScreen == null) { this.tablesScreen = new TablesScreen(); }
                this.NavigationController.PushViewController(this.tablesScreen, true);
			};

            this.NavigationController.NavigationBar.BarTintColor = UIColor.Black;
            this.NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
                    
            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("Menu.png"));
		}

		/// <summary>
		/// Is called when the view is about to appear on the screen. We use this method to hide the
		/// navigation bar.
		/// </summary>
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);
		}

		/// <summary>
		/// Is called when the another view will appear and this one will be hidden. We use this method
		/// to show the navigation bar again.
		/// </summary>
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden (false, animated);
		}


	}
}
