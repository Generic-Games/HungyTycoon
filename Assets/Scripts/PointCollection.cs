using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollection : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] private UIScores uiScore = null;

    [Header("Variables")]
    [SerializeReference] private int scoreMultiplier = 1;

    private void OnCollisionEnter(Collision coll)
    {
        int points = coll.collider.gameObject.GetComponent<BlipDataHolder>().blipData.pointValue;

        uiScore.IncreasePoints(points * scoreMultiplier);
    }
}
