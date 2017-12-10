using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private float side;
    private float height;

    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("Player");
        this.side = player.transform.position.x - this.transform.position.x;
        this.height = player.transform.position.y - this.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.player.transform.position.x - side, this.player.transform.position.y - height, this.transform.position.z);
    }
}
