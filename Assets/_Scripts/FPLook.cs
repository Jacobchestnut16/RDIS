using System;
using UnityEngine;

public class FPLook : MonoBehaviour
{
    public float sensitivity = 150f;
    public Transform player;

    float pitch = 0f;

    private void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        pitch = rot.x > 180 ? rot.x - 360 : rot.x;
    }

    void Update()
    {
        float mx = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float my = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * mx);

        pitch -= my;
        pitch = Mathf.Clamp(pitch, -80f, 80f);
        transform.localRotation = Quaternion.Euler(pitch, 0f, 0f);
    }
}