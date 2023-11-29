using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // 움직일 때 run  애니메이션으로 전환
    TopDownCharacterController controller;

    [SerializeField] private Animator anim;

    private void Awake()
    {
        controller = GetComponent<TopDownCharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += AnimState;
    }

    void AnimState(Vector2 dir)
    {
        // 애니메이션 변경
        anim.SetBool("IsRun", dir.magnitude > 0f);
    }
    
}
