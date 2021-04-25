using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;

    float x, z;
    Vector3 Movement;

    Transform respawn;

    // Update is called once per frame
    void Update()
    {
        z = Input.GetAxisRaw("Vertical") * speed;

        Movement = Vector3.forward * z;

        rb.velocity = new Vector3(0, rb.velocity.y, Movement.z);

    }
}
