using UnityEngine;

public class Target : MonoBehaviour
{
    public float hp = 100f;

    public void TakeDamage(float dmg)
    {
        hp = hp - dmg;
        Debug.Log("Damage Taken");
        if (hp <= 0f)
        {
            eliminated();
        }
    }

    void eliminated()
    {
        Destroy(gameObject);
    }
}
