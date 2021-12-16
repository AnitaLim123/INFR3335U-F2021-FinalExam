using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class MovementJoystick : MonoBehaviour
{
    public Joystick joystick;
    public CharacterController player;
    Vector3 movementDirection;
    public float gravity = 15.0f;//Gravity intensity
    public float speed;
    Vector3 lastPosition = Vector3.zero;

    void Update()
    {
        float hori = joystick.Horizontal;
        float vert = joystick.Vertical;
        movementDirection = new Vector3(hori, 0, vert);
        movementDirection = transform.TransformDirection(movementDirection);

        movementDirection *= speed;

        movementDirection.y -= gravity;

        player.Move(movementDirection * Time.deltaTime);

    }
}