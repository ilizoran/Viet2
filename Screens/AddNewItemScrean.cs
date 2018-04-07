using System;
using CoreGraphics;

using UIKit;
using System.Drawing;


namespace Take_Order
{
    public partial class AddNewItemScrean : UIViewController
    {
        private UIStepper _stepper1;
        private UILabel _label1;
        private UILabel _label1_1;
        private UIStepper _stepper2;
        private UILabel _label2;
        private UILabel _label2_2;

        public AddNewItemScrean() : base("AddNewItemScrean", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            _label1 = new UILabel(new CGRect(10, 70, 140, 50));
            _label1.TextColor = UIColor.Black;
            _label1.Text = "1. Chiken (3.99 $)";

            _label1_1 = new UILabel(new CGRect(170, 70, 40, 50));
            _label1_1.TextColor = UIColor.Black;
            _label1_1.Text = "0";

            _stepper1 = new UIStepper(new RectangleF(220, 80, 30, 50));
            _stepper1.MinimumValue = 0;
            _stepper1.MaximumValue = 100;

            _label2 = new UILabel(new CGRect(10, 120, 140, 50));
            _label2.TextColor = UIColor.Black;
            _label2.Text = "2. Beef (2.99 $)";

            _label2_2 = new UILabel(new CGRect(170, 120, 40, 50));
            _label2_2.TextColor = UIColor.Black;
            _label2_2.Text = "0";


            _stepper2 = new UIStepper(new RectangleF(220, 130, 30, 50));
            _stepper2.MinimumValue = 0;
            _stepper2.MaximumValue = 100;


            _stepper1.ValueChanged += (object sender, EventArgs e) => _label1_1.Text = _stepper1.Value.ToString();
            _stepper2.ValueChanged += (object sender, EventArgs e) => _label2_2.Text = _stepper2.Value.ToString();

            Add(_label1);
            Add(_label1_1);
            Add(_label2);
            Add(_label2_2);
            Add(_stepper1);
            Add(_stepper2);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

