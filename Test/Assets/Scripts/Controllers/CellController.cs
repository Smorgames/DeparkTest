using Logic.Models;
using Views;

namespace Controllers
{
    public class CellController
    {
        public Cell Model { get; }
        public CellView View { get; }

        public CellController(Cell model, CellView view)
        {
            Model = model;
            View = view;

            Subscriptions();
        }

        private void Subscriptions() => 
            Model.Transform.OnPositionChanged += ModelPositionChanged;

        private void ModelPositionChanged() => 
            View.SetPosition(Model.Transform.Position);
    }
}