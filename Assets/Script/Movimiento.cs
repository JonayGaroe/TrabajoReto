using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    // en otro script
   // public float movementEjeX;
    //public float fastmovement = 3f;
   // public float movementEjeY;
   // public float movementEjeZ;
    //SONIDO


    public int bloquesCount = 37;
    public TextMeshProUGUI bloquesText;
  //  public AudioClip Bloquefx;



    // Start is called before the first frame update
    void Start()
    {
        //GameObject conteo = GameObject.Find("bloqueo");
        
        
        bloquesCount = 37;

    }

    // Update is called once per frame
    void Update()
    {


       // Vector3 movement = new Vector3();

      //  movementEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * fastmovement;
       // transform.Translate(movementEjeX, movementEjeY, movementEjeZ);

     
        //Debug.Log("Estoy tocando Boton");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bloquesss"))
        {
            bloquesCount = bloquesCount - 1;
            Debug.Log("He tocado el Bloque " + bloquesCount);
            other.gameObject.SetActive(false);

        }
        if (other.tag.Contains("bloquesss"))
        {

            bloquesText.text = bloquesCount.ToString();
            other.gameObject.SetActive(false);
         //   AudioSource.PlayClipAtPoint(Bloquefx, transform.position);

        }



    }








}
