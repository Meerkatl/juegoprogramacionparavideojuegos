using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Marcador : MonoBehaviour
{
    public static Marcador instance;
    public int scoreMario;
    public int scorePeach;
    public Image imageComponentMario; // Referencia al componente Image el de mario
    public Image imageComponentPeach; // Referencia al componente Image el de peach
    public Sprite[] scoreSpritesMario; // Arreglo de imágenes (Sprites) para los diferentes puntajes
    public Sprite[] scoreSpritesPeach; // Arreglo de imágenes (Sprites) para los diferentes puntajes

    public void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void UpdateScoreMario()
    {
        scoreMario +=1;
        if (scoreMario > 4)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
                AddPointMario();
        }

        Debug.Log("se esta sumando");
    }
    public void UpdateScorePeach()
    {
        scorePeach +=1;
        if (scorePeach > 4)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
                AddPointPeach();
        }
    }
    public void AddPointMario()
    {
        if (scoreMario < scoreSpritesMario.Length)
        {
            imageComponentMario.sprite = scoreSpritesMario[scoreMario];
        }
    }
    public void AddPointPeach()
    {
        if (scorePeach < scoreSpritesPeach.Length)
        {
            imageComponentPeach.sprite = scoreSpritesPeach[scorePeach];
        }
    }
}