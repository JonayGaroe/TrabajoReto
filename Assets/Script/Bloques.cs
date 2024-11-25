using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Bloques : MonoBehaviour
{

    public int bloquesCount = 37;
    public TextMeshProUGUI bloquesText;
    public AudioClip Bloquefx;


    // Start is called before the first frame update
    void Start()
    {
        bloquesCount = 37;

    }

    // Update is called once per frame
    void Update()
    {
        
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
            AudioSource.PlayClipAtPoint(Bloquefx, transform.position);
        }



    }


}
