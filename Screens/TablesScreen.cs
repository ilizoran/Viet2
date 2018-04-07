using System;
using CoreGraphics;

using UIKit;
using System.Drawing;

namespace Take_Order
{

    public partial class TablesScreen : UIViewController
	{
     
        private UIButton _btnAddTable;
        private UITextField _tfTableName;

        //loads the TablesScreen.xib file and connects it to this object
        public TablesScreen () : base ("TablesScreen", null)
		{
			this.Title = "Tables";
		}

        public override void ViewDidLoad()
        {
           
            base.ViewDidLoad();

            _btnAddTable = new UIButton(new CGRect(10, 70, 140, 50));
            _btnAddTable.SetTitle("Add table", UIControlState.Normal);

            _tfTableName = new UITextField(new CGRect(170, 70, 140, 50));
 
            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("Tables.png"));

            Add(_btnAddTable);
            Add(_tfTableName);
        }


	}

}
