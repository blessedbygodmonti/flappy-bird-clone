using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    // The Target
    public Transform target;
    
    void LateUpdate () {
        if (transform == null) return;
        transform.position = new Vector3(target.position.x,
                                         transform.position.y,
                                         transform.position.z);
    }
}
