using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private CarHealth carHealth;

    void Start()
    {
        player = GameObject.Find("Player");
        carHealth = player.GetComponent<CarHealth>();
      
    }

    void Update()
    {
        //losing state
        if (!carHealth.isAlive())
        {
            SceneManager.LoadScene("Lose");
        }
    }
}