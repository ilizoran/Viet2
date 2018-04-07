﻿using System;
using CoreGraphics;

using UIKit;
using System.Drawing;

namespace Take_Order
{

    public partial class TablesScreen : UIViewController
	{
     
        private UIButton _btnAddTable;
        private UITextField _tfTableName;
        UITableView table;
        TableSource source;

        //loads the TablesScreen.xib file and connects it to this object
        public TablesScreen () : base ("TablesScreen", null)
		{
			this.Title = "Tables";
		}

        public override void ViewDidLoad()
        {
           
            base.ViewDidLoad();

            _btnAddTable = new UIButton(new CGRect(10, 70, 140, 40));
            _btnAddTable.SetBackgroundImage(UIImage.FromFile("button.png"), UIControlState.Normal);
            _btnAddTable.SetTitleColor(UIColor.White, UIControlState.Normal);
            _btnAddTable.SetTitle("Add Table", UIControlState.Normal);

            _tfTableName = new UITextField(new CGRect(170, 70, 140, 40));
            _tfTableName.BackgroundColor = UIColor.White;
 
            this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("Tables.png"));

            table = new UITableView(View.Bounds);
            table.AutoresizingMask = UIViewAutoresizing.All;
            CreateTableItems();
            Add(table);

            Add(_btnAddTable);
            Add(_tfTableName);
        }


        void CreateTableItems()
        {
            var tableItems = new string[] {
                "Vegetables",
                "Fruits",
                "Flower Buds",
                "Legumes",
                "Bulbs",
                "Tubers"
            };

            source = new TableSource(tableItems);
            source.Selected += (sender, e) => {
                var alert = UIAlertController.Create("Row Selected", e.Content, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));

                PresentViewController(alert, true, null);
            };

            table.Source = source;
        }



	}

}
