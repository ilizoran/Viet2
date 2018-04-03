using System;
using CoreGraphics;

using UIKit;
using System.Collections.Generic;
using System.Drawing;
using Foundation;



namespace Take_Order
{
    public partial class AddOrderScreen : UIViewController
    {
        private UITextView _txtView;
        private UILabel _label;
        private UIButton _btnAddNewItem;
        AddNewItemScrean addNewItemScrean;

        public string YourString { get; set; }


        public AddOrderScreen() : base("AddOrderScreen", null)
        {
            this.Title = "Add order";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            _label = new UILabel(new CGRect(10, 70, 100, 50));
            _label.TextColor = UIColor.Black;
            _label.Text = "Add order:";

            _btnAddNewItem = UIButton.FromType(UIButtonType.RoundedRect);
            _btnAddNewItem.Frame = new CGRect(10, 120, 300, 50);
            _btnAddNewItem.SetTitle("Add New Item", UIControlState.Normal);


            _txtView = new UITextView(new CGRect(10, 180, 300, 350));
            _txtView.Editable = false;
            _txtView.ScrollEnabled = true;

            _txtView.BackgroundColor = UIColor.Gray;
            _txtView.Text = "Order for table: "  + YourString;


            this._btnAddNewItem.TouchUpInside += (sender, e) => {
                if (this.addNewItemScrean == null) { this.addNewItemScrean = new AddNewItemScrean(); }
                this.NavigationController.PushViewController(this.addNewItemScrean, true);
            };

            Add(_label);
            Add(_txtView);
            Add(_btnAddNewItem);
        }


        public override void ViewDidUnload()
        {
            base.ViewDidUnload();

            // Clear any references to subviews of the main view in order to
            // allow the Garbage Collector to collect them sooner.
            //
            // e.g. myOutlet.Dispose (); myOutlet = null;

            ReleaseDesignerOutlets();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

