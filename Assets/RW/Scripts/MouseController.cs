using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float jetpackForce = 75.0f;
    private Rigidbody2D playerRigidbody;

    // Use this for initialization
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void FixedUpdate()

    {
        bool jetpackActive = Input.GetButton("Fire1");

        if (jetpackActive)

        {
            playerRigidbody.AddForce(new Vector2(0, jetpackForce));
        }
    }
}
