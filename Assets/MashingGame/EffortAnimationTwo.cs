using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffortAnimationTwo : MonoBehaviour
{
    public Sprite normal;
    public Sprite pressed;
    public float time;
    float timer = 0;


    // Update is called once per frame
    void Update()
    {
        if (timer >= time) {
            GetComponent<SpriteRenderer>().sprite = pressed;
            timer = 0;
        }
        else if (timer > time/7 && timer < time)
        {
            GetComponent<SpriteRenderer>().sprite = normal;
        }
        timer += Time.deltaTime;
    }
}
