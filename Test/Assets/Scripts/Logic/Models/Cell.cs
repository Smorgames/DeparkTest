namespace Logic.Models
{
    public class Cell
    {
        public UniVector2 Coordinates { get; }
        public bool IsAvailable { get; }
        public Transform Transform { get; }

        public Cell(UniVector2 coordinates, bool isAvailable)
        {
            Transform = new Transform();
            Coordinates = coordinates;
            IsAvailable = isAvailable;
        }

        public void SetPosition(UniVector2 position)
        {
            Transform.Position = position;
            Transform.OnPositionChanged?.Invoke();
        }
    }
}