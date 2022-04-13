using Controllers;
using Logic;
using Logic.Models;
using Services.Interfaces;
using UnityEngine;
using Views;
using Object = UnityEngine.Object;

namespace Services
{
    public class GameFactory : IGameFactory
    {
        private const string CellPath = "Cell";
        
        private readonly IAssetProvider _assetProvider;
        
        public GameFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        
        public Field CreateField()
        {
            var model = new Field(5, 5, new UniVector2(1f, 1f), new UniVector2(0f, 3f), this);
            return model;
        }

        public Cell CreateCell(UniVector2 coordinates, bool isAvailable)
        {
            var model = new Cell(coordinates, isAvailable);
            var pref = _assetProvider.LoadAsset<CellView>(CellPath);
            var view = Object.Instantiate(pref);
            var unused = new CellController(model, view);
            return model;
        }

        public GameObject CreateEmpty(string name) => 
            new GameObject(name);
    }
}