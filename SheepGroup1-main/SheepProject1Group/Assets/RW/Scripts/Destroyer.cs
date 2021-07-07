using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject sheep;
    public GameObject seno;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sheep.transform.position.y <= -20)
        {
            Destroy(sheep);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().isKinematic = false;
  
    }
}
