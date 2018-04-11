using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using CoreGraphics;
using System.CodeDom.Compiler;

using UIKit;

namespace Take_Order
{
    public partial class FoodListScreen : UIViewController
	{
        private UIButton _btnAddFoodItem;
        private UIButton _btnAddBeefItem;

        AddFoodListItemScreen addFoodListItemScreen;
        EditFoodListScreen editFoodListScreen;

        //loads the FoodListScreen.xib file and connects it to this object
        public FoodListScreen () : base ("FoodListScreen", null)
		{

			this.Title = "Food list";

		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _btnAddFoodItem = UIButton.FromType(UIButtonType.RoundedRect);
            _btnAddFoodItem.Frame = new CGRect(10, 70, 300, 45);
            _btnAddFoodItem.SetBackgroundImage(UIImage.FromFile("button.png"), UIControlState.Normal);
            _btnAddFoodItem.SetTitleColor(UIColor.White, UIControlState.Normal);
            _btnAddFoodItem.SetTitle("Add Food Item", UIControlState.Normal);

            this._btnAddFoodItem.TouchUpInside += (sender, e) => {
                if (this.addFoodListItemScreen == null) { this.addFoodListItemScreen = new AddFoodListItemScreen(); }
                this.NavigationController.PushViewController(this.addFoodListItemScreen, true);
            };

            _btnAddBeefItem = UIButton.FromType(UIButtonType.RoundedRect);
            _btnAddBeefItem.Frame = new CGRect(10, 140, 300, 45);
            _btnAddBeefItem.SetTitle("Beef", UIControlState.Normal);

            this._btnAddBeefItem.TouchUpInside += (sender, e) => {
                if (this.editFoodListScreen == null) { this.editFoodListScreen = new EditFoodListScreen(); }
                this.NavigationController.PushViewController(this.editFoodListScreen, true);
            };

            // TODO - add list of food items


            //this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("FoodList.png"));

            Add(_btnAddFoodItem);
            Add(_btnAddBeefItem);
        }
	}
}
