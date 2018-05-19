using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{

    public float rotationSpeed = 3f;
    private float rotateY;
    private PlayerAnimation playerAnim;

    private float h, v;

	void Awake ()
    {
        playerAnim = GetComponent<PlayerAnimation>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckMovement();
        AnimatePlayer();
	}
    void CheckMovement()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        rotateY -= h * rotationSpeed;

        this.transform.localRotation = Quaternion.AngleAxis(rotateY, Vector3.up);
    }
    void AnimatePlayer ()
    {
        if (v !=0 )
        {
            playerAnim.PlayerWalk(true);
        }
        else
        {
            playerAnim.PlayerWalk(false);
        }

    }
}
