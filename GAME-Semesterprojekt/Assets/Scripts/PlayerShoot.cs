using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float impulsStrength;
    public bool hasAmmunition;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        hasAmmunition = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 SpawnPosition = new Vector3(0, 0, 1);
        if (Input.GetKeyDown(KeyCode.Space) && hasAmmunition)
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            hasAmmunition = false;
        }
    }

    public void addForceToSelf()
    {
        playerRb.AddForce(Vector3.forward * impulsStrength, ForceMode.Impulse);
    }



}
