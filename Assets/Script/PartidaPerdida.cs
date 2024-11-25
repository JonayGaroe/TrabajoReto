using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PartidaPerdida : MonoBehaviour
{

    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;


    float tiempoDePartida = 0.0f;
    bool estaJugando = true;




    private void Update()
    {

        if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;

        }
    }

    private void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Player")

        {

            Debug.Log("Jugador llego a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<Movimiento>().enabled = false;
            estaJugando = false;
            textLabelTime.text = tiempoDePartida.ToString();

        }

    }





}
