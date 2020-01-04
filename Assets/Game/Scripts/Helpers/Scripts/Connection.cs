
using System;
using System.IO;
using UnityEngine;

namespace Game.Helper
{
	public static class Connection
	{
		public static bool CheckIfOnline()
		{
			if (Application.internetReachability == NetworkReachability.NotReachable)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}