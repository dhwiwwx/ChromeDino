using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float StarMoveSpeed = 5f;
    [SerializeField]
    private float SpeedUp = 0.0001f;

    private float MoveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
    }
}