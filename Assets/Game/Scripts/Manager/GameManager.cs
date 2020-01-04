using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

using Game.Base;
using Game.Helper;
using Game.FSM;
using Game.FSM.State;
using Game.Internationalization;

namespace Game
{
	public class GameManager : SingletonPersistent<GameManager>
	{
		private FiniteStateMachine stateManager = new FiniteStateMachine();

		public bool debugMode;
		public bool gamePauseMode;
		public string gameMode;
		public float gameTime;
		public Timer gameTimer;
		public Languages gameLanguage;

		void Start()
		{
			this.stateManager.DebugMode(debugMode);

			gameTimer = new Timer();

			this.stateManager.ChangeState(new GamePrepareState(stateManager));
		}

		// Update is called once per frame
		void Update()
		{
			this.stateManager.ExecuteStateUpdate();

			gameMode = stateManager.GetCurrentStateName();
			gameTime = gameTimer.elapsed;
		}
	}
}
