using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    public float scrollSpeed;

    void Update()
    {
        Movement();

        Zoom();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
    }

    private void Zoom()
    {
        float scroll = Input.GetAxis("ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;

        transform.position = pos;

    }
}
