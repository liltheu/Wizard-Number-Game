using UnityEngine;

[ExecuteInEditMode]
public class TextMeshBehaviour : MonoBehaviour
{

    public string NameLayer;
    public int OrderLayer;

    void Awake()
    {
        GetComponent<Renderer>().sortingLayerName = NameLayer;
        GetComponent<Renderer>().sortingOrder = OrderLayer;
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            GetComponent<Renderer>().sortingLayerName = NameLayer;
            GetComponent<Renderer>().sortingOrder = OrderLayer;
        }
    }

    public void getRender()
    {
        GetComponent<Renderer>().sortingLayerName = NameLayer;
        GetComponent<Renderer>().sortingOrder = OrderLayer;
    }
}