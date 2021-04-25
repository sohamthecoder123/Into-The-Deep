using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    public Transform spawn;
    public Rigidbody rb;

    public int deaths;
    public float health = 100;
    public Text deatht, healtht;

    bool collideCor;

    void OnCollisionEnter (Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Death")
        {
            health = 0;
        }
    }

    void OnCollisionStay (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Corrupt")
        {
            health -= 10 * Time.deltaTime;
            collideCor = true;
            //Debug.Log(collideCor);
        }
    }

    void OnCollisionExit ()
    {
        collideCor = false;
        //Debug.Log(collideCor);
    }

    void Update ()
    {
        //health management
        health = Mathf.Clamp(health, 0, 100);
        if (health != 100)
        {
            if (health > 0 && !collideCor)
            {
                health += Time.deltaTime;
            }
            if (health == 0) Die();
        }

        //ui
        deatht.text = "Deaths: " + deaths;
        healtht.text = "Health: " + health;
    }

    void Die ()
    {
        transform.position = spawn.position;
        deaths += 1;
        health = 100;
    }

}
