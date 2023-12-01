using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMAnager : MonoBehaviour
{

    public TextMeshProUGUI hud, Mensagemdevitoria;
    public int restantes;
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Moedas restantes: {restantes}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
