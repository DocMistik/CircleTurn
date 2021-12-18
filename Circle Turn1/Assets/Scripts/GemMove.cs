using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemMove : MonoBehaviour
{
    [SerializeField] GameObject Gem;
    [SerializeField] float speed;

    private void FixedUpdate()
    {
        Gem.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
