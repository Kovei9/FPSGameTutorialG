using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class Spin : MonoBehaviour {
    public float speed = 6.0f;
    void Update() {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}