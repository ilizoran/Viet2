using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Take_Order
{
    public partial class TablesScreen : UIViewController
	{
        //loads the TablesScreen.xib file and connects it to this object
        public TablesScreen () : base ("TablesScreen", null)
		{
			this.Title = "Tables";
		}

        public override void ViewDidLoad()
        {
           
            base.ViewDidLoad();

            btnTable1.Layer.CornerRadius = 10; 
            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("Tables.png"));
        }


	}

}
