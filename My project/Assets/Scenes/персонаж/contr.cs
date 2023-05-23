using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class contr : MonoBehaviour
{
    public float speed = 5f; // �������� ����������� ���������
    public Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // �������� �������� �� ����������� �� ����������
        float vertical = Input.GetAxis("Vertical"); // �������� �������� �� ��������� �� ����������

        Vector2 movement = new Vector2(horizontal, vertical);
        rb.velocity = movement * speed; // ������������� �������� ����������� ���������

        // ������������� �������� ��� ���������� ��������� � ����������� �� ����������� ��������
        if (horizontal != 0)
        {
            animator.SetFloat("horizontal", horizontal);
            animator.SetFloat("vertical", 0f);
        }
        else if (vertical != 0)
        {
            animator.SetFloat("horizontal", 0f);
            animator.SetFloat("vertical", vertical);
        }
        else
        {
            animator.SetFloat("horizontal", 0f);
            animator.SetFloat("vertical", 0f);
        }

        // ������������� �������� �������� � ����������� �� �������� ����������� ���������
        animator.SetFloat("speed", movement.magnitude);

        // ������� �������� � ���������� ���������
        UnityEngine.Debug.Log("Horizontal: " + horizontal);
        UnityEngine.Debug.Log("Vertical: " + vertical);
        UnityEngine.Debug.Log("Movement: " + movement);
        UnityEngine.Debug.Log("Speed: " + movement.magnitude);
    }
}
