using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 2f;
    public float maxZoom = 15f;
    public float pitch = 2f;
    public float yawSpeed = 100f;
    public float currentZoom = 3f;
    public float currentYaw = 0f;

    // Update is called once per frame
    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;// ZoomIn our Camera using Scroll Wheel
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);//Limits Zooming;

        currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + -Vector3.up * pitch);
        transform.RotateAround(target.position, Vector3.up, currentYaw);
    }
}
