using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    private bulletPooler _bulletPooler;
    private Vector3 vector;
    public GameObject player;
    void Start()
    {
        StartCoroutine(SpawnBall());
        _bulletPooler = bulletPooler.Instance;
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    IEnumerator SpawnBall()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            vector = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z+1);
            _bulletPooler.SpawnFromPool("bullet", vector , Quaternion.identity);

            
        }
        
        
       
        
    }
}
