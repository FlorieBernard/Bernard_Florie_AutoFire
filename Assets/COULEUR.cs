using UnityEngine;

public class ChangeMaterialOnCollision : MonoBehaviour
{
    
    public Material newMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null && newMaterial != null)
            {
                renderer.material = newMaterial;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {

                renderer.material = null;
            }
        }
    }
}
