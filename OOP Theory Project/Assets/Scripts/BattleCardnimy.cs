using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleCardnimy : MonoBehaviour
{
    public List<GameObject> Cards;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Jogar()
    {
        Debug.Log("começou");
        Cards.Clear();
        VerCartas();
        Debug.Log("Viu");
        GameObject carta;
        foreach(GameObject Card in Cards)
        {
            if(Card.GetComponent<BattleCard>().CardInfo.Num == 0)
            {
                Card.GetComponent<BattleCard>().Selecionado();
                return;
            }
            Debug.Log("Não é");
        }
        carta = Cards[0];
        Debug.Log("Não é zero");
        for (int i = 1; i<Cards.Count; i++)
        {
            if (Cards[i].GetComponent<BattleCard>().CardInfo.Num > carta.GetComponent<BattleCard>().CardInfo.Num)
            {
                carta = Cards[i];
            }
        }
        Debug.Log("Chegou aqui");
        carta.GetComponent<BattleCard>().Selecionado();
    }
    public void VerCartas()
    {
        foreach(BattleCard card in gameObject.GetComponentsInChildren<BattleCard>())
        {
            Cards.Add(card.gameObject);
        }
    }
}
