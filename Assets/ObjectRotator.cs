// using UnityEngine;

// public class NewMonoBehaviourScript : MonoBehaviour
// {
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         //xyz;
//     }
// }

using UnityEngine;
public class ObjectRotator : MonoBehaviour
{
    public float rotationSpeed = 100f;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Left/Right Arrow Keys
        float vertical = Input.GetAxis("Vertical"); // Up/Down Arrow Keys
        // Rotate the object
        transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right, -vertical * rotationSpeed * Time.deltaTime, Space.World);
    }
}