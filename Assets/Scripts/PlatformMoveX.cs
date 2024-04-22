using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveX : MonoBehaviour
{
    private bool isPosDirection = true;
    // Update is called once per frame

    private void Start()
    {
        
    }

    void Update()
    {
        float posX = transform.position.x;
        if (posX <= -6.5f || posX >= -4.5f)
            ToggleDirection();
        float move = isPosDirection? 0.002f : -0.002f;
        transform.position += new Vector3(move, 0f, 0f);
    }

    void ToggleDirection()
    {
        isPosDirection = !isPosDirection;
    }
}
