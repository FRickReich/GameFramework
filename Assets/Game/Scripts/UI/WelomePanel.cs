using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Shipyard.Helper;
using Shipyard.Internationalization;

using Game.Manager;

namespace Game.UI
{
	public class WelomePanel : MonoBehaviour
	{
		private i18n converter = new i18n();

		public int pulsingSpeed = 2;
		public GameObject welcomeText;

		// Start is called before the first frame update
		void Awake()
		{
			welcomeText.GetComponent<PulsingText>().pulsingSpeed = pulsingSpeed;
		}

		// Update is called once per frame
		void Update()
		{
			converter.language = SystemManager.Instance.language;
			welcomeText.GetComponent<TMP_Text>().text = converter.GetMessage($"game.menu.welcome.startGame");
		}
	}
}
