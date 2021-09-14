using UnityEngine;
using System.Collections;

public class TargetRotate : MonoBehaviour
{
    [SerializeField]private float speed;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, speed);
    }
}