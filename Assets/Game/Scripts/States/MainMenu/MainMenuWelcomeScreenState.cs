using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Shipyard.FSM;
using Shipyard.FSM.State;

using Game.Manager;

namespace Game.State
{
	public class MainMenuWelcomeScreenState : IState
	{
		private FiniteStateMachine stateManager;
		private SystemManager systemManager;

		public MainMenuWelcomeScreenState(FiniteStateMachine stateManager, SystemManager systemManager)
		{
			this.stateManager = stateManager;
			this.systemManager = systemManager;
		}

		public void Execute(float delta)
		{

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
