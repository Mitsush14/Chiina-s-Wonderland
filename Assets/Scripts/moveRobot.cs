using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRobot : MonoBehaviour
{
    public CharacterController cController;
    public Transform cam;
    public float speed = 1f;
    public float speedRotation = 0.1f;
    float speedRotationVelocity;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, 0f, v).normalized;
        if(direction.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref speedRotationVelocity, speedRotation);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            cController.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }
}
