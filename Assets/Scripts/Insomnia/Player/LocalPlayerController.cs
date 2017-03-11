using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPlayerController : AbstractPlayerController
{
    protected override void Start()
    {
        base.Start();
    }

    public override void OnUpdate()
    {
        Vector3 velocity = Pawn.Velocity;

        if (Input.GetKey(KeyCode.W))
            velocity.z = Pawn.playerRunSpeed;
        else if (Input.GetKey(KeyCode.S))
            velocity.z = -Pawn.playerRunSpeed;

        if (Input.GetKey(KeyCode.D))
            velocity.x = Pawn.playerRunSpeed;
        else if (Input.GetKey(KeyCode.A))
            velocity.x = -Pawn.playerRunSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
            velocity.y = 6.81f;

        Pawn.Velocity = velocity;

        Quaternion cameraRotation = Quaternion.Euler(45.0f, -30.0f, 0.0f);
        Vector3 cameraPosition = transform.position + new Vector3(0.0f, 2.0f, 0.0f) + (Camera.main.transform.rotation * new Vector3(0.0f, 0.0f, -10.0f));

        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, cameraRotation, 0.2f);
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, cameraPosition, 0.2f);

        //Look at cursor
        Pawn.Rotation = Quaternion.LookRotation(GetCursorPointOnPawnPlane() - Pawn.transform.position, Vector3.up);
    }

    Vector3 GetCursorPointOnPawnPlane()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane p = new Plane(new Vector3(0.0f, 1.0f, 0.0f), Pawn.transform.position);
        float d;
        if (p.Raycast(r, out d))
        {
            return r.origin + r.direction * d;
        }
        return r.origin;
    }
}
