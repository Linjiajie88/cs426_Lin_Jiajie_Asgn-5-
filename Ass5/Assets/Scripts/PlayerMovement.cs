using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 12f;
    public float jumpSpeed = 12f;
    public float gravity = 24f;

    public bool speedBoost = false;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        moveDirection.z =0;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }

    IEnumerator ApplySpeedBoost() {
        float oldSpeed = speed;

        // apply speed boosts
        speed = speed + 30f;
        yield return new WaitForSeconds(7f);

        // apply old settings
        speed = oldSpeed;

        // turn off speed boost;
        speedBoost = false;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("SpeedCache")) {
            if (!speedBoost) {
                speedBoost = true;
                StartCoroutine("ApplySpeedBoost");
            }
        }
    }

}
