using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Header("Movement Parameters")]
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    
    private float _verticalInput;
    private float _horizontalInput;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");
        
        // get the user's horizontal input
        _horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * (Time.deltaTime * _speed));

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, Time.deltaTime * _rotationSpeed * _verticalInput);
        
        // tilt the plane left/right based on left/right arrow keys
        transform.Rotate(Vector3.back, Time.deltaTime * _rotationSpeed * _horizontalInput);
    }
}
