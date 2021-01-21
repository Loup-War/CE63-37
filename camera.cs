using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform charactertarget;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public bool LookAtPlayer = false;
    public bool RotateAroundPlayer = true;
    public float RotationSpeed = 0.050f;

    void LateUpdate()
    {
        //if (RotateAroundPlayer)
        //{
        //    Quaternion cameraTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);
        //    offset = cameraTurnAngle * offset;
        //}

        Vector3 desiredPosition = charactertarget.position + offset;
        Vector3 smootherdPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smootherdPosition;

        //if (LookAtPlayer || RotateAroundPlayer)
        //    transform.LookAt(charactertarget);


    }
}
