
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2_OOP_201902
{
    public class Deck
    {
        List<Card> cards;

        public Deck(List<Card> cards)
        {
            cards = new List<Card>() {};
        }


        public void AddCombatCard(CombatCard combatCard) {
            cards.Add(combatCard);
        }
        public void AddSpecialCard(SpecialCard specialCard) {
            cards.Add(specialCard);
        }
        public void DestroyCombatCard(int cardId) {
            cards[CombatCard].Remove(cardId);
        }
        public void DestroySpecialCard(int cardId) {
            cards[SpecialCard].Remove(cardId);
        }
        public void Shuffle() { 
            throw new NotImplementedException();
        }
    }
}
