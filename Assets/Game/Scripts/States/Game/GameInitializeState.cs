using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Shipyard.FSM;
using Shipyard.FSM.State;

using Game.Manager;

namespace Game.State
{
	public class GameInitializeState : IState
	{
		private FiniteStateMachine stateManager;

		public GameInitializeState(FiniteStateMachine stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			if (SystemManager.Instance.connectionManager.isClientOnline)
			{
				SystemManager.Instance.mainMenuManager.ShowWelcomeScreen();

				if (Input.GetKeyDown(KeyCode.Return))
				{
					if (SystemManager.Instance.saveGameManager.SaveGameExists)
					{
						this.stateManager.ChangeState(new GameShowMainMenuState(stateManager));
					}
					else
					{
						this.stateManager.ChangeState(new GameChangeSceneState(stateManager, SystemManager.Instance.initialGameScene));
					}
				}
			}
		}

		public void LateExecute()
		{

		}

		public void OnEnter()
		{

		}

		public void Exit()
		{

		}
	}
}
