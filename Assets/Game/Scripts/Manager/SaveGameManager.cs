using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Shipyard.SaveGame;

namespace Game.Manager
{
	public class SaveGameManager : MonoBehaviour
	{
		public PlayerData currentPlayerData = new PlayerData();

		public GameData runningPlayerData;
		public int currentSaveGameBlock;

		/* Save game progress */
		public void SaveGame()
		{
			SaveSystem.SaveGame(currentPlayerData, currentSaveGameBlock);
			LoadGame();
		}

		/* Load game progress */
		public void LoadGame()
		{
			runningPlayerData = SaveSystem.LoadGame(currentSaveGameBlock);
		}

		/* Delete Game at current Block */
		public bool DeleteGame()
		{
			SaveSystem.DeleteSaveGame(currentSaveGameBlock);
			return SaveGameExists;
		}

		/* Determine is savegame at current block exists */
		public bool SaveGameExists
		{
			get
			{
				return SaveSystem.SaveFileExists(currentSaveGameBlock);
			}
		}
	}
}
