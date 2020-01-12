using UnityEngine;
using UnityEngine.SceneManagement;

using Shipyard.Base;
using Shipyard.Internationalization;

namespace Game.Manager
{
	public class SystemManager : SingletonPersistent<SystemManager>
	{
		public GameManager gameManager;
		public SaveGameManager saveGameManager;
		public ConnectionManager connectionManager;
		public InputManager inputManager;
		public MainMenuManager mainMenuManager;
		public UIManager uIManager;

		public string initialGameScene;
		public bool debugMode;

		public Languages language;

		private void Start()
		{
			gameManager.Init();
		}

		public void loadScene(string levelName)
		{
			SceneManager.LoadScene(levelName);
		}

		public void loadNewGameScene()
		{
			gameManager.StartNewGame();
		}
	}
}