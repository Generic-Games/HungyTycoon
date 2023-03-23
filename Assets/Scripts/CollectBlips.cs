using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBlips : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] private UIScores uiScore = null;

    [Header("Objects")]
    [SerializeField] private Sprite collectSprite = null;

    [Header("Variables")]
    [SerializeField] private float range = 1f;
    [SerializeField] private LayerMask collectablesLayer;

    private int pointMultiplier = 1;

    private Collider2D touchCollider = null;
    private Collider2D[] collectables = null;

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                touchCollider = Physics2D.OverlapCircle(touch.position, range, collectablesLayer);

                //If it touches any of the collectables
                if (touchCollider)
                {
                    Destroy(touchCollider.gameObject);
                    uiScore.IncreasePoints(pointMultiplier);
                }                
            }
        }

        //PC Debug
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            touchCollider = Physics2D.OverlapCircle(mousePos, range, collectablesLayer);

            //If it touches any of the collectables
            if (touchCollider)
            {
                Destroy(touchCollider.gameObject);
                uiScore.IncreasePoints(pointMultiplier);
            }
        }
    }
}
