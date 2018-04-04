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
        private UIButton _btnAddNewItem;
        AddNewItemScrean addNewItemScrean;

        public string YourString { get; set; }


        public AddOrderScreen() : base("AddOrderScreen", null)
        {
            this.Title = "Add order " + YourString;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //_label = new UILabel(new CGRect(10, 70, 100, 50));
            //_label.TextColor = UIColor.Black;
            //_label.Text = "Add order:";

            _btnAddNewItem = UIButton.FromType(UIButtonType.RoundedRect);
            _btnAddNewItem.Frame = new CGRect(10, 70, 300, 45);
            _btnAddNewItem.SetBackgroundImage(UIImage.FromFile("button.png"), UIControlState.Normal);
            _btnAddNewItem.SetTitleColor(UIColor.White, UIControlState.Normal);
            _btnAddNewItem.SetTitle("Add New Item", UIControlState.Normal);

            _txtView = new UITextView(new CGRect(0, 120, this.View.Frame.Size.Width, this.View.Frame.Size.Height));

            _txtView.Editable = false;
            _txtView.ScrollEnabled = true;

            _txtView.BackgroundColor = UIColor.GroupTableViewBackgroundColor;
            _txtView.Text = "Order for table: "  + YourString;

            this.Title += " - T" +  YourString;


            this._btnAddNewItem.TouchUpInside += (sender, e) => {
                if (this.addNewItemScrean == null) { this.addNewItemScrean = new AddNewItemScrean(); }
                this.NavigationController.PushViewController(this.addNewItemScrean, true);
            };

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

