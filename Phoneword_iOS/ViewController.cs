using System;

using UIKit;

namespace Phoneword_iOS
{
  public partial class ViewController : UIViewController
  {
    public ViewController (IntPtr handle) : base (handle)
    {
    }

    public override void ViewDidLoad()
    {
      base.ViewDidLoad();
      // Perform any additional setup after loading the view, typically from a nib.

      string translatedNumber = "";
      TranslateButton.TouchUpInside += (object sender, EventArgs e) => {
        translatedNumber = PhoneTranslator.ToNumber(PhoneNumberText.Text);

        PhoneNumberText.ResignFirstResponder();

        if (translatedNumber == "") {
          CallButton.SetTitle("Call ", UIControlState.Normal);
          CallButton.Enabled = false;
        } else {
          CallButton.SetTitle("Call " + translatedNumber, UIControlState.Normal);
          CallButton.Enabled = true;
        }
      };


    }

    public override void DidReceiveMemoryWarning()
    {
      base.DidReceiveMemoryWarning();
      // Release any cached data, images, etc that aren't in use.
    }
  }
}

