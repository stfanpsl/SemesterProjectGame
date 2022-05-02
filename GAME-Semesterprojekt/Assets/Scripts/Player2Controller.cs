using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float horizontalInput, verticalInput, rotationInput, viewY;
    public float speed = 10, rotationSpeed = 300;
    public GameObject Island;
    Vector3 Vforward, Vright;

    // Start is called before the first frame update
    void Start()
    {
        Island = GameObject.Find("Island");
        // InverseTransformVector try to change it form wold to local
    }

    // Update is called once per frame
    void Update()
    {
        // convert local input to world coordinate
        // so that player always moves up, when steering up, independent of player rotation
        Vforward = transform.InverseTransformVector(Vector3.forward);
        Vright = transform.InverseTransformVector(Vector3.right);

        // Get inputs
        horizontalInput = Input.GetAxis("Horizontal2");
        verticalInput = Input.GetAxis("Vertical2");
        rotationInput = Input.GetAxis("Rotate2");
        viewY = Input.GetAxis("5th Axis");

        // change player position and rotation
        transform.Translate(Vright * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vforward * speed * verticalInput * Time.deltaTime);

        transform.Rotate(Island.transform.up, rotationSpeed * rotationInput * Time.deltaTime, Space.World);

    }
}
