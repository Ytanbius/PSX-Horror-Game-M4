using System.Runtime.CompilerServices;
using Unity.Cinemachine;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CollisionManager : MonoBehaviour
{
    public GameObject interact;
    private void OnTriggerStay(Collider other)
    {
        //bool key = other.GetComponent<PlayerMovement>().hasKey;

        if(transform.CompareTag("Casa") && interact == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(3);
        }
        else if(transform.CompareTag("End") && interact == true && Input.GetKeyDown(KeyCode.E))
        {
            
        }
    }
}
