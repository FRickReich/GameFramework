using UnityEngine;

namespace Game.FSM
{
	public interface IState
	{
		void OnEnter();
		void Execute(float delta);
		void LateExecute();
		void Exit();
	}
}