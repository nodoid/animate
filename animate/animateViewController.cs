using System;
using CoreGraphics;
using Foundation;
using UIKit;
using ObjCRuntime;
using System.Drawing;

namespace animate
{
    public partial class animateViewController : UIViewController
    {
        public animateViewController() : base("animateViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            uiImageView.Image = UIImage.FromFile("graphics/image.jpg").Scale(new SizeF(160f, 160f));
            pinchGesture.AddTarget(this, new Selector("screenTapped:"));
            uiImageView.AddGestureRecognizer(pinchGesture);

            var uiButton = new UIButton();
            uiButton.TouchUpInside += HandleTouchUpInside;
        }

        [Export("screenTapped:")]
        public void SingleTap(UIGestureRecognizer s)
        {
            UIPinchGestureRecognizer pinch = (UIPinchGestureRecognizer)s;
            nfloat scale = 0f;
            CGPoint location;
            switch (s.State)
            {
                case UIGestureRecognizerState.Began:
                    Console.WriteLine("Pinch begun");
                    location = s.LocationInView(s.View);
                    break;
                case UIGestureRecognizerState.Changed:
                    Console.WriteLine("Pinch value changed");
                    scale = pinch.Scale;
                    uiImageView.Image = UIImage.FromFile("graphics/image.jpg").Scale(new SizeF(160f, 160f), scale);
                    break;
                case UIGestureRecognizerState.Cancelled:
                    Console.WriteLine("Pinch cancelled");
                    uiImageView.Image = UIImage.FromFile("graphics/image.jpg").Scale(new SizeF(160f, 160f));
                    scale = 0f;
                    break;
                case UIGestureRecognizerState.Recognized:
                    Console.WriteLine("Pinch recognised");
                    break;
            }
        }

        void HandleTouchUpInside(object sender, EventArgs e)
        {

        }
    }
}

