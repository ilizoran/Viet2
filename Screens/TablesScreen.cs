using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Take_Order
{
    public partial class TablesScreen : UIViewController
	{
        //OrderScreen orderScreen;

        //loads the TablesScreen.xib file and connects it to this object
        public TablesScreen () : base ("TablesScreen", null)
		{
			this.Title = "Tables";
		}

        public override void ViewDidLoad()
        {
           
            base.ViewDidLoad();

            //---- same thing, but for the hello universe screen
            //this.btnTable1.TouchUpInside += (sender, e) => {
            //    if (this.orderScreen == null) { this.orderScreen = new OrderScreen(); }
            //    this.NavigationController.PushViewController(this.orderScreen, true);
            //};

            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("Tables.png"));
        }


	}

}
