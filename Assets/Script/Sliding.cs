using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    private Animator animator;
    private bool isSliding = false;
    private BoxCollider2D boxCollider;

    [SerializeField]
    private float offsetY = 0.05738783f;

    [SerializeField]
    private float sizeY = 1.114776f;


    private Vector2 starOffset;
    private Vector2 startSize;
    void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();

        starOffset = boxCollider.offset;
        startSize = boxCollider.size;
    }

    // Update is called once per frame
    void Update()
    {
        bool canSlide = animator.GetBool("isFly") == false;
        if (canSlide)
        {
            if (isSliding)
            {
                bool isKeyUp = Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.DownArrow);
                if (isKeyUp)
                {
                    EndSlide();
                }
            }
            else
            {
                bool isKeyDown = Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow);
                if (isKeyDown)
                {
                    StarSlide();
                }
            }
        }
    }

    private void StarSlide()
    {
        boxCollider.offset = new Vector2(starOffset.x, offsetY);
        boxCollider.size = new Vector2(startSize.x, sizeY);

        isSliding = true;
        animator.SetBool("isCrouch", isSliding);
    }
    private void EndSlide()
    {
        boxCollider.offset = starOffset;
        boxCollider.size = startSize;

        isSliding = false;
        animator.SetBool("isCrouch", isSliding);
    }
}

