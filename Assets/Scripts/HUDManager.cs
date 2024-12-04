using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour
{
    private int vida = 5;
    public TextMeshProUGUI Bulletscount;

    public TextMeshProUGUI HP;

    public PlayerMovement player;

    private void Update()
    {
        HP.text = vida.ToString();
        if (vida <= 0)
            SceneManager.LoadScene(2);
        if (Input.GetKeyDown(KeyCode.M))
            vida -= 1;
    }
    public void AtualizacaoBullet(int municao)
    {
        Bulletscount.text = municao.ToString();
    }
}
