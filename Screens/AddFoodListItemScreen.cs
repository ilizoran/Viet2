using System;

using CoreGraphics;

using UIKit;

namespace Take_Order
{
    public partial class AddFoodListItemScreen : UIViewController
    {
        private UILabel _titleScreen;
        private UILabel _descScreen;
        private UILabel _priceScreen;
        private UITextField _Title2;
        private UITextField _Description;
        private UITextField _price;

        public AddFoodListItemScreen() : base("AddFoodListItemScreen", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _titleScreen = new UILabel(new CGRect(10, 70, 300, 50));
            _titleScreen.TextColor = UIColor.Black;
            _titleScreen.Text = "Title:";

            var frame = new CGRect(10, 110, 300, 40);
            _Title2 = new UITextField(frame);
            _Title2.Placeholder = "type here...";
            _Title2.ReturnKeyType = UIReturnKeyType.Send;
            _Title2.BackgroundColor = UIColor.Gray;
            _Title2.MinimumFontSize = 17f;
            _Title2.AdjustsFontSizeToFitWidth = true;
            View.Add(_Title2);

            _descScreen = new UILabel(new CGRect(10, 150, 300, 50));
            _descScreen.TextColor = UIColor.Black;
            _descScreen.Text = "Description:";

            var frame1 = new CGRect(10, 190, 300, 40);
            _Description = new UITextField(frame1);
            _Description.Placeholder = "type here...";
            _Description.ReturnKeyType = UIReturnKeyType.Send;
            _Description.BackgroundColor = UIColor.Gray;
            _Description.MinimumFontSize = 17f;
            _Description.AdjustsFontSizeToFitWidth = true;
            View.Add(_Description);

            _priceScreen = new UILabel(new CGRect(10, 230, 300, 50));
            _priceScreen.TextColor = UIColor.Black;
            _priceScreen.Text = "Price:";

            var frame2 = new CGRect(10, 270, 300, 40);
            _price = new UITextField (frame2);
            _price.Placeholder = "type here...";
            _price.ReturnKeyType = UIReturnKeyType.Send;
            _price.BackgroundColor = UIColor.Gray;
            _price.MinimumFontSize = 17f;
            _price.AdjustsFontSizeToFitWidth = true;
            View.Add(_price);


            Add(_titleScreen);
            Add(_descScreen);
            Add(_priceScreen);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

