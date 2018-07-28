using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour {
    [SerializeField, Range(0, 20)]
    private int health = 5;

    [SerializeField, Range(0,5)]
    private int dmg = 1;

    [SerializeField]
    private GameObject healthIcon;

    private List<GameObject> healthIcons = new List<GameObject>();

    private bool alive = true;

    public void Update()
    {
        this.drawHealth();
    }

    public bool isAlive()
    {
        return this.alive;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            this.health -= this.dmg;
            if (this.health <= 0)
            {
                this.alive = false;
            } else
            {
                Destroy(collision.gameObject);
            }
        }
    }

    private void drawHealth()
    {
        GameObject icon;
        int index = 1;

        if(this.healthIcons.Count < this.health)
        {
            while(this.healthIcons.Count < this.health)
            {
                this.healthIcons.Add(Instantiate(this.healthIcon, new Vector3(0, 0, 0), transform.rotation) as GameObject);
            }
        } else if(this.healthIcons.Count > this.health)
        {
            while (this.healthIcons.Count > this.health)
            {
                icon = this.healthIcons[this.healthIcons.Count-1];
                this.healthIcons.RemoveAt(this.healthIcons.Count-1);
                Destroy(icon);
            }
        }

        foreach(GameObject obj in this.healthIcons)
        {
            Vector3 cPosition = Camera.main.ScreenToWorldPoint(new Vector3(index * 50, 50, 0));
            Vector3 position = new Vector3(cPosition.x, cPosition.y, 0);
            obj.transform.position = position;
            index++;
        }
    }
}
