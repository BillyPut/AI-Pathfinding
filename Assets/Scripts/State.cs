using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Ai
{
    public abstract class State
    {
        protected Pathfinding ai;
        protected StateMachine sm;


        // base constructor
        protected State(Pathfinding ai, StateMachine sm)
        {
            this.ai = ai;
            this.sm = sm;
        }

        // These methods are common to all states
        public virtual void Enter()
        {
            //Debug.Log("This is base.enter");
        }

        public virtual void HandleInput()
        {
        }

        public virtual void LogicUpdate()
        {
        }

        public virtual void PhysicsUpdate()
        {
        }

        public virtual void Exit()
        {
        }
    }
}

