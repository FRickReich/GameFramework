using UnityEngine;

using Shipyard.Notifications;

namespace Shipyard.Test
{
	public class NotificationDemo : MonoBehaviour
	{
		public Sprite TestIcon;

		public void Hit()
		{
			NotificationManager.Instance.CreateNotification(TestIcon, "ABC", "DEF");
		}
	}
}
