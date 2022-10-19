using UnityEngine;
namespace Ai
{
    public class IdleState : State
    {


        // constructor
        public IdleState(Pathfinding ai, StateMachine sm) : base(ai, sm)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Standing");

            ai.anim.Play("Male Sword Stance");
            //ai.speedNum = 0;
            //ai.stopTimer = 5;
            


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

            //ai.CheckForWalk();
       

        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
