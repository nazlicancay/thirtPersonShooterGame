using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("line"))
        {
            GameManager.GameManagerInstance.isGameActive = false;
            Debug.Log("game over");
            Debug.Log(PlayerPrefs.GetInt("HighScore"));
        }
    }
}
