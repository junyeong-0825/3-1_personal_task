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
        Vector2 newAim = value.Get<Vector2>(); //마우스 포지션을 가져옴
        Vector2 WorldPos = _camera.ScreenToWorldPoint(newAim); //월드포지션으로 변환
        newAim = (WorldPos - (Vector2)transform.position).normalized; //대각선으로 이동할 때 1의 속돌로 이동하도록 함 (원래 2의 제곱근으로 움직임)

        if (newAim.magnitude >= .9f)
        {
            CallOnLookEvent(newAim);
        }
    }
    public void OnFire(InputValue value)
    {

    }
}
