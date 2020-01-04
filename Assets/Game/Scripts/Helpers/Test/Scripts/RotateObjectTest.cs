using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Game.Helper;
using Game.Internationalization;

namespace Game.Helper
{
	public class RotateObjectTest : MonoBehaviour
	{
		public i18n converter;
		public Languages language;
		public TMP_Text resumeButtonText;
		public TMP_Text pauseButtonText;

		// Start is called before the first frame update
		void Start()
		{
			converter = new i18n(language, "helpers");
		}

		// Update is called once per frame
		void Update()
		{
			converter.language = language;

			resumeButtonText.text = converter.GetMessage("test.helpers.rotateObject.resumeRotationButton");
            pauseButtonText.text = converter.GetMessage("test.helpers.rotateObject.pauseRotationButton");
		}
	}
}
