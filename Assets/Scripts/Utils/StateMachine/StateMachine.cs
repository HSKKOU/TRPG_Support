namespace Utils.StateMachine
{

	public class StateMachine<T>
	{
    /// <summary>
    /// 現在のステート
    /// </summary>
		private State<T> currentState;

		public StateMachine() { currentState = null; }

		public State<T> CurrentState
		{
			get { return currentState; }
		}

    /// <summary>
    /// ステートを変える
    /// </summary>
    /// <param name="state">State.</param>
		public void ChangeState(State<T> state)
		{
			if (currentState != null) { currentState.Exit(); }
			currentState = state;
			currentState.Enter();
		}

    /// <summary>
    /// 各ステートの更新はここから発火する
    /// </summary>
		public void Update()
		{
			if (currentState != null) { currentState.Execute(); }
		}
	}

}
