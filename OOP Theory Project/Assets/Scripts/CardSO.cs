using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CardsInfo", menuName = "ScriptableObjects/Cards")]
public class CardSO : ScriptableObject
{
    public Image img;
    public float Num;
}
