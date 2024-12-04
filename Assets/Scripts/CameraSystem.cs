using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public GameObject triggerCam;
    public GameObject curCam;
    public GameObject player;

    public GameObject target;
    private Vector3 playerPosition;
    private Vector3 cameraPosition;

    private void Update()
    {
        playerPosition = player.transform.position;
        cameraPosition = curCam.transform.position;
        if (curCam == triggerCam)
        {
            target.SetActive(false);
        }

        // Acho que não funciona

        //if (curCam.CompareTag("Follow Camera"))
        //{
        //    cameraPosition = new Vector3(playerPosition.x, cameraPosition.y, cameraPosition.z);
        //    curCam.transform.Translate(cameraPosition);  
        //}
    }
}
