// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Take_Order
{
    [Register ("HomeScreen")]
    partial class HomeScreen
    {
        [Outlet]
        UIKit.UIButton btnFoodList { get; set; }


        [Outlet]
        UIKit.UIButton btnTables { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnFoodList != null) {
                btnFoodList.Dispose ();
                btnFoodList = null;
            }

            if (btnTables != null) {
                btnTables.Dispose ();
                btnTables = null;
            }
        }
    }
}