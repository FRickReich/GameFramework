using UnityEngine;
using TMPro;

using Shipyard.Internationalization;

namespace Shipyard.Helper
{
	public class PulsingTextTest : MonoBehaviour
	{
		public i18n converter;
		public Languages language;
		public TMP_Text testString;

		private void Start()
		{
			converter = new i18n(language, "helpers");
		}

		void Update()
		{
			converter.language = language;

			testString.text = converter.GetMessage("test.helpers.pulseText.testString");
		}
	}
}
