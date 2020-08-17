using UnityEngine;

public class GunLogic : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float rateOfFire;

    public bool isBurst = false;

    public Camera playerCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
                Debug.Log("Damage Dealt");
            } 
            else if(target == null)
            {
                Debug.Log("Target is null");
            }
        }

        
    }
}
