using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoMovement : MonoBehaviour
{
    [SerializeField]public float speed = 10;
    [SerializeField]public Vector3 direction = new Vector3 (0, 0, 1);
    [SerializeField] private GameObject particle;
    [SerializeField] private GameObject sheep;
    public Rigidbody rb ;

    void Start()
    {
         
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);        
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "sheep")
        {
            Destroy(other.gameObject);
           //GameObject particle =  Instantiate(particle, );
        } 
    }
  
}
