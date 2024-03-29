﻿using UnityEngine;

namespace Invector.vCharacterController.AI
{
    public class vAITester : MonoBehaviour
    {
        public vControlAI ai;
        public Transform target;
        public vAIMovementSpeed speed= vAIMovementSpeed.Running;
        public void MoveToTarget()
        {
            ai.MoveTo(target.position, speed);
        }

        public void Stop()
        {
            ai.Stop();
        }

        public void LookToTarget()
        {
            ai.LookToTarget(target, 2f, 0f);
        }

        public void Attack(bool strong = false)
        {
            if(ai is vIControlAICombat)
            {
                (ai as vIControlAICombat).Attack(strong,forceCanAttack: true);
            }
        }
    }
}