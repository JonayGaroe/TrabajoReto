using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevetePalo : MonoBehaviour
{
    // Start is called before the first frame update



    public float movementEjeX;
    public float fastmovement = 20f;
    //public float movementEjeY;
    //public float movementEjeZ;
     Rigidbody rb;
   // bool PartidaOn = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //ForceMode.Impulse
        if (Input.GetAxis("Horizontal") != 1)
        {
       
           Vector3 movement = new Vector3();
           movement.x = Input.GetAxis("Horizontal") * Time.deltaTime * fastmovement;
           rb.AddForce(movement * fastmovement);
            // transform.Translate(movementEjeX, movementEjeY, movementEjeZ);

            // }
        }
    }
}
