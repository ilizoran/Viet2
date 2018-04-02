using System;

using Foundation;
using UIKit;

namespace Take_Order
{
    public partial class TakeOrderScreen : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("TakeOrderScreen");
        public static readonly UINib Nib;

        static TakeOrderScreen()
        {
            Nib = UINib.FromName("TakeOrderScreen", NSBundle.MainBundle);
        }

        protected TakeOrderScreen(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
