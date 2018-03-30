using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Take_Order
{
	public partial class HelloUniverseScreen : UIViewController
	{
		//loads the HelloUniverseScreen.xib file and connects it to this object
		public HelloUniverseScreen () : base ("HelloUniverseScreen", null)
		{
			this.Title = "Universe!";
		}
	}
}
