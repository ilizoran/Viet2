using System;

using CoreGraphics;
using UIKit;

namespace Take_Order
{
    public partial class AddNewFoodListItem : UIViewController
    {
        private UIButton _btnAddNewFoodListItem;
        UITableView table;
        TableSource source;
        AddNewFoodListItem addNewFoodListItem;

        public AddNewFoodListItem() : base("AddNewFoodListItem", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();;

            _btnAddNewFoodListItem = new UIButton(new CGRect(10, 70, 140, 40));
            _btnAddNewFoodListItem.SetBackgroundImage(UIImage.FromFile("button.png"), UIControlState.Normal);
            _btnAddNewFoodListItem.SetTitleColor(UIColor.White, UIControlState.Normal);
            _btnAddNewFoodListItem.SetTitle("Add New Food", UIControlState.Normal);


            this._btnAddNewFoodListItem.TouchUpInside += (sender, e) =>
            {

                if (this.addNewFoodListItem == null) { this.addNewFoodListItem = new AddNewFoodListItem(); }
                this.NavigationController.PushViewController(this.addNewFoodListItem, true);
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
                    "Table 1",
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

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

