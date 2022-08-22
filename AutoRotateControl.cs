using UnityEngine;
public class AutoRotateControl : MonoBehaviour
{
    [Header("Rotate any GameObject on individual world axis and controlling their speed.")]
    [Header("Notes")]
    [TextArea(1,1)]
    public string notes;

    [Header("Settings")]
    [Tooltip("Defines the key and settings of the rotator")]
    [Space(10f)]
    public KeyCode startRotateKey;
    public KeyCode resetRotationKey;
    public bool keyPressEnable;
    bool enableAuto;

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
    Vector3[] originalRotation;

    void Start() 
    {
        originalRotation = new Vector3[objectToRotate.Length];

        for(int i = 0; i < objectToRotate.Length; i++)
        {
            originalRotation[i] = objectToRotate[i].transform.eulerAngles;
        }

        if(keyPressEnable)
        {
            enableAuto = false;
        }
        else
        {
            enableAuto = true;
        }
    }

    void Update()
    {
        if (enableAuto)
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

        if (keyPressEnable)
        {
            if (Input.GetKeyDown(startRotateKey))
            {
                enableAuto = true;
            }

            if (Input.GetKeyDown(resetRotationKey))
            {
                ResetRotation();
                enableAuto = false;
            }
        }
    }

    public void ResetRotation()
    {
        for(int i = 0; i < objectToRotate.Length; i++)
        {
            objectToRotate[i].transform.eulerAngles = originalRotation[i]; 
        }
    }
}
