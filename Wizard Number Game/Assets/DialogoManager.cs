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

    public IEnumerator StartDialogo(Dialogo dialogo)
    {
        for (int i = 0; i < frases.Count; i++)
        {
            yield return new WaitForSeconds(5);
            Debug.Log(dialogo.frases[i]);
        }
    }
}
