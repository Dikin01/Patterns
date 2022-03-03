namespace Lab2
{
    internal class BoardDirector
    {
        public BoardBuilder Builder { get; set; }
        public BoardDirector(BoardBuilder builder)
        {
            Builder = builder;
        }

        public BoardAnyCar CreateBoard()
        {
            Builder.CreatBoard();
            Builder.AddDriver();
            Builder.AddPassenger();
            return Builder.GetBoard();
        }
    }
}
