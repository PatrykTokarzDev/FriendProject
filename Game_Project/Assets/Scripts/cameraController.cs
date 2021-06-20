using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Local Variables
    Transform cam;
    [SerializeField] Transform player;
    [SerializeField] float offset = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get the camera's transform component
        cam = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get player's y position and set camera position accordingly
        Vector3 pos = new Vector3(0, player.position.y + offset, -10);
        cam.position = pos;
    }
}
