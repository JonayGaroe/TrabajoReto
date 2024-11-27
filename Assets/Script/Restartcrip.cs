using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Restartcrip : MonoBehaviour
{
    [SerializeField]
    GameObject finalPartida;

    [SerializeField]
    GameObject empiezaPartida;

    bool estaJugando = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EmpezarJuego()
    {
        empiezaPartida.SetActive(false);
        if (estaJugando == false)
        {
            estaJugando = true;
            empiezaPartida.SetActive(false);

        }


    }

    public void ReiniciarJuego()
    {

        estaJugando = false;
       // SceneManager.LoadScene("otraCosaa");
        finalPartida.SetActive(false);
        empiezaPartida.SetActive(true);


    }


}