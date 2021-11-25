using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager GameManagerInstance;
    public int Score = 0;
    public bool isGameActive = true;
    public TextMeshProUGUI Text;
    public int scoreToDisplay;
    public GameObject canvas;

    private void Awake()
    {
        GameManagerInstance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("HighScore", Score);
        scoreToDisplay = PlayerPrefs.GetInt("HighScore");

        if (!isGameActive)
        {
           canvas.gameObject.SetActive(true);

            Text.text =  ( "Score\n "+Score.ToString());

        }
    }
}
