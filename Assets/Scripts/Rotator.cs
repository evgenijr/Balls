using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    [SerializeField]private float Speed;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, Speed);
    }
}