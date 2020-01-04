using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Game.Internationalization;

namespace Game.Test
{
	public class i18nDemo : MonoBehaviour
	{
		public Languages defaultLanguage;

		public string stringValueInput;
		public int intValueInput;
		public float floatValueInput;
		public float secondsToTimeInput;
		[Range(0, 24)] public int hourInput;

		public TMP_Text stringToValueOutput;
		public TMP_Text valuetoStringIntOutput;
		public TMP_Text valueToStringFloatOutput;
		public TMP_Text TwelveHourClockOutput;
		public TMP_Text TwentyFourHourClockOutput;
		public TMP_Text gameTimeOutput;
		public TMP_Text testStringOutput;

		public TMP_Text valuesHeader;
		public TMP_Text timeHeader;
		public TMP_Text stringToValueTitle;
		public TMP_Text valuetoStringIntTitle;
		public TMP_Text valueToStringFloatTitle;
		public TMP_Text TwelveHourClockTitle;
		public TMP_Text TwentyFourHourClockTitle;
		public TMP_Text gameTimeTitle;

		public TMP_Text languageGermanButtonText;
		public TMP_Text languageEnglishButtonText;

		public Button languageGermanButton;

		public i18n converter;

		// Start is called before the first frame update
		void Start()
		{
			converter = new i18n(defaultLanguage, "i18n");
			languageGermanButton.Select();
		}

		// Update is called once per frame
		void Update()
		{
			converter.language = defaultLanguage;

			secondsToTimeInput = Time.time;

			stringToValueOutput.text = converter.StringToValue(stringValueInput).ToString();
			valuetoStringIntOutput.text = converter.ValueToString(intValueInput);
			valueToStringFloatOutput.text = converter.ValueToString(floatValueInput);

			TwelveHourClockOutput.text = converter.HoursToClock(hourInput, 12);
			TwentyFourHourClockOutput.text = converter.HoursToClock(hourInput, 24);
			gameTimeOutput.text = converter.secondsToTime(secondsToTimeInput);

			testStringOutput.text = converter.GetMessage("test.i18n.testString", Random.Range(100, 500).ToString());

			valuesHeader.text = converter.GetMessage("test.i18n.values");
			timeHeader.text = converter.GetMessage("test.i18n.time");
			stringToValueTitle.text = converter.GetMessage("test.i18n.stringToValue");
			valuetoStringIntTitle.text = converter.GetMessage("test.i18n.valueToIntString");
			valueToStringFloatTitle.text = converter.GetMessage("test.i18n.valueToFloatString");
			TwelveHourClockTitle.text = converter.GetMessage("test.i18n.twelveHourClock");
			TwentyFourHourClockTitle.text = converter.GetMessage("test.i18n.twentyFourHourClock");
			gameTimeTitle.text = converter.GetMessage("game.modules.i18n.secondsToTime");

			languageGermanButtonText.text = converter.GetMessage("test.i18n.languageGermanButton");
			languageEnglishButtonText.text = converter.GetMessage("test.i18n.languageEnglishButton");
		}

		public void SetLanguageToGerman()
		{
			defaultLanguage = Languages.de;
		}

		public void SetLanguageToEnglish()
		{
			defaultLanguage = Languages.en;
		}
	}
}
