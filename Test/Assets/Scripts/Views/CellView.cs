using Logic;
using UnityEngine;

namespace Views
{
    public class CellView : MonoBehaviour
    {
        public void SetPosition(UniVector2 position) => 
            transform.position = position.ToVector2();
    }
}