using AVFoundation;
using Xamarin.CommunityToolkit.UI.Views;

namespace Xamarin.CommunityToolkit.Extensions
{
	public static class FlashModeExtensions
	{
		public static AVCaptureFlashMode Parse(CameraFlashMode value)
		{
			switch (value)
			{
				case CameraFlashMode.On:
				case CameraFlashMode.Torch:
					return AVCaptureFlashMode.On;
				case CameraFlashMode.Auto:
					return AVCaptureFlashMode.Auto;
				case CameraFlashMode.Off:
				default:
					return AVCaptureFlashMode.Off;
			}
		}
	}
}
