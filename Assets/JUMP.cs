using UnityEngine;

public class JUMP : MonoBehaviour
{
    public float jumpForce = 10f; // Force de saut du joueur

    void Update()
    {
        // Sauter si le joueur appuie sur la touche de saut (Espace)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Appliquer une force verticale au Rigidbody attaché au joueur
        GetComponent<Rigidbody>().AddForce(0, jumpForce, 0, ForceMode.Impulse);
    }
}
