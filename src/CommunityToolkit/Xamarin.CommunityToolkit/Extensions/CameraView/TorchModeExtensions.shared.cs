using AVFoundation;
using Xamarin.CommunityToolkit.UI.Views;

namespace Xamarin.CommunityToolkit.Extensions
{
	public static class TorchModeExtensions
	{
		public static AVCaptureTorchMode Parse(CameraFlashMode value)
		{
			switch (value)
			{
				case CameraFlashMode.Torch:
					return AVCaptureTorchMode.On;
				default:
					return AVCaptureTorchMode.Off;
			}
		}
	}
}
