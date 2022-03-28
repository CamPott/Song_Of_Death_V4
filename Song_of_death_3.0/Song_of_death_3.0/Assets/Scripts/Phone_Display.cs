using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Phone_Display : MonoBehaviour
{
    [SerializeField]
    private Sprite[] Digits;

    [SerializeField]
    private Image[] Characters;

    public GameObject _SafeHinge;

    
    private string _CodeSeq;

    // Start is called before the first frame update
    void Start()
    {
        _CodeSeq = "";

        for (int i = 0; i <= Characters.Length -1; i++)
        {
            Characters[i].sprite = Digits[10];

        }

        Phone_ButtonPushed.ButtonPressed += AddDigitToCodeSequence;
    }

    private void AddDigitToCodeSequence(string digitEntered)
    {
        if (_CodeSeq.Length < 4)
        {
            switch (digitEntered)
            {
                case "Zero":
                    _CodeSeq += "0";
                    DisplayCodeSequence(0);
                    break;
                case "One":
                    _CodeSeq += "1";
                    DisplayCodeSequence(1);
                    break;
                case "Two":
                    _CodeSeq += "2";
                    DisplayCodeSequence(2);
                    break;
                case "Three":
                    _CodeSeq += "3";
                    DisplayCodeSequence(3);
                    break;
                case "Four":
                    _CodeSeq += "4";
                    DisplayCodeSequence(4);
                    break;
                case "Five":
                    _CodeSeq += "5";
                    DisplayCodeSequence(5);
                    break;
                case "Six":
                    _CodeSeq += "6";
                    DisplayCodeSequence(6);
                    break;
                case "Seven":
                    _CodeSeq += "7";
                    DisplayCodeSequence(7);
                    break;
                case "Eight":
                    _CodeSeq += "8";
                    DisplayCodeSequence(8);
                    break;
                case "Nine":
                    _CodeSeq += "9";
                    DisplayCodeSequence(9);
                    break;
            }
        }

        switch (digitEntered)
        {
            case "Delete":
                ResetDisplay();
                break;

            case "Tick":
                if (_CodeSeq.Length > 0)
                {
                    CheckResults();
                }
                break;
        }
    }

    private void DisplayCodeSequence(int digitJustEntered)
    {
        switch (_CodeSeq.Length)
        {
            case 1:
                Characters[0].sprite = Digits[10];
                Characters[1].sprite = Digits[10];
                Characters[2].sprite = Digits[10];
                Characters[3].sprite = Digits[digitJustEntered];
                break;
            case 2:
                Characters[0].sprite = Digits[10];
                Characters[1].sprite = Digits[10];
                Characters[2].sprite = Characters[3].sprite;
                Characters[3].sprite = Digits[digitJustEntered];
                break;
            case 3:
                Characters[0].sprite = Digits[10];
                Characters[1].sprite = Characters[2].sprite;
                Characters[2].sprite = Characters[3].sprite;
                Characters[3].sprite = Digits[digitJustEntered];
                break;
            case 4:
                Characters[0].sprite = Characters[1].sprite;
                Characters[1].sprite = Characters[2].sprite;
                Characters[2].sprite = Characters[3].sprite;
                Characters[3].sprite = Digits[digitJustEntered];
                break;

        }
    }

    private void CheckResults()
    {
        if (_CodeSeq == "5059")
        {
            Debug.Log("Correct");
            //GetComponent<Animator>().Play("Safe_Open");
            Destroy(_SafeHinge);
        }
        else
        {
            Debug.Log("Wrong!");
            ResetDisplay();
        }
    }

   
    private void ResetDisplay()
    {
        for (int i = 0; i <= Characters.Length - 1; i++)
        {
            Characters[i].sprite = Digits[10];
        }

        _CodeSeq = "";
    }

    private void OnDestroy()
    {
        Phone_ButtonPushed.ButtonPressed -= AddDigitToCodeSequence;
    }
}
