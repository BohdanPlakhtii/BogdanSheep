using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorMowement : MonoBehaviour
{
    
    public float speed = 10f;
    private float direction;
    private bool mowe;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (mowe == true)
        {
            if((transform.position.x >= -17f)  && (direction == 1f))
            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }

            if ((transform.position.x <= 25f) && (direction == -1f))
            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
        }
        
    }

    public void Left()
    {
        direction = 1;
        mowe = true;
    }

    public void Right()
    {
        direction = -1;
        mowe = true;
    }

    public void Stop()
    {
        mowe = false;
    }

}
