using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        int numero = (max+min/2);
        Debug.Log("Bem vindo ao Advinhador de Numeros !");
        Debug.Log("Pense em um numero, e não me fale qual é !");
        Debug.Log("O maior numero que você pode pensar é :" +max);
        Debug.Log("O menor numero que você pode pensar é :" +min);
        Debug.Log("Me diz se o numero que você pensou é maior ou menor que : " +numero);
        Debug.Log("Aperte para cima se = Maior, Aperte para baixo se = Menor, e Enter se = Correto!");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Seta Para cima foi apertada!");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Seta Para baixo foi apertada!");
        }
    }
}
