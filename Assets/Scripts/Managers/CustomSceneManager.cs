using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    private void Awake()
    {
        // Assim que o jogo é iniciado, a engine compreende que o objeto com esse script não pode ser destruído durante a passagem de cenas
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        // Caso o jogador esteja em alguma cena e clique na tecla "ESC"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // A cena com index 0 será carregada
            LoadSceneByIndex(0);
        }
    }

    // Método usado para verificar qual o número do index será carregado como cena
    public void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
