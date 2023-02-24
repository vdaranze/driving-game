using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Offset camera behind the player by adding to the players position with a new Vector3
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
