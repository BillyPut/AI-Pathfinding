using UnityEngine;
namespace Ai
{
    public class TargettingState : State
    {


        // constructor
        public TargettingState(Pathfinding ai, StateMachine sm) : base(ai, sm)
        {
        }

        public override void Enter()
        {
            base.Enter();

            ai.targetting = true;   


        }

        public override void Exit()
        {
            base.Exit();
          



        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            ai.CheckMovePosition();
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();

        }
    }
}

