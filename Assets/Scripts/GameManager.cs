using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float goalDistance = 100f;
    private GameObject goal;
    private GoalController goalController;
    private GameObject player;
    private CarHealth carHealth;
    private Distance carDistance;
    private bool isRunning = true;
    public int spookyLevel = 0;

    void Start()
    {
        this.goal = GameObject.Find("Goal");
        this.goalController = this.goal.GetComponent<GoalController>();
        this.player = GameObject.Find("Player");
        this.carHealth = player.GetComponent<CarHealth>();
        this.carDistance = this.player.GetComponent<Distance>();
    }

    void Update()
    {
        if(!this.isRunning)
        {
            return;
        }

        float progress = Mathf.Clamp01(this.carDistance.GetDistance() / this.goalDistance);
        this.goalController.setProgress(progress);

        if(progress >= 0.99f)
        {
            this.isRunning = false;
            SceneManager.LoadScene("Win");
        }
        if (!carHealth.isAlive())
        {
            this.isRunning = false;
            SceneManager.LoadScene("Lose");
        }
    }

    public void raiseSpookyLevel() {
        if(spookyLevel < 3) {
            spookyLevel++;
        }
    }

    public void lowerSpookyLevel() {
        if(spookyLevel > 0) {
            spookyLevel--;
        }
    }

    public int getSpookyLevel() {
        return spookyLevel;
    }
}