using System;
using System.Collections.Generic;
using UnityEngine;
using static ICards;
using Random = UnityEngine.Random;

public class Pickaxe : MonoBehaviour
{
    private ICards card;
    [SerializeField]
    private ICards[] deck;


    private int gameSize, deckSize;

    // Start is called before the first frame update
    void Start()
    {
        //InitializeGame();
        ShuffleDeck();
        DealCards();
    }

   /* public void InitializeGame()
    {
        foreach (ICards.numbers number in Enum.GetValues(typeof(ICards.numbers)))
        {
            foreach (ICards.colors color in Enum.GetValues(typeof(ICards.colors))) 
            { 
                deck.Add(number.ToString + color.ToString);
            }
        }
    }
    */
    private void ShuffleDeck()
    {
        
        //It shuffles the deck using the Fisher-Yates shuffle algorithm to randomize the card order.

       deckSize = deck.Length;  
       while (deckSize > 1) 
       {
            deckSize --;
            gameSize = Random.Range(0, deckSize + 1);
            ICards card = deck[gameSize];
            deck[gameSize] = deck[deckSize];
            deck[deckSize] = card;  
       }   
    }

    private void DealCards()
    {
        int hand = 7;
        for(int i = 0; i < hand; i++)
        {
            Debug.Log("Le joueur reçoit un " + deck[i]._color+ " de " + deck[i]._numbers);
        }
    }

   
}
