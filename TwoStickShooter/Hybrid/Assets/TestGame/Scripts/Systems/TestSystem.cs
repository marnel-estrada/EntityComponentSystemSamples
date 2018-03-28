using System.Collections;

using UnityEngine;
using Unity.Entities;

public class TestSystem : ComponentSystem {

    private int counter = 0;

    protected override void OnUpdate() {
        //++counter;
        //Debug.Log("TestSystem: " + counter);
    }

}
