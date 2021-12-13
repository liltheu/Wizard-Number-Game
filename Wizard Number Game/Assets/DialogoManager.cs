using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoManager : MonoBehaviour
{

    private Queue<string> frases;
    void Start()
    {
        frases = new Queue<string>();
    }

    public void StartDialogo (Dialogo dialogo)
    {
        Debug.Log("Starting conversation With" + dialogo.nome);
    }
}
