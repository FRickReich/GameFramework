using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using Shipyard.FSM;
using Shipyard.FSM.State;

using Game.Manager;

namespace Game.State
{
	public class GameShowMainMenuState : IState
	{
		private FiniteStateMachine stateManager;

		public GameShowMainMenuState(FiniteStateMachine stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			if (SceneManager.GetActiveScene().name == "MainMenu")
			{
				SystemManager.Instance.mainMenuManager.ShowMainMenu();
			}
		}

		public void LateExecute()
		{

		}

		public void OnEnter()
		{
			SystemManager.Instance.loadScene("MainMenu");
		}

		public void Exit()
		{

		}
	}
}
