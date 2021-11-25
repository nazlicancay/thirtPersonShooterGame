using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFalseBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isKillable = true;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            isKillable = false;

        }
    }
}
