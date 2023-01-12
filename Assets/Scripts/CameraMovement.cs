using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector2 turn;
    public float speed = 0.03f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y -= Input.GetAxis("Mouse Y");

        turn.y = Mathf.Clamp(turn.y, -60, 60);

        transform.localRotation = Quaternion.Euler(turn.y, turn.x, 0);

        transform.Translate(Input.GetAxisRaw("Horizontal") * speed, 0, Input.GetAxisRaw("Vertical") * speed);
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -19.5f, 9.5f),
            Mathf.Clamp(transform.position.y, 0, 10),
            Mathf.Clamp(transform.position.z, -9.5f, 19.5f));
    }
}
