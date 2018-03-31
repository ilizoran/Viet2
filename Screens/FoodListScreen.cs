using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Take_Order
{
    public partial class FoodListScreen : UIViewController
	{
        //loads the FoodListScreen.xib file and connects it to this object
        public FoodListScreen () : base ("FoodListScreen", null)
		{
			this.Title = "Food list";
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("FoodList.png"));
        }
	}
}
