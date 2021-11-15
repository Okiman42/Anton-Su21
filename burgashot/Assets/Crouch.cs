using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchController : MonoBehaviour
{
    public float CrouchHeight = 0.5f;
    public float CrouchSmoothTime = 0.5f;

    Vector3 m_StandingPosition;
    Vector3 m_CrouchingPosition;

    Vector3 m_CurrentVelocity;

    void Awake()
    {
        // Assume starting height is standing height.
        m_StandingPosition = transform.localPosition;

        // Move that position down to find crouching position.
        m_CrouchingPosition = transform.localPosition;
        m_CrouchingPosition.y = CrouchHeight;
    }

    void Update()
    {
        // Decide what height you want the camera to be moving towards this
        // frame.

        Vector3 targetPosition;

        if (Input.GetButton("C"))
        {
            targetPosition = m_CrouchingPosition;
        }
        else
        {
            targetPosition = m_StandingPosition;
        }

        // Smoothly move the camera towards that position.

        transform.localPosition = Vector3.SmoothDamp(
            transform.localPosition,
            targetPosition,
            ref m_CurrentVelocity,
            CrouchSmoothTime
        );
    }
}