using UnityEngine;

public class VERT : MonoBehaviour
{
    public Transform button; 
    public float buttonDownDistance = 0.1f; 

    private Vector3 buttonStartPosition; 
    void Start()
    {
        buttonStartPosition = button.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            button.position -= Vector3.up * buttonDownDistance;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            button.position = buttonStartPosition;
        }
    }
}
