using UnityEngine;

using Shipyard.FSM;
using Shipyard.FSM.State;

using Game.State;

namespace Game.Manager
{
	public class GameManager : MonoBehaviour
	{
		private FiniteStateMachine stateManager = new FiniteStateMachine();

		public string currentLevel;

		public void Init()
		{
			this.stateManager.ChangeState(new GameInitializeState(stateManager));
		}

		private void Start()
		{
			this.stateManager.DebugMode(SystemManager.Instance.debugMode);
		}

		void Update()
		{
			this.stateManager.ExecuteStateUpdate();
		}

		public void StartNewGame()
		{

		}
	}
}