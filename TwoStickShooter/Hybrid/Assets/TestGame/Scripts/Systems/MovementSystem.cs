using System.Collections;

using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class MovementSystem : ComponentSystem {

    private struct Data {
        public int Length;
        public ComponentArray<Movement> movement;
        public ComponentArray<Transform> transforms;
    }

    [Inject]
    private Data data;

    protected override void OnUpdate() {
        float delta = Time.deltaTime;

        for(int i = 0; i < this.data.Length; ++i) {
            float2 displacement = this.data.movement[i].velocity * delta;
            this.data.transforms[i].Translate(displacement.x, displacement.y, 0);
        }
    }

}
