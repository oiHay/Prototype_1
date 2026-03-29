using UnityEngine;

public class VehiclesBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * _speed));
    }
}
