// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using UIKit;

namespace animate
{
    [Register("animateViewController")]
    partial class animateViewController
    {
        [Outlet]
        UIPinchGestureRecognizer pinchGesture { get; set; }

        [Outlet]
        UIImageView uiImageView { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (uiImageView != null)
            {
                uiImageView.Dispose();
                uiImageView = null;
            }

            if (pinchGesture != null)
            {
                pinchGesture.Dispose();
                pinchGesture = null;
            }
        }
    }
}
