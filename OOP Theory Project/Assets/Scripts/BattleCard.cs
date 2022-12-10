using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

class BattleCard : MonoBehaviour
{
    public CardSO CardInfo;
    private float CurrentNum;
    public BattleCardObj YourCard;

    public BattleGameController BGC {get; set;}

    public TextMeshProUGUI Numero;

    public bool SuaCarta;
    public void Selecionado()
    {
        if (BGC.PodeJogar || SuaCarta == false)
        {
            YourCard.CardInfo = CardInfo;
            YourCard.gameObject.SetActive(true);
            if (SuaCarta)
            {
               BGC.StartCoroutine(BGC.Jogou());
                Debug.Log("Jogou");
            }
            Destroy(gameObject);
        }
    }
    float Num {
        set
        {
            if (value < 0)
            {
                CurrentNum = 0;
            }
            else
            {
                CurrentNum = value;
            }
        }
        }
    void Start()
    {
        Num = CardInfo.Num;

        if (SuaCarta)
        {
            Numero.text = CurrentNum.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
