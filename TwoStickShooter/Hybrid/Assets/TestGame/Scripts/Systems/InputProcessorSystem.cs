using System.Collections;

using UnityEngine;
using Unity.Entities;
using Unity.Transforms2D;
using Unity.Collections;
using Unity.Mathematics;

[AlwaysUpdateSystem]
public class InputProcessorSystem : ComponentSystem {

    private struct Data {
        public int Length;
        public ComponentArray<Identifier> identifier;
        public ComponentArray<PlayerInput> input;
        public ComponentArray<Movement> movement;
    }

    [Inject]
    private Data data;

    protected override void OnUpdate() {
        float x = 0;

        if (Input.GetKey(KeyCode.A)) {
            x -= 1.0f;
        }

        if (Input.GetKey(KeyCode.D)) {
            x += 1.0f;
        }

        float2 velocity = new float2(x, 0);

        for (int i = 0; i < this.data.Length; ++i) {
            this.data.movement[i].velocity = velocity;
        }
    }

}
