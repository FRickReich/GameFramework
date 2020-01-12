using UnityEngine;

using Game.Notifications;

namespace Game.Test
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
