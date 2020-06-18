﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;

    public GameObject player;

    private bool addedScore = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (transform.position.x <= -8)
        {
            Destroy(gameObject);
        }
        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);

        if(transform.position.x < player.transform.position.x && !addedScore)
        {
            GameManager.thisManager.UpdateScore(10);
            addedScore = true;
        }

    }
}
