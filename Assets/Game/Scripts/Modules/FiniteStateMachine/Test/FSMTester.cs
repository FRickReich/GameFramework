using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

using Game.FSM;
using Game.FSM.State;
using Game.Helper;
using Game.Internationalization;

namespace Game.Test
{
	public class FSMTester : MonoBehaviour
	{
        private FiniteStateMachine stateManager = new FiniteStateMachine();
		private Timer gameTimer;

		public string gameStateString;

		public Languages language;
		public i18n converter;

		public Button firstButton;
		public TMP_Text gameModeText;
		public TMP_Text gameTimeText;
		public TMP_Text resumeButtonText;
		public TMP_Text pauseButtonText;
		public RotateObject testCube;


		// Start is called before the first frame update
		void Start()
		{
			converter = new i18n(language, "fsm");

			gameTimer = new Timer();

			firstButton.Select();

			setTestStateOne();
		}

		// Update is called once per frame
		void Update()
		{
			converter.language = language;

            this.stateManager.ExecuteStateUpdate();

			gameModeText.text = converter.GetMessage("test.fsm.gameModeString", gameStateString);
			gameTimeText.text = converter.GetMessage("test.fsm.gameTimeString", converter.secondsToTime(gameTimer.elapsed));
			resumeButtonText.text = converter.GetMessage("test.fsm.gameStateButton");
			pauseButtonText.text = converter.GetMessage("test.fsm.pauseStateButton");

		}

		public void setTestStateOne()
		{
			this.stateManager.ChangeState(new TestStateOne(stateManager, gameStateString));
		}

		public void setTestStateTwo()
		{
			this.stateManager.ChangeState(new TestStateTwo(stateManager, gameStateString, gameTimer, testCube));
		}
	}
}
