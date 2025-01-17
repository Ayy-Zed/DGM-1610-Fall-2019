﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(Begin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Begin()
    {
        if (GameObject.Find("Start Game"))
        {
            gameManager.StartGame();
        }
    }
}
