using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // ������ �� run  �ִϸ��̼����� ��ȯ
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
        // �ִϸ��̼� ����
        anim.SetBool("IsRun", dir.magnitude > 0f);
    }
    
}
