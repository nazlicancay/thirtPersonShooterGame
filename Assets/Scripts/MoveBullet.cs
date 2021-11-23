using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour ,IPooledObject
{
    // Start is called before the first frame update
    private float _force = 60;
   public void OnObjectSpawn()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0, _force);


    }

    
}
