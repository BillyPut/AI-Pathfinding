using UnityEngine;
namespace Ai
{
    public class WalkingState : State
    {
        

        // constructor
        public WalkingState(Pathfinding ai, StateMachine sm) : base(ai, sm)
        {
        }


        public override void Enter()
        {
            base.Enter();

            ai.targetting = false;
   
           
            


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

            //ai.CheckForIdle();
            ai.GoToNextPoint();
            ai.CheckPlayerDistance();

        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
           
        }
    }
}

