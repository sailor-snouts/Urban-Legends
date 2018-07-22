using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour {
    [SerializeField, Range(0, 20)]
    private float health = 5;
    [SerializeField, Range(0,20)]
    private float dmg = 5;
    private bool alive = true;

    public bool isAlive()
    {
        return this.alive;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            this.health -= this.dmg;
            if(this.health < 0)
            {
                this.alive = false;
            }
        }
    }
}
