/*using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Accelerometer sensor
    private Vector3 accelerometerInput;
    private Vector3 initialAccInput;

    // Speed of the camera movement
    public float speed = 1.0f;

    void Start()
    {
        // Check if device supports accelerometer
        if (!SystemInfo.supportsAccelerometer)
        {
            Debug.LogError("Device does not support accelerometer!");
        }
        else
        {
            // Calibrate the initial accelerometer input
            initialAccInput = Input.acceleration;
        }
    }

    void Update()
    {
        // Get accelerometer input
        accelerometerInput = Input.acceleration;

        // Removing gravity from the input and calibrate the input
        accelerometerInput = Quaternion.Euler(90, 0, 0) * (accelerometerInput - initialAccInput);
        accelerometerInput.y = 0;
        accelerometerInput.z = 0;

        // Update camera position
        transform.position += accelerometerInput * speed * Time.deltaTime;
    }
}*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    //public Text x;
    //public Text y;
    //public Text z;

    public float speed /*= 10.0f*/;
    private Vector3 initialPosition;

    void Start()
    {
        Input.gyro.enabled = true;
        initialPosition = transform.position;
    }

    void Update()
    {
        Quaternion rotation = Input.gyro.attitude;
        rotation.x *= -1;
        rotation.y *= -1;
        transform.localRotation = rotation;
        transform.position = initialPosition + rotation * new Vector3(Input.gyro.gravity.x, Input.gyro.gravity.y, Input.gyro.gravity.z) * speed;

        //x.text = transform.position.x.ToString();
        //y.text = transform.position.y.ToString();
        //z.text = transform.position.z.ToString();
    }
}
