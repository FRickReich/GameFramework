/* Quest Saver
 * This Script is for saving the actual Quests.
 *
 * I recomment calling it when saving the entire Game, on a save spot for example.
 * But you can also call it anytime a quest becomes updated in it's state. But
 * might become problematic when you are not saving the whole game.
 *
 * The saver does not work in unity web player
 *
 * todo
 * iterate through all quests
 * use id as indicator
 * so save id
 * save progress
 * save quest objective count
 *
 */
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;

namespace Game.QuestSystem
{
	public class SaveLoad : MonoBehaviour
	{

		public List<Quest> allQuests = new List<Quest>();

		public void SaveQuests()
		{
			//clear list
			allQuests.Clear();
			//add all quests to the allquests list to become saved.
			for (int i = 0; i < QuestManager.Instance.questList.Count; i++)
			{
				allQuests.Add(QuestManager.Instance.questList[i]);
			}


			BinaryFormatter bf = new BinaryFormatter();
			FileStream stream = new FileStream(Application.persistentDataPath + "/QuestList.octo", FileMode.Create);


			bf.Serialize(stream, allQuests);
			stream.Close();

			print("Saved!");
		}

		public void LoadQuests()
		{
			if (File.Exists(Application.persistentDataPath + "/QuestList.octo"))
			{
				BinaryFormatter bf = new BinaryFormatter();
				FileStream stream = new FileStream(Application.persistentDataPath + "/QuestList.octo", FileMode.Open);

				allQuests = (List<Quest>)bf.Deserialize(stream);

				stream.Close();

				//clear recent data
				QuestManager.Instance.currentQuestList.Clear();
				//set our questlist
				for (int i = 0; i < allQuests.Count; i++)
				{
					QuestManager.Instance.questList[i] = allQuests[i];

					print(allQuests[i].title);
				}
				//update currentquestlist
				for (int i = 0; i < QuestManager.Instance.questList.Count; i++)
				{
					if (QuestManager.Instance.questList[i].progress == Quest.QuestProgress.ACCEPTED || QuestManager.Instance.questList[i].progress == Quest.QuestProgress.COMPLETE)
					{
						QuestManager.Instance.currentQuestList.Add(QuestManager.Instance.questList[i]);
					}
				}


				//update all npcs object markers
				QuestObject[] NPCs = GameObject.FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
				foreach (QuestObject obj in NPCs)
				{
					obj.SetQuestMarker();
				}
				print("Loaded!");
			}
			else
			{
				Debug.LogError("No savefile found!");
			}
		}
	}
}
