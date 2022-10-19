using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.VFX;


namespace Ai
{
    public class Pathfinding : MonoBehaviour
    {
        public Transform[] points;
        public Transform player;
        Vector3 pointPos;
        public Animator anim;
        private NavMeshAgent nav;

        private int destPoint;
        //public float stopTimer;
        public float dist, dist2;
        //public int speedNum;
        //public bool moving = true;
        public bool targetting = false;
        public bool pointHit = true;   


        public StateMachine sm;

        public IdleState idleState;
        public WalkingState walkingState;
        public TargettingState targettingState;

        public float runBlend;


        // Start is called before the first frame update
        void Start()
        {
            nav = GetComponent<NavMeshAgent>();
            sm = gameObject.AddComponent<StateMachine>();
            anim = GetComponent<Animator>();

            idleState = new IdleState(this, sm);
            walkingState = new WalkingState(this, sm);
            targettingState = new TargettingState(this, sm);

            

            sm.Init(walkingState);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            sm.CurrentState.HandleInput();
            sm.CurrentState.LogicUpdate();

            dist = Vector3.Distance(player.position, transform.position);
            dist2 = Vector3.Distance(pointPos, transform.position);

           




            //stopTimer -= Time.deltaTime;
            //nav.speed = speedNum;

        }

        public void GoToNextPoint()
        {
            if (!nav.pathPending && nav.remainingDistance < 0.5f)
            {
                pointPos = nav.destination = points[destPoint].position;
                destPoint = (destPoint + 1) % points.Length;
              

            }
        }

        public void CheckPlayerDistance()
        {
           
            if (dist < dist2)
            {
                sm.ChangeState(targettingState);
            }
            
        }

        public void CheckMovePosition()
        {
            nav.destination = player.position;
            
            if (dist > dist2)
            {
                sm.ChangeState(walkingState);
            }
            

        }

       

        /*
        public void CheckForIdle()
        {
          
            if (moving == false)
            {
                sm.ChangeState(idleState);
            }
           
        }

        public void CheckForWalk()
        {
       
            if (stopTimer < 0)
            {
                sm.ChangeState(walkingState);
            }
        }*/



    }

}
