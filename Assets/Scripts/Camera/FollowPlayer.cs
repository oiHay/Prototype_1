using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Cria referência para o transform player
    [SerializeField] private Transform _playerTransform;
    // Cria referência qual botão será clicado para mudar a visão
    [SerializeField] private KeyCode _swithKey;

    // Cria variáveis de posição para o offset
    [Header("Offsets")]
    [SerializeField] private Vector3 _thirdPersonOffset = new(0, 6, -9);
    [SerializeField] private Vector3 _firstPersonOffset = new(0, 1.8f, 1.45f);

    private bool _isFirstPersonView = false;
    
    // LateUpdate ocorre após o Update do player, garante uma progressão mais estável da câmera, que mexe após o player
    void LateUpdate()
    {
        HandlingCameraView();
        OnCameraMove();
    }

    private void HandlingCameraView()
    {
        // GetKeyDown dispara apenas uma vez por pressionamento, sem flickering
        if (Input.GetKeyDown(_swithKey))
        {
            _isFirstPersonView = !_isFirstPersonView;
        }
    }

    private void OnCameraMove()
    {
        // Se estiver em primeira pessoa, use _firstPersonOffset, senão use _thirdPersonOffset
        Vector3 offset;
        if (_isFirstPersonView)
        {
            offset = _firstPersonOffset;
        }
        else
        {
            offset = _thirdPersonOffset;
        }
        
        // Posiciona a câmera para o transform do player + o offset desejado
        transform.position = _playerTransform.position + offset;
    }
}
