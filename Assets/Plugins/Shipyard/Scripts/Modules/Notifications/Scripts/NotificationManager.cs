using UnityEngine;

using Game.Base;

namespace Game.Notifications
{
	public class NotificationManager : SingletonPersistent<NotificationManager>

	{
		public NotificationMessage notificationMessage;
		public GameObject notificationPanel;


		public void CreateNotification(Sprite icon, string header, string text)
		{
			NotificationMessage newMsg = Instantiate(notificationMessage, notificationPanel.transform.position, notificationPanel.transform.rotation, notificationPanel.transform);
			newMsg.InitializeMessage(header, text);
		}
	}
}
