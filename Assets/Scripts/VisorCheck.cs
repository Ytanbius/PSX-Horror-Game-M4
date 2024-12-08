using UnityEngine;

public class VisorCheck : MonoBehaviour
{
    public Inimigo script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            script.seguindo = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            script.seguindo = false;
        }
    }
}
