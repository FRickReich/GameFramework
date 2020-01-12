using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Shipyard.FSM;
using Shipyard.FSM.State;

using Game.Manager;

namespace Game.State
{
	public class GameChangeSceneState : IState
	{
		private FiniteStateMachine stateManager;
		private string scene;

		public float timerMax = 5;
		public float timer;

		public GameChangeSceneState(FiniteStateMachine stateManager, string scene)
		{
			this.stateManager = stateManager;
			this.scene = scene;
		}

		public void Execute(float delta)
		{
			timer += delta;

			if (timer > timerMax)
			{
				timer = 0;

				SystemManager.Instance.mainMenuManager.HideLoadingScreen();
			}
		}

		public void LateExecute()
		{

		}

		public void OnEnter()
		{
			SystemManager.Instance.mainMenuManager.ShowLoadingScreen();
			SystemManager.Instance.loadScene(scene);
			SystemManager.Instance.mainMenuManager.ShowLoadingScreen();
			SystemManager.Instance.saveGameManager.SaveGame();

		}

		public void Exit()
		{

		}
	}
}
