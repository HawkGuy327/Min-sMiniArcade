using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffortAnimation : MonoBehaviour
{
    public Sprite normal;
    public Sprite pressed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<SpriteRenderer>().sprite = pressed;
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            GetComponent<SpriteRenderer>().sprite = normal;
        }
    }
}
