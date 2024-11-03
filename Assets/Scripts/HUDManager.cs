using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI Bulletscount;

    public void AtualizacaoBullet(int municao)
    {
        Bulletscount.text = municao.ToString();
    }
}
