using UnityEngine;

namespace Shipyard.FSM
{
	public interface IState
	{
		void OnEnter();
		void Execute(float delta);
		void LateExecute();
		void Exit();
	}
}