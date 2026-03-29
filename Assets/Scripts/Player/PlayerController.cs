using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Reference")] [SerializeField] private string _inputID;
    
    [Header("Movement Parameters")]
    [SerializeField] private float _speed;
    [SerializeField] private float _turnSpeed;
    
    [Header("Direction Valeu")]
    private float _horizontalInput;
    private float _verticalInput;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // Garante que a variável _horizontalInput receba e referencie os valores de "Horizontal" no Input Manager
        _horizontalInput = Input.GetAxis("Horizontal" + _inputID);

        // Garante que a variável _verticalInput receba e referencie os valores de "Vertical" no Input Manager
        _verticalInput = Input.GetAxis("Vertical" + _inputID);
        
        // Move o carro para frente baseado em inputs verticais
        transform.Translate(Vector3.forward * (Time.deltaTime * _speed * _verticalInput));  
        // Time.deltaTime verifica quando um segundo passou
        // * _speed explicita que o objeto desloca x metros (valor total da variável) em 1 segundo
        // * _verticalInput explicita que o objeto desloca-se para frente (Axis positivo) ou para trás (Axis negativo) a partir do input pressionado pelo jogador
        
        // Rotaciona o carro para os lados baseado em inputs horizontais
        transform.Rotate(Vector3.up, Time.deltaTime * _turnSpeed * _horizontalInput);
        // transform.Rotate() indica que o objeto rotaciona, em vez de desloca
        // Vector3.up estabelece o vetor central direcionado para cima, no caso, "Y"
        // _turnSpeed referencia quão rápido o player pode "virar"
        // _horizontalInput explicita que o objeto desloca-se para direta (Axis positivo) ou para esquerda (Axis negativo) a partir do input pressionado pelo jogador
    }
}
