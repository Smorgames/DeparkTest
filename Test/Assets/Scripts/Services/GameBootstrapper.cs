using Logic;
using Services.Interfaces;
using UnityEngine;

namespace Services
{
    public class GameBootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            IMath math = new Math();
            UniVector2.InitMathService(math);
            
            IAssetProvider assetProvider = new AssetProvider();
            IGameFactory gameFactory = new GameFactory(assetProvider);
            gameFactory.CreateField();
        }
    }
}