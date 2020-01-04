using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Game.QuestSystem
{
	public class QButtonScript : MonoBehaviour
	{

		public int questID;
		//public string questText;
		public Text myText;

		void Awake()
		{

		}

		void Start()
		{

		}

		public void ShowAllInfos()// on click event for the left buttons
		{
			QuestUIManager.Instance.showSelectedQuest(questID);
			// pass over data to:
			//accept button
			if (QuestManager.Instance.RequestAvailableQuest(questID))
			{
				QuestUIManager.Instance.acceptButton.SetActive(true);
				//Debug.Log("Accept Button visible = " + acceptButton.activeSelf);
				QuestUIManager.Instance.acceptButtonScript.questID = questID;

				//Debug.Log("Quest: " + questID + " can  be accepted");
			}
			else
			{
				QuestUIManager.Instance.acceptButton.SetActive(false);
			}
			// GIVE UP BUTTON
			if (QuestManager.Instance.RequestAcceptedQuest(questID))
			{
				QuestUIManager.Instance.giveupButton.SetActive(true);
				QuestUIManager.Instance.giveupButtonScript.questID = questID;
			}
			else
			{
				QuestUIManager.Instance.giveupButton.SetActive(false);
			}

			// COMPLETE BUTTON
			if (QuestManager.Instance.RequestCompletedQuest(questID))
			{
				QuestUIManager.Instance.completeButton.SetActive(true);
				QuestUIManager.Instance.completeButtonScript.questID = questID;
			}
			else
			{
				QuestUIManager.Instance.completeButton.SetActive(false);
			}
		}

		public void acceptQuest()
		{
			QuestManager.Instance.AcceptQuest(questID);
			QuestUIManager.Instance.HideQuestPanel();


			QuestUIManager.Instance.showActiveQuest(questID);

			//UPDATE QUEST GIVERS EVENTS
			QuestObject[] currentQuestGuys = FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
			foreach (QuestObject obj in currentQuestGuys)
			{
				obj.SetQuestMarker();
			}

			QuestUIManager.Instance.acceptButton.SetActive(false);
		}

		public void giveUpQuest()
		{
			QuestManager.Instance.GiveUpQuest(questID);
			QuestUIManager.Instance.HideQuestPanel();
			//UPDATE QUEST GIVERS EVENTS
			QuestObject[] currentQuestGuys = FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
			foreach (QuestObject obj in currentQuestGuys)
			{
				obj.SetQuestMarker();
			}

			QuestUIManager.Instance.giveupButton.SetActive(false);
		}

		public void completeQuest()
		{
			QuestManager.Instance.CompleteQuest(questID);
			QuestUIManager.Instance.HideQuestPanel();
			//UPDATE QUEST GIVERS EVENTS
			QuestObject[] currentQuestGuys = FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
			foreach (QuestObject obj in currentQuestGuys)
			{
				obj.SetQuestMarker();
			}

			QuestUIManager.Instance.completeButton.SetActive(false);
		}

		public void ClosePanel()
		{
			QuestUIManager.Instance.HideQuestPanel();
			//UPDATE QUEST GIVERS EVENTS
			QuestObject[] currentQuestGuys = FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
			foreach (QuestObject obj in currentQuestGuys)
			{
				obj.SetQuestMarker();
			}

			QuestUIManager.Instance.acceptButton.SetActive(false);
			QuestUIManager.Instance.giveupButton.SetActive(false);
			QuestUIManager.Instance.completeButton.SetActive(false);
		}
	}
}
