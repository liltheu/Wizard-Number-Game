using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardNumber : MonoBehaviour
{
    int max;
    int min;
    int numeroAdvinhado;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        numeroAdvinhado = 500;

        Debug.Log("Bem vindo ao Advinhador de Numeros !");
        Debug.Log("Pense em um numero, e não me fale qual é !");
        Debug.Log("O maior numero que você pode pensar é :" + max);
        Debug.Log("O menor numero que você pode pensar é :" + min);
        Debug.Log("Me diz se o numero que você pensou é maior ou menor que : " + numeroAdvinhado);
        Debug.Log("Aperte para cima se = Maior, Aperte para baixo se = Menor, e Enter se = Correto!");
        max = max + 1;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = numeroAdvinhado;
            ProximoAdvinha();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = numeroAdvinhado;
            numeroAdvinhado = (max + min) / 2;
            ProximoAdvinha();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Eu acertei o numero é : " + numeroAdvinhado + " !!");
            StartGame();
        }
    }
    void ProximoAdvinha()
    {
        numeroAdvinhado = (max + min) / 2;
        Debug.Log("É maior ou menor que .." + numeroAdvinhado);
    }
}
