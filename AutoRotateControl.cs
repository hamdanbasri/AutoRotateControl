using UnityEngine;

public class AutoRotateControl : MonoBehaviour
{
    [Header("Rotate any GameObject on individual world axis and controlling their speed.")]
    [Header("Notes")]
    [TextArea(1,1)]
    public string notes;

    [Header("Enable/Disable")]
    [Tooltip("Enable or Disable the rotation")]
    [Space(10f)]
    public bool enable;

    [Header("X Axis")]
    [Tooltip("Rotates the GameObject on the X Axis")]
    [Space(10f)]
    public bool PositiveX;
    public bool NegativeX;
    
    [Header("Y Axis")]
    [Tooltip("Rotates the GameObject on the Y Axis")]
    [Space(10f)]
    public bool PositiveY;
    public bool NegativeY;

    [Header("Z Axis")]
    [Tooltip("Rotates the GameObject on the Z Axis")]
    [Space(10f)]
    public bool PositiveZ;
    public bool NegativeZ;

    [Header("Speed Settings")]
    [Space(10f)]
    [Range(0, 200)]
    public float speed = 10f;

    [Tooltip("Selection of object to rotate")]
    [Space(10f)]
    public GameObject[] objectToRotate;

    void Update()
    {
        if (enable)
        {
            foreach (GameObject objToRotate in objectToRotate)
            {
                if (PositiveX == true)
                {
                    objToRotate.transform.Rotate(Vector3.right, speed * Time.deltaTime);
                }

                if (NegativeX == true)
                {
                    objToRotate.transform.Rotate(Vector3.left, speed * Time.deltaTime);
                }

                if (PositiveY == true)
                {
                    objToRotate.transform.Rotate(Vector3.up, speed * Time.deltaTime);
                }

                if (NegativeY == true)
                {
                    objToRotate.transform.Rotate(Vector3.down, speed * Time.deltaTime);
                }

                if (PositiveZ == true)
                {
                    objToRotate.transform.Rotate(Vector3.back, speed * Time.deltaTime);
                }

                if (NegativeZ == true)
                {
                    objToRotate.transform.Rotate(Vector3.forward, speed * Time.deltaTime);
                }
            }
        }
    }
}
