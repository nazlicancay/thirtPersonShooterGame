using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    public SetFalseBullet bullet;
    

    private void Update()
    {
      
        if (Vector3.Distance(target.position,transform.position) > 0.8)
        {
            agent.SetDestination(target.position);
        }
        

    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bullet") && bullet.isKillable )
        {
            Debug.Log("vuruldu");
            GameManager.GameManagerInstance.Score += 10;
            Destroy(gameObject);
            
         
        }
    }
    
}
