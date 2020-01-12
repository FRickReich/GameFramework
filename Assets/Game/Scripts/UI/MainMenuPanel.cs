using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Shipyard.Helper;
using Shipyard.Internationalization;

using Game.Manager;

namespace Game.UI
{

	public class MainMenuPanel : MonoBehaviour
	{
		private i18n converter = new i18n();

		public bool newGameButtonActive = true;
		public bool continueGameButtonActive = true;
		public bool optionsButtonActive = true;
		public bool extrasButtonActive = true;

		public Button newGameButton;
		public Button continueGameButton;
		public Button optionsButton;
		public Button extrasButton;

		// Start is called before the first frame update
		void Awake()
		{

		}

		// Update is called once per frame
		void Update()
		{
			converter.language = SystemManager.Instance.language;
			//welcomeText.GetComponent<TMP_Text>().text = converter.GetMessage($"game.menu.welcome.startGame");

			/*
            newGameButton.GetComponentInChildren<TMP_Text>().text = ""
            continueGameButton
            optionsButton
            extrasButton


            */

			newGameButton.interactable = newGameButtonActive;
			continueGameButton.interactable = continueGameButtonActive;
			optionsButton.interactable = optionsButtonActive;
			extrasButton.interactable = extrasButtonActive;
		}
	}
}
