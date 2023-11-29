using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    // event �ܺο����� ȣ������ ���ϰ� ���´�
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallOnLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
// �̵� ���� �ڵ�
//start is called before the first frame update
//void start()
//{

//}

//update is called once per frame
//void update()
//{

//    float x = input.getaxis("horizontal");
//    float y = input.getaxis("vertical");

//    transform.position += new vector3(x, y) * time.deltatime;
//}