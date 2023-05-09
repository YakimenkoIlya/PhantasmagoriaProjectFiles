using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    private float firstLatitude;
    private float firstLogitude;
    private float secondLatitude;
    private float secondLogitude;

    public float multi;

    private void Update()
    {
        firstLatitude = Input.location.lastData.latitude;
        firstLogitude = Input.location.lastData.longitude;

        secondLatitude = Input.location.lastData.latitude;
        secondLogitude = Input.location.lastData.longitude;

        //////////////////
        //Debug.Log("Latitude: " + firstLatitude);
        //Debug.Log("Logitude: " + firstLogitude);
        /////////////////

        //transform.Translate(new Vector3(1, 0, 1));

        //transform.position += new Vector3((secondLogitude - firstLogitude) * 
            //multi, 0, (secondLatitude - firstLatitude) * multi);
    }
}

//using UnityEngine;

/*public class ExampleClass : MonoBehaviour
{
    //movement speed in units per second
    private float movementSpeed = 5f;

    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        //output to log the position change
        Debug.Log(transform.position);
    }
}
*/