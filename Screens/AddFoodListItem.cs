using System;

using CoreGraphics;
using UIKit;

namespace Take_Order
{
    public partial class AddFoodListItem : UIViewController
    {
        private UITextView _txtRemark;
        private UILabel _lbRemark;
        private UITextField _tfName;
        private UILabel _lbName;
        private UITextField _tfPrice;
        private UILabel _lbPrice;
        private UIButton _btnAddNewItem;
        FoodListScreen foodListScreen;

        public AddFoodListItem() : base("AddFoodListItem", null)
        {
            this.Title = "Add food" ;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            _lbName = new UILabel(new CGRect(10, 70, 300, 50));
            _lbName.TextColor = UIColor.Black;
            _lbName.Text = "Name:";

            _tfName = new UITextField(new CGRect(10, 120, 300, 40));
            _tfName.BackgroundColor = UIColor.GroupTableViewBackgroundColor;


            _lbPrice = new UILabel(new CGRect(10, 170, 300, 50));
            _lbPrice.TextColor = UIColor.Black;
            _lbPrice.Text = "Price:";

            _tfPrice = new UITextField(new CGRect(10, 220, 300, 40));
            _tfPrice.BackgroundColor = UIColor.GroupTableViewBackgroundColor;

            _lbRemark = new UILabel(new CGRect(10, 270, 300, 50));
            _lbRemark.TextColor = UIColor.Black;
            _lbRemark.Text = "Remark:";

            _txtRemark = new UITextView(new CGRect(10, 320, this.View.Frame.Size.Width, 150));
            _txtRemark.Editable = true;
            _txtRemark.ScrollEnabled = true;

            _txtRemark.BackgroundColor = UIColor.GroupTableViewBackgroundColor;

            _btnAddNewItem = UIButton.FromType(UIButtonType.RoundedRect);
            _btnAddNewItem.Frame = new CGRect(10, 470, 300, 45);
            _btnAddNewItem.SetBackgroundImage(UIImage.FromFile("button.png"), UIControlState.Normal);
            _btnAddNewItem.SetTitleColor(UIColor.White, UIControlState.Normal);
            _btnAddNewItem.SetTitle("Add New Food", UIControlState.Normal);
       

            this._btnAddNewItem.TouchUpInside += (sender, e) => {
                if (this.foodListScreen == null) { this.foodListScreen = new FoodListScreen(); }
                this.NavigationController.PushViewController(this.foodListScreen, true);
            };

            Add(_txtRemark);
            Add(_lbRemark);
            Add(_tfName);
            Add(_lbName);
            Add(_tfPrice);
            Add(_lbPrice);
            Add(_btnAddNewItem);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

