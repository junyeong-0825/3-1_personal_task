using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    // event 외부에서는 호출하지 못하게 막는다
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
// 이동 연습 코드
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