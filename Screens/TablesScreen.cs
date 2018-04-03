using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Take_Order
{

    public partial class TablesScreen : UIViewController
	{
      
        AddOrderScreen addOrderScreen1;
        AddOrderScreen addOrderScreen2;
        AddOrderScreen addOrderScreen3;
        AddOrderScreen addOrderScreen4;

        //loads the TablesScreen.xib file and connects it to this object
        public TablesScreen () : base ("TablesScreen", null)
		{
			this.Title = "Tables";
		}

        public override void ViewDidLoad()
        {
           
            base.ViewDidLoad();

            this.btnTable1.TouchUpInside += (sender, e) => {

                if (this.addOrderScreen1 == null)
                {
                    this.addOrderScreen1 = new AddOrderScreen();
                }
                this.addOrderScreen1.YourString = "1";
                this.NavigationController.PushViewController(this.addOrderScreen1, true);
            };

            this.btnTable2.TouchUpInside += (sender, e) => {
                if (this.addOrderScreen2 == null)
                {
                    this.addOrderScreen2 = new AddOrderScreen();
                }
                this.addOrderScreen2.YourString = "2";
                this.NavigationController.PushViewController(this.addOrderScreen2, true);
            };

            this.btnTable3.TouchUpInside += (sender, e) => {
                
                if (this.addOrderScreen3 == null)
                {
                    this.addOrderScreen3 = new AddOrderScreen();
                }

                this.addOrderScreen3.YourString = "3";
                this.NavigationController.PushViewController(this.addOrderScreen3, true);
            };

            this.btnTable4.TouchUpInside += (sender, e) => {
                if (this.addOrderScreen4 == null)
                {
                    this.addOrderScreen4 = new AddOrderScreen();
                }
                this.addOrderScreen4.YourString = "4";
                this.NavigationController.PushViewController(this.addOrderScreen4, true);
            };


            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("Tables.png"));
        }


	}

}
