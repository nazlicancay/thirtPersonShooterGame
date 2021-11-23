using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    private void Update()
    {
      
        if (Vector3.Distance(target.position,transform.position) > 1)
        {
            agent.SetDestination(target.position);
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            Debug.Log("vuruldu");
            GameManager.GameManagerInstance.highScore += 10;
            Destroy(gameObject);
            other.gameObject.SetActive(false);
         
        }
    }
    
}
