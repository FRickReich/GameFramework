using UnityEngine;
using TMPro;

using Shipyard.Helper;
using Shipyard.Internationalization;

namespace Shipyard.Helper
{
	public class SaveLoadIndicatorTest : MonoBehaviour
	{
		public i18n converter;
		public Languages language;
		public TMP_Text fadeInButtonText;
		public TMP_Text fadeOutButtonText;

		// Start is called before the first frame update
		void Start()
		{
			converter = new i18n(language, "helpers");
		}

		// Update is called once per frame
		void Update()
		{
			fadeInButtonText.text = converter.GetMessage("test.helpers.saveLoadIndicator.fadeInButton");
			fadeOutButtonText.text = converter.GetMessage("test.helpers.saveLoadIndicator.fadeOutButton");

			converter.language = language;
		}
	}
}