using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using CoreGraphics;

namespace Take_Order
{
    public partial class FoodListScreen : UIViewController
	{
        private UIButton _btnAddNewFoodListItem;
        UITableView table;
        TableSource source;
        AddFoodListItem addFoodListItem;

        //loads the FoodListScreen.xib file and connects it to this object
        public FoodListScreen () : base ("FoodListScreen", null)
		{
			this.Title = "Food list";
		}


        public override void ViewDidLoad()
        {
            base.ViewDidLoad(); ;

            _btnAddNewFoodListItem = new UIButton(new CGRect(10, 70, 300, 40));
            _btnAddNewFoodListItem.SetBackgroundImage(UIImage.FromFile("button.png"), UIControlState.Normal);
            _btnAddNewFoodListItem.SetTitleColor(UIColor.White, UIControlState.Normal);
            _btnAddNewFoodListItem.SetTitle("Add New Food", UIControlState.Normal);


            this._btnAddNewFoodListItem.TouchUpInside += (sender, e) =>
            {
                if (this.addFoodListItem == null) { this.addFoodListItem = new AddFoodListItem(); }
                this.NavigationController.PushViewController(this.addFoodListItem, true);
            };

            table = new UITableView(View.Bounds);
            table.AutoresizingMask = UIViewAutoresizing.All;
            CreateTableItems();

            Add(table);
            Add(_btnAddNewFoodListItem);

            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("FoodList.png"));
        }

        void CreateTableItems()
        {
            var tableItems = new string[] {
                    "Beef",
                    "Cheicken",
                    "Pork",
                    "Fish",
                };

            source = new TableSource(tableItems);
            source.Selected += (sender, e) =>
            {
                var alert = UIAlertController.Create("Row Selected", e.Content, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));

                PresentViewController(alert, true, null);

            };

            table.Source = source;
        }
	}
}
