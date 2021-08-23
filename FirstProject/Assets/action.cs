using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour
{
    private CharacterController car;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<CharacterController>();
        player = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        move.x = Input.GetAxis("Horizontal") * Time.deltaTime;
        move.z = Input.GetAxis("Vertical") * Time.deltaTime;
        move.y -= 3f * Time.deltaTime;
        car.Move(player.TransformDirection(move));
    }
}
