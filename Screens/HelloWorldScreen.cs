using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Take_Order
{
	public partial class HelloWorldScreen : UIViewController
	{
		//loads the HelloWorldScreen.xib file and connects it to this object
		public HelloWorldScreen () : base ("HelloWorldScreen", null)
		{
			this.Title = "World!";
		}

	}
}
