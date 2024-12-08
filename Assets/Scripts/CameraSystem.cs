using Unity.VisualScripting;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public GameObject triggerCam;
    public GameObject curCam;
    public GameObject player;

    public GameObject target;

    private void Update()
    { 
        if (curCam == triggerCam)
        {
            target.SetActive(false);
        }

    }

    private void LateUpdate()
    {
        if(curCam.CompareTag("Follow Camera"))
        {
            Vector3 desiredPosition = new Vector3(curCam.transform.position.x, curCam.transform.position.y, player.transform.position.z);

            curCam.transform.position = desiredPosition;
            curCam.transform.LookAt(player.transform);
        }
    }
}
