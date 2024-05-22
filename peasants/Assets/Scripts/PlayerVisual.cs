using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;

    private const string RUNNING = "Running";

    private void Awake(){
        animator = GetComponent<Animator>();
    }

    private void Update() {
        animator.SetBool(RUNNING, Player.Instance.Running());
    }
}
