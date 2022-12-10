using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

class BattleGameController : GenericGameControler
{
    public int YourPoints, EnimyPoints;
    public bool PodeJogar;

    public GameObject CardInimigo, SeuCard, SuaMao, MaoInimiga, YourCardd, enimyCardd;

    public List<CardSO> Cartas, CurrentPossibleCards;

    public TextMeshProUGUI YP, EP;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<6; i++)
        {
            for(int j = 0; j<Cartas.Count; j++)
            {
                CurrentPossibleCards.Add(Cartas[j]);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            AddCards();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Jogou()
    {
        PodeJogar = false;
        yield return new WaitForSeconds(0.5f);
        MaoInimiga.GetComponent<BattleCardnimy>().Jogar();
        yield return new WaitForSeconds(1f);
        YourCardd.GetComponent<BattleCardObj>().Virar();
        enimyCardd.GetComponent<BattleCardObj>().Virar();
        yield return new WaitForSeconds(2.5f);
        if(YourCardd.GetComponent<BattleCardObj>().CurrentNum == 0 || enimyCardd.GetComponent<BattleCardObj>().CurrentNum == 0 || YourCardd.GetComponent<BattleCardObj>().CurrentNum == enimyCardd.GetComponent<BattleCardObj>().CurrentNum)
        {
            Debug.Log("Empate");
        }
        else if (YourCardd.GetComponent<BattleCardObj>().CurrentNum > enimyCardd.GetComponent<BattleCardObj>().CurrentNum)
        {
            YourPoints++;
            YP.text = YourPoints.ToString();
        }
        else
        {
            EnimyPoints++;
            EP.text = EnimyPoints.ToString();
        }
        YourCardd.SetActive(false);
        enimyCardd.SetActive(false);
        AddCards();
        yield return new WaitForSeconds(0.5f);
        VerificarVitoria();
    }

    private void AddCards()
    {
        GameObject SuaCarta = Instantiate(SeuCard, SuaMao.transform);
        GameObject CartaInimiga =  Instantiate(CardInimigo, MaoInimiga.transform);

        int SC = Random.Range(0, CurrentPossibleCards.Count);
        SuaCarta.GetComponent<BattleCard>().CardInfo = CurrentPossibleCards[SC];
        CurrentPossibleCards.RemoveAt(SC);
        int EC = Random.Range(0, CurrentPossibleCards.Count);
        CartaInimiga.GetComponent<BattleCard>().CardInfo = CurrentPossibleCards[EC];
        CurrentPossibleCards.RemoveAt(EC);

        SuaCarta.GetComponent<BattleCard>().YourCard = YourCardd.GetComponent<BattleCardObj>();
        CartaInimiga.GetComponent<BattleCard>().YourCard = enimyCardd.GetComponent<BattleCardObj>();

        SuaCarta.GetComponent<BattleCard>().BGC = this;
        CartaInimiga.GetComponent<BattleCard>().BGC = this;

    }
    private void VerificarVitoria()
    {
        if (YourPoints == 10)
        {
            Ganhou();
        }
        else if (EnimyPoints == 10)
        {
            Perdeu();
        }
        else
        {
            PodeJogar = true;
        }
    }
}
