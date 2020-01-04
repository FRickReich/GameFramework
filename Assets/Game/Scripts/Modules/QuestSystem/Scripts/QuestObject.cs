using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Game.QuestSystem
{
	public class QuestObject : MonoBehaviour
	{

		private bool inTrigger = false;// trigger ón or off

		public List<int> availableQuestIDs = new List<int>();   // List of questIDs the questobject can give away
		public List<int> receivableQuestIDs = new List<int>();// List of questIDs the questobject can receive or take as completed

		public GameObject QuestMarker;
		public Image theImage;

		public GameObject pressSpace;

		public Sprite questAvailableSprite; //(!)
		public Sprite questReceivableSprite;//(?) has priority

		// Use this for initialization
		void Start()
		{
			SetQuestMarker();
			pressSpace.SetActive(false);
		}

		public void SetQuestMarker()
		{
			if (QuestManager.Instance.CheckForCompletedQuests(this))
			{
				QuestMarker.SetActive(true);
				//QuestMarker.transform.FindChild("Canvas").FindChild("Image").gameObject.GetComponent<Image>().sprite = questAvailableSprite;
				theImage.sprite = questReceivableSprite;
				theImage.color = Color.yellow;

			}

			else if (QuestManager.Instance.CheckForAvailableQuests(this))
			{
				QuestMarker.SetActive(true);
				theImage.sprite = questAvailableSprite;
				theImage.color = Color.yellow;
			}

			else if (QuestManager.Instance.CheckForAcceptedQuests(this))
			{
				QuestMarker.SetActive(true);
				theImage.sprite = questReceivableSprite;
				theImage.color = Color.gray;
			}

			else
			{
				QuestMarker.SetActive(false);
			}
		}


		// Update is called once per frame
		void Update()
		{
			if (inTrigger && Input.GetKeyDown(KeyCode.Space))
			{
				//Debug.Log("check for quests & show correct UI");
				QuestUIManager.Instance.CheckQuests(this);

			}
		}

		void OnTriggerEnter(Collider other)
		{
			if (other.tag == "Player")
			{
				//Debug.Log("hero nearby, can check quests.");
				inTrigger = true;
				pressSpace.SetActive(true);
			}
		}

		void OnTriggerExit(Collider other)
		{
			if (other.tag == "Player")
			{
				//Debug.Log("no hero nearby.");
				inTrigger = false;
				pressSpace.SetActive(false);
			}
		}
	}
}
