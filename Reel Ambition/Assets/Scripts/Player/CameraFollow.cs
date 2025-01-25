using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //You can set the player as the target to be follow
    public Transform player;

    void start()
    {
  
    }

    //makes sure the camera cannot leave the bounds of position 7 and -7 on the x axis 
    void Update()
    {
        if (player.transform.position.x <= 0.31 & player.transform.position.x >= -0.31)
        {
            transform.position = player.transform.position + new Vector3(0, 1, -5);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, player.transform.position.z) + new Vector3(0, 1, -5);
        }
    }

}
