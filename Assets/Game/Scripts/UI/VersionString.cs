using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Shipyard.Helper;
using Shipyard.Internationalization;

using Game.Manager;

namespace Game.UI
{
	public class VersionString : MonoBehaviour
	{
		private i18n converter = new i18n();

		public TMP_Text versionString;
		public string version;

		// Start is called before the first frame update
		void Awake()
		{
			version = Version.GetVersion();
		}

		// Update is called once per frame
		void Update()
		{
			converter.language = SystemManager.Instance.language;
			versionString.text = converter.GetMessage($"game.menu.version", version != "" ? version : "");
		}
	}
}