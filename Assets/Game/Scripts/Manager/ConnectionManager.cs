using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Shipyard.Helper;

namespace Game.Manager
{
	public class ConnectionManager : MonoBehaviour
	{
		public string serverIp = "167.71.35.39";
		public bool isClientOnline = false;
		public int ping;

		private void Update()
		{
			isClientOnline = Connection.CheckIfOnline();

			ping = Ping().time;
		}

		public Ping Ping()
		{
			if (isClientOnline)
			{
				return new Ping(serverIp);

			}

			return null;
		}
	}
}
