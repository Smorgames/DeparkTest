using Logic;
using Logic.Models;
using UnityEngine;

namespace Services.Interfaces
{
    public interface IGameFactory
    {
        Field CreateField();
        Cell CreateCell(UniVector2 coordinates, bool isAvailable);
        GameObject CreateEmpty(string name);
    }
}