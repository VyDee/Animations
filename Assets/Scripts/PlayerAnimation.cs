using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    private string SLEEP_END_ANIMATION = "sleep_end";
    private string IDLE_ANIMATION = "idle";
    private string WALK_PARAMETER = "Walk";
    private string ATTACK_1_PARAMETER = "Attack1";
    private string ATTACK_2_PARAMETER = "Attack2";


	// Use this for initialization
	void Awake ()
    {
        this.anim = GetComponent<Animator>();
    }

    public void Attack1()
    {
        this.anim.SetBool(ATTACK_1_PARAMETER, true);
    }
    public void EndAttack1 ()
    {
        this.anim.SetBool(ATTACK_1_PARAMETER, false);
    }

    public void Attack2()
    {
        this.anim.SetBool(ATTACK_2_PARAMETER, true);
    }
    public void EndAttack2 ()
    {
        this.anim.SetBool(ATTACK_2_PARAMETER, false);
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














