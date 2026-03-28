using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Cria referência para o player
    [SerializeField] private GameObject _player;

    // Cria uma nova variaável Vector3 nomeada, para facilitar a manutenção do código
    private Vector3 _offset = new(0, 6, -9);
    
    // LateUpdate ocorre após o Update do player, garante uma progressão mais estável da câmera, que mexe após o player
    void LateUpdate()
    {
        // Faz a câmera ter o mesmo transform.position do _player
        // "offset" garante que a câmera tenha um offset em relação a posição do jogador, melhorando seu posicionamento para visualização do jogo
        transform.position = _player.transform.position + _offset;
    }
}
