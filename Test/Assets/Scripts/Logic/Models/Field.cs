using Services.Interfaces;

namespace Logic.Models
{
    public class Field
    {
        private readonly Cell[,] _cells;

        public Field(int length, int height, UniVector2 cellSize, UniVector2 offset, IGameFactory gameFactory)
        {
            _cells = new Cell[length, height];

            var startSpawnPoint = StartSpawnPoint(length, height, cellSize);

            for (var x = 0; x < length; x++)
            for (var y = 0; y < height; y++)
            {
                var cell =  gameFactory.CreateCell(new UniVector2(x, y), true);
                SetCellPosition(cellSize, startSpawnPoint, offset, x, y, cell);

                _cells[x, y] = cell;
            }
        }

        private UniVector2 StartSpawnPoint(int length, int height, UniVector2 cellSize)
        {
            var x = (1 - length) * (cellSize.X / 2);
            var y = (1 - height) * (cellSize.Y / 2);
            return new UniVector2(x, y);
        }

        private void SetCellPosition(UniVector2 cellSize, UniVector2 startSpawnPoint, UniVector2 offset, int x, int y, Cell cell)
        {
            var xCell = startSpawnPoint.X + cellSize.X * x + offset.X;
            var yCell = startSpawnPoint.Y + cellSize.Y * y + offset.Y;
            var cellPosition = new UniVector2(xCell, yCell);
            cell.SetPosition(cellPosition);
        }
    }
}