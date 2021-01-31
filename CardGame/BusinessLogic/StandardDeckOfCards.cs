using CardGame.Infrastructure.Contracts;
using CardGame.Infrastructure.Extensions;
using CardGame.Models;
using System;
using System.Collections.Generic;

namespace CardGame.BusinessLogic
{
    public class StandardDeckOfCards : IDeckOfCards
    {
        #region Private Fields

        private List<Card> _deckOfCards;

        #endregion

        #region Constructor

        public StandardDeckOfCards ()
        {
            // Initialize card deck and shuffle
            BuildCardCollection();
            Shuffle();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Remove card from top of list once it is played
        /// </summary>
        public void PlayACard ()
        {
            Console.WriteLine($"Card Played is: {_deckOfCards[0].Rank} of {_deckOfCards[0].Suit}");
            _deckOfCards.Remove(_deckOfCards[0]);
        }

        /// <summary>
        /// Shuffle the deck of cards replacing two cards at random position
        /// and for random number of times/replacements
        /// </summary>
        public void Shuffle ()
        {
            Random randomNumberGenerator = new Random();

            int numberOfReplacements = randomNumberGenerator.Next(100, 1000);

            for (int replacement = 0; replacement < numberOfReplacements; replacement++)
            {
                int firstPositionToReplaceAt = randomNumberGenerator.Next(0, _deckOfCards.Count);
                int secondPositionToReplaceAt = randomNumberGenerator.Next(0, _deckOfCards.Count);

                Card firstCardToReplace = _deckOfCards[firstPositionToReplaceAt];
                Card secondCardToReplace = _deckOfCards[secondPositionToReplaceAt];
                Card temp = firstCardToReplace;

                firstCardToReplace = secondCardToReplace;
                secondCardToReplace = temp;

                _deckOfCards[firstPositionToReplaceAt] = firstCardToReplace;
                _deckOfCards[secondPositionToReplaceAt] = secondCardToReplace;
            }
        }

        /// <summary>
        /// Restart the game
        /// </summary>
        public void Reset ()
        {
            BuildCardCollection();
            Shuffle();
        }

        public void DisplayCardsInDeck ()
        {
            foreach (Card card in _deckOfCards)
            {
                Console.WriteLine($"Suit: {card.Suit} - Value: {card.Rank}");
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Build the Deck of Card Collection to play game
        /// </summary>
        private void BuildCardCollection ()
        {
            _deckOfCards = new List<Card>();

            foreach (int suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (int cardValue in Enum.GetValues(typeof(CardRank)))
                {
                    _deckOfCards.Add(new Card
                    {
                        Rank = cardValue.ToString().ToEnum<CardRank>(),
                        Suit = suit.ToString().ToEnum<Suit>()
                    }); ;
                }
            }
        }

        #endregion
    }
}
