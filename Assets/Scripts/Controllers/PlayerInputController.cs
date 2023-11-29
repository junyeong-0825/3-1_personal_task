using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }


    public void OnMove(InputValue value)
    {
        //Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); //���콺 �������� ������
        Vector2 WorldPos = _camera.ScreenToWorldPoint(newAim); //�������������� ��ȯ
        newAim = (WorldPos - (Vector2)transform.position).normalized; //�밢������ �̵��� �� 1�� �ӵ��� �̵��ϵ��� �� (���� 2�� ���������� ������)

        if (newAim.magnitude >= .9f)
        {
            CallOnLookEvent(newAim);
        }
    }
    public void OnFire(InputValue value)
    {

    }
}
