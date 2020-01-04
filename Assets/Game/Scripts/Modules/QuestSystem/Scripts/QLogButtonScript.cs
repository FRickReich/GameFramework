using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Game.QuestSystem
{
	public class QLogButtonScript : MonoBehaviour
	{

		public int questID;
		//public string questText;
		public Text myText;

		public void ShowAllInfos()// on click event for the left buttons
		{
			QuestManager.Instance.ShowQuestLog(questID);
		}

		public void ClosePanel()
		{
			QuestUIManager.Instance.HideQuestLogPanel();

		}
	}
}
