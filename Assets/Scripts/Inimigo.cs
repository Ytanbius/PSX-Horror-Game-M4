using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
public class Inimigo : MonoBehaviour
{
    private NavMeshAgent inimigo;
    private Transform player;
    public bool seguindo = false;
    public float hp = 5; 
    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (seguindo == true)
        {
            inimigo.SetDestination(player.position);
        }
        else
        {
            inimigo.destination = transform.position;
        }

        if (hp <= 0) 
        {
            Destroy(this.gameObject);
        }
    }

  
}
