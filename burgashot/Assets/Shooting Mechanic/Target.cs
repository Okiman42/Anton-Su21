using UnityEngine;

public class Target : MonoBehaviour
{
    public float health;

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Hit(float damage)
    {
        Debug.Log("Hit for " + damage + "damage!");
    }
}