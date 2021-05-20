using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float turnSpeed = 2;
    bool rotando;
    private void OnMouseDrag()
    {
        rotando = true;
        float rotX = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
    }

    private void OnMouseUp()
    {
        rotando = false;
    }
    private void Update()
    {
        if (rotando)
        {
            return;
        }
        CheckRotation();
    }

    void CheckRotation()
    {
        Vector3 actualRotation = transform.rotation.eulerAngles;
        if (actualRotation.y > 46 && actualRotation.y < 135)
        {
            Rotation(90);
        }
        else if (actualRotation.y > 136 && actualRotation.y < 225)
        {
            Rotation(180);
        }
        else if (actualRotation.y > 226 && actualRotation.y < 315)
        {
            Rotation(270);
        }
        else if (actualRotation.y > 316 && actualRotation.y < 405)
        {
            Rotation(0);
        }
        else if (actualRotation.y > 316 && actualRotation.y < 45)
        {
            Rotation(0);
        }
        else if (actualRotation.y > 0 && actualRotation.y < 45)
        {
            Rotation(0);
        }
    }
    void Rotation(float rotY)
    {
        Vector3 dir = new Vector3(0, rotY);
        Quaternion rotationAngles = Quaternion.Euler(dir);
        Vector3 rotation = Quaternion.Lerp(transform.rotation, rotationAngles, Time.deltaTime * turnSpeed).eulerAngles;
        transform.rotation = Quaternion.Euler(rotation.x, rotation.y, transform.rotation.z);
    }
}
