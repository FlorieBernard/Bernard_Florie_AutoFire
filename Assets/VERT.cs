using UnityEngine;

public class VERT : MonoBehaviour
{
    public float sinkDistance = 0.5f; 
    public float sinkSpeed = 0.1f; 
    public LayerMask playerLayer; 

    private Vector3 initialPosition; 
    private bool isSinking = false; 

    void Start()
    {
        initialPosition = transform.position; 
    }

    void Update()
    {
        if (isSinking)
        {
            
            Vector3 targetPosition = new Vector3(initialPosition.x, initialPosition.y - sinkDistance, initialPosition.z);
            float step = sinkSpeed * Time.deltaTime;

            
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isSinking && (playerLayer & 1 << collision.gameObject.layer) != 0)
        {
            isSinking = true;
        }
    }
}
