using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    private int vida = 5;
    public TextMeshProUGUI Bulletscount;

    public TextMeshProUGUI HP;

    public PlayerMovement player;

    private void Start()
    {
        HP.text = vida.ToString();
        
    }
    public void AtualizacaoBullet(int municao)
    {
        Bulletscount.text = municao.ToString();
    }


  
}
