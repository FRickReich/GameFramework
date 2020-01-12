using UnityEngine;

namespace Shipyard.Helper
{
	public static class Version
	{
		public static string GetVersion()
		{
			TextAsset version = (TextAsset)Resources.Load("Version", typeof(TextAsset));

			return version.text;
		}
	}
}