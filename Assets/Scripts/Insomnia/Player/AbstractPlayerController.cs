using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractPlayerController : MonoBehaviour
{
    public PlayerPawn Pawn { get { return pawn; } }
    private PlayerPawn pawn = null;

	protected virtual void Start()
    {
        pawn = GetComponent<PlayerPawn>();
	}

    public abstract void OnUpdate();
}
