using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public static class EventManager 
{
    public static Func<PaddleControl> GetGameManagerClass;
    public static UnityEvent PickUpFriendPaddle = new UnityEvent();
}
