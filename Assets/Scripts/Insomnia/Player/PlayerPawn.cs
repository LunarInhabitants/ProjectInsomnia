using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerPawn : MonoBehaviour
{
    public float playerRunSpeed = 5.0f;

    public AbstractPlayerController PlayerController { get { return playerController; } }
    public Vector3 Velocity { get { return RB.velocity; } set { RB.velocity = value; } }
    public Quaternion Rotation { get { return RB.rotation; } set { RB.rotation = value; } }

    private AbstractPlayerController playerController = null;
    private Rigidbody RB = null;

    void Start()
    {
        playerController = GetComponent<AbstractPlayerController>();
        RB = GetComponent<Rigidbody>();

        PLBManager plbMgr = FindObjectOfType<PLBManager>();

        if (plbMgr && plbMgr.tileCreationController is PLBTileCreationController_Proximity)
        {
            ((PLBTileCreationController_Proximity)plbMgr.tileCreationController).proximityObjects.Add(gameObject);
        }
    }
	
	void Update()
    {
        Vector3 velocity = RB.velocity;
        velocity.x *= 0.9f;
        velocity.z *= 0.9f;
        RB.velocity = velocity;

        playerController.OnUpdate();
    }
}
