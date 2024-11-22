using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movimiento_de_mario : MonoBehaviour
{
    public float speed;
    public GameObject mario; // aqui pongo a mario controlado con wasd
    public GameObject peach; // aqui pongo a peach controlada con ijkl

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A y D o flechas izquierda/derecha
        float vertical = Input.GetAxis("Vertical");     // W y S o flechas arriba/abajo

        // Crear un vector de dirección basado en la entrada
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        // Normalizar la dirección para evitar velocidades mayores en diagonales
        direction.Normalize();

        // Mover a mario
        mario.transform.Translate(direction * speed * Time.deltaTime, Space.World);

        float horizontal2 = 0f;
        float vertical2 = 0f;

        if (Input.GetKey(KeyCode.J))
        {
            horizontal2 -= 1f; // Movimiento hacia la izquierda
        }
        if (Input.GetKey(KeyCode.L))
        {
            horizontal2 += 1f; // Movimiento hacia la derecha
        }
        if (Input.GetKey(KeyCode.I))
        {
            vertical2 += 1f; // Movimiento hacia adelante
        }
        if (Input.GetKey(KeyCode.K))
        {
            vertical2 -= 1f; // Movimiento hacia atrás
        }

        Vector3 direction2 = new Vector3(horizontal2, 0f, vertical2);
        direction2.Normalize();

        // Mover a peach
        peach.transform.Translate(direction2 * speed * Time.deltaTime, Space.World);
    }
}
