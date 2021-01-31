namespace CardGame.Infrastructure.Contracts
{
    public interface IDeckOfCards
    {
        void PlayACard ();
        void Shuffle ();
        void Reset ();
        void DisplayCardsInDeck ();
    }
}
