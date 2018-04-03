using System;
using CoreGraphics;

using UIKit;
using System.Collections.Generic;
using System.Drawing;
using Foundation;


namespace Take_Order
{
    public partial class AddNewItemScrean : UIViewController
    {
        private UIButton _btnAddNewItem1;
        private UILabel _label1;
        private UIButton _btnAddNewItem2;
        private UILabel _label2;

        public AddNewItemScrean() : base("AddNewItemScrean", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            _label1 = new UILabel(new CGRect(10, 70, 145, 50));
            _label1.TextColor = UIColor.Black;
            _label1.Text = "1. Chiken";

            _btnAddNewItem1 = UIButton.FromType(UIButtonType.RoundedRect);
            _btnAddNewItem1.Frame = new CGRect(165, 70, 145, 50);
            _btnAddNewItem1.SetTitle("Add New Item", UIControlState.Normal);

            _label2 = new UILabel(new CGRect(10, 120, 145, 50));
            _label2.TextColor = UIColor.Black;
            _label2.Text = "2. Beef:";

            _btnAddNewItem2 = UIButton.FromType(UIButtonType.RoundedRect);
            _btnAddNewItem2.Frame = new CGRect(165, 120, 145, 50);
            _btnAddNewItem2.SetTitle("Add New Item", UIControlState.Normal);

            Add(_label1);
            Add(_label2);
            Add(_btnAddNewItem1);
            Add(_btnAddNewItem2);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

