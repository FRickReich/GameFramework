
using System;
using System.IO;
using UnityEngine;

namespace Game.Helper
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