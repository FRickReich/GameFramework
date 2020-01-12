using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

using Shipyard.UI;

using Game.UI;

namespace Game.Manager
{
	public class MainMenuManager : MonoBehaviour
	{
		public EventSystem eventSystem;

		private bool welcomeScreenVisible;
		private bool mainMenuScreenVisible;
		private bool loadingScreenVisible;
		private bool versionStringVisible;

		private GameObject welcomePanel;
		private GameObject mainMenuPanel;
		private GameObject versionStringPanel;
		private GameObject loadingScreenPanel;

		private Canvas canvas;
		public GameObject welcomePanelPrefab;
		public GameObject mainMenuPanelPrefab;
		public GameObject versionStringPrefab;
		public GameObject loadingScreenPrefab;

		public Canvas GetCanvas()
		{
			return GameObject.Find("Canvas").GetComponent<Canvas>();
		}

		public EventSystem GetEventSystem()
		{
			return GameObject.Find("EventSystem").GetComponent<EventSystem>();
		}

		public void ShowVersionString()
		{
			if (versionStringVisible == false)
			{
				canvas = GetCanvas();
				versionStringPanel = Instantiate(versionStringPrefab.GetComponent<VersionString>().gameObject, canvas.transform.position, Quaternion.identity, canvas.transform);

				versionStringVisible = true;
			}

		}

		public void HideVersionString()
		{
			versionStringPanel = null;
			versionStringVisible = false;
		}

		public void ShowWelcomeScreen()
		{
			if (welcomeScreenVisible == false)
			{
				canvas = GetCanvas();
				ShowVersionString();
				welcomePanel = Instantiate(welcomePanelPrefab, canvas.transform.position, Quaternion.identity, canvas.transform);
				welcomeScreenVisible = true;
			}
		}

		public void HideWelcomeScreen()
		{
			welcomePanel = null;
			welcomeScreenVisible = false;
		}

		public void ShowMainMenu()
		{
			if (mainMenuScreenVisible == false)
			{
				canvas = GetCanvas();
				ShowVersionString();
				mainMenuPanel = Instantiate(mainMenuPanelPrefab.GetComponent<MainMenuPanel>().gameObject, canvas.transform.position, Quaternion.identity, canvas.transform);
				eventSystem = GetEventSystem();

				mainMenuPanel.GetComponent<MainMenuPanel>().optionsButtonActive = false;
				mainMenuPanel.GetComponent<MainMenuPanel>().extrasButtonActive = false;

				eventSystem.firstSelectedGameObject = mainMenuPanel.GetComponent<MainMenuPanel>().newGameButton.gameObject;

				mainMenuScreenVisible = true;
			}
		}

		public void HideMainMenu()
		{
			mainMenuPanel = null;
			mainMenuScreenVisible = false;
		}

		public void ShowLoadingScreen()
		{
			if (loadingScreenVisible == false)
			{
				canvas = GetCanvas();
				loadingScreenPanel = Instantiate(loadingScreenPrefab, canvas.transform.position, Quaternion.identity, canvas.transform);

				loadingScreenVisible = true;
			}
		}

		public void HideLoadingScreen()
		{
			loadingScreenPanel = null;
			loadingScreenVisible = true;
		}
	}
}