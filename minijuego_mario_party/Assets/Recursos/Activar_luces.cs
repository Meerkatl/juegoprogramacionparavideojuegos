using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_luces : MonoBehaviour
{
    public Light luzVela; // La luz de la vela
    private bool marioCerca = false; // Indica si el mario está cerca
    private bool peachCerca = false; // Indica si el peach está cerca
    public AudioSource audioSource; // El componente AudioSource

    void Start()
    {
        if (luzVela != null)
        {
            luzVela.enabled = false; // Apagar la luz al inicio
        }
    }

    void Update()
    {
        // Verificar si el jugador está cerca y presiona la tecla "E"
        if (marioCerca && Input.GetKeyDown(KeyCode.E))
        {
            if (!luzVela.enabled)
            {
                Marcador.instance.UpdateScoreMario();
            }
            EncenderLuz();
            //marcar punto para mario
        }
        else if(peachCerca && Input.GetKeyDown(KeyCode.O))
        {
            if (!luzVela.enabled)
            {
                Marcador.instance.UpdateScorePeach();
            }
            EncenderLuz();
            //marca punto para peach
        }
    }

    private void EncenderLuz()
    {
        if (luzVela != null)
        {
            if (!luzVela.enabled)
            {
                luzVela.enabled = !luzVela.enabled;
                audioSource.Play();
            }
            
        }
    }

    // Detectar cuando el jugador entra en el área de la vela
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tagMario")) // Asegúrate de que el jugador tenga la etiqueta "Player"
        {
            marioCerca = true;
        }
        else if(other.CompareTag("tagPeach"))
        {
            peachCerca = true;
        }
    }

    // Detectar cuando el jugador sale del área de la vela
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("tagMario"))
        {
            marioCerca = false;
        }
        else if(other.CompareTag("tagPeach"))
        {
            peachCerca = false;
        }
    }
}