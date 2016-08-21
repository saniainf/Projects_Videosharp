namespace TagGame
{
    interface IPlayer
    {
        void Run();
        void TaggedIt();
        void NoTaggedIt();
        bool Touching(object obj);
    }
}
