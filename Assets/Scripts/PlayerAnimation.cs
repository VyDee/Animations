using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    private string SLEEP_END_ANIMATION = "sleep_end";
    private string IDLE_ANIMATION = "idle";
    private string WALK_PARAMETER = "Walk";

	// Use this for initialization
	void Awake ()
    {
        this.anim = GetComponent<Animator>();
    }

    public void PlayerWalk (bool walk)
    {
        this.anim.SetBool(WALK_PARAMETER, walk);
    }


    void EndSleep()
    {
        this.anim.Play(SLEEP_END_ANIMATION);
    }
    void BeginIdle()
    {
        this.anim.Play(IDLE_ANIMATION);
    }
}














