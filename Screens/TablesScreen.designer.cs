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
    [Register ("TablesScreen")]
    partial class TablesScreen
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTable1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTable2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTable3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTable4 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnTable1 != null) {
                btnTable1.Dispose ();
                btnTable1 = null;
            }

            if (btnTable2 != null) {
                btnTable2.Dispose ();
                btnTable2 = null;
            }

            if (btnTable3 != null) {
                btnTable3.Dispose ();
                btnTable3 = null;
            }

            if (btnTable4 != null) {
                btnTable4.Dispose ();
                btnTable4 = null;
            }
        }
    }
}