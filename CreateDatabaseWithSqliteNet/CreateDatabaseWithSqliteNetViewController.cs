using System;
using System.IO;
using CoreGraphics;
using Mono.Data.Sqlite;
using System.Data;
using Foundation;
using UIKit;

namespace CreateDatabaseWithSqliteNet
{
    public partial class CreateDatabaseWithSqliteNetViewController : UIViewController
    {
        private string _pathToDatabase;
        private UIButton _btnCreateDatabase;
        private UIButton _btnInsertUser;
        private UIButton _btnSelectUser;
        private UIButton _btnDeleteTable;
        private UITextField _textfield;
        private UITextView _txtView;

        public CreateDatabaseWithSqliteNetViewController() : base ("CreateDatabaseWithSqliteNetViewController", null)
        {
        }
        
        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
        }
        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Figure out where the SQLite database will be.
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            _pathToDatabase = Path.Combine(documents, "db_sqlite-net.db");

            // Create the buttons and TextView to run the sample code
            _btnCreateDatabase = UIButton.FromType(UIButtonType.RoundedRect);
            _btnCreateDatabase.Frame = new CGRect(10, 10, 145, 50);
            _btnCreateDatabase.SetTitle("Create Database", UIControlState.Normal);

            _btnInsertUser = UIButton.FromType(UIButtonType.RoundedRect);
            _btnInsertUser.Frame = new CGRect(165, 10, 145, 50);
            _btnInsertUser.SetTitle("Insert User", UIControlState.Normal);
            _btnInsertUser.Enabled = false;  // Disable the button. It will be enabled when the database is created.


            _btnSelectUser = UIButton.FromType(UIButtonType.RoundedRect);
            _btnSelectUser.Frame = new CGRect(10, 60, 145, 50);
            _btnSelectUser.SetTitle("Select User", UIControlState.Normal);
            _btnSelectUser.Enabled = false;  // Disable the button. It will be enabled when the database is created.

            _textfield = new UITextField(new CGRect(165, 60, 145, 50));
            _textfield.BackgroundColor = UIColor.White;
           
         
            _txtView = new UITextView(new CGRect(10, 180, 300, 350));
            _txtView.Editable = false;
            _txtView.ScrollEnabled = true;

            _btnDeleteTable = UIButton.FromType(UIButtonType.RoundedRect);
            _btnDeleteTable.Frame = new CGRect(10, 120, 145, 50);
            _btnDeleteTable.SetTitle("Delete table", UIControlState.Normal);
            _btnDeleteTable.Enabled = false;  // Disable the button. It will be enabled when the database is created.
            
            _btnCreateDatabase.TouchUpInside += HandleTouchUpInsideForCreateDatabase;

            Add(_btnCreateDatabase);
            Add(_btnInsertUser);
            Add(_btnSelectUser);
            Add(_btnDeleteTable);
            Add(_textfield);
            Add(_txtView);
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
        
        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }


        /// <summary>
        /// This code will handle creating the database and a table.
        /// </summary>
        void HandleTouchUpInsideForCreateDatabase(object sender, EventArgs e)
        {
            // Create the database and a table to hold Person information.
            using (var conn= new SQLite.SQLiteConnection(_pathToDatabase))
            {
                conn.CreateTable<Person>();
            }
                
            // Let the user know that the database was created, and disable the button
            // to prevent double clicks.
            _txtView.Text = "Created new database at " + _pathToDatabase;
            _btnCreateDatabase.Enabled = false;

            _btnInsertUser.TouchUpInside += HandleTouchUpInsideForInsertUser;
            _btnSelectUser.TouchUpInside += HandleTouchUpInsideForSelectUser;
            _btnDeleteTable.TouchUpInside += HandleTouchUpInsideForDeleetTable;
            _btnInsertUser.Enabled = true;
            _btnSelectUser.Enabled = true;
            _btnDeleteTable.Enabled = true;
        }

        void HandleTouchUpInsideForInsertUser(object sender, EventArgs e)
        {
            var person = new Person { FirstName = _textfield.Text, LastName = "Doe" };
            using (var db = new SQLite.SQLiteConnection(_pathToDatabase))
            {
                db.Insert(person);
            }

            _txtView.Text = String.Concat(Environment.NewLine, "Inserted a new person into the database: ", person.FirstName, " ", person.LastName, " text ");

        }

        void HandleTouchUpInsideForDeleetTable(object sender, EventArgs e)
        {
           
            using (var db = new SQLite.SQLiteConnection(_pathToDatabase))
            {
                db.DeleteAll<Person>();
                _txtView.Text = String.Concat(Environment.NewLine, "Table Person is deleted! ", Environment.NewLine);

            }
        }

        void HandleTouchUpInsideForSelectUser(object sender, EventArgs e)
        {
            _txtView.Text = String.Concat(Environment.NewLine, "Content of the database: ");   
            using (var db = new SQLite.SQLiteConnection(_pathToDatabase)){
                var table = db.Table<Person>();
                var i = 1;
                foreach (var person in table)
                {
                    _txtView.Text += String.Concat(Environment.NewLine, i, ". ", person.FirstName, " ", person.LastName, " ID = ", person.ID, Environment.NewLine);
                    i++;
                }

            }
        }
    }
}

