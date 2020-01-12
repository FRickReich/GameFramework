using UnityEngine;

namespace Shipyard.Helper
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