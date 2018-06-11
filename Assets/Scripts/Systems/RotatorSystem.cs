using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class RotatorSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        foreach (var item in GetEntities<Components>())
        {
            float deltaTime = Time.deltaTime;

            item.transform.Rotate(0f, item.rotator.speed * deltaTime, 0f);
        }
    }

    private struct Components
    {
        public RotatorComponent rotator;
        public Transform transform;
    }
}