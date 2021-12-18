using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation: MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    public bool direction = false;
    public int ang = 0;
    
    void FixedUpdate()
    {
        if (direction == false)
        {
            CenterCircle.transform.Rotate(0, 0, 150 * Time.deltaTime);
            ang++;
        }
        else
        {
            CenterCircle.transform.Rotate(0, 0, -150 * Time.deltaTime);
            ang--;
        }

    }

    public void Button()
    {
        direction = !direction;
    }
}
