using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {
    [SerializeField]
    private float start;

    [SerializeField]
    private float end;

    private float delta;
    private GameObject icon;
    private float progress = 0;

    public void setProgress(float progress)
    {
        this.progress = Mathf.Clamp01(progress);
    }

    public float getProgress() {
        return progress;
    }

    private void Start()
    {
        this.icon = this.transform.GetChild(0).gameObject;
        this.delta = this.end - this.start;
    }

    void Update ()
    {
        Vector3 cPosition = Camera.main.ScreenToWorldPoint(new Vector3(1850, 600, 0));
        Vector3 position = new Vector3(cPosition.x, cPosition.y, 0);
        this.transform.position = position;
        this.icon.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + this.start + this.progress * this.delta);
	}
}
