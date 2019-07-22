﻿using UnityEngine;

//Using interface makes the classes implementing it more predictable
namespace UnityAD
{
    public interface ICollideAble
    {
        void ReactToCollision(GameObject gameObject, Collision collision);
    }
}
