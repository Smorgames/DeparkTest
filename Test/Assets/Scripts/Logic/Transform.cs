using System;
using Logic.Interfaces;

namespace Logic
{
    public class Transform : ITransform
    {
        public Action OnPositionChanged;
        public Action OnDirectionChanged;
        
        public UniVector2 Position
        {
            get => _position;
            set
            {
                if (_position == value)
                    return;
                
                _position = value;
                OnPositionChanged?.Invoke();
            }
        }
        private UniVector2 _position;
        
        public UniVector2 Direction
        {
            get => _direction;
            set
            {
                if (_direction == value)
                    return;
                
                _direction = value;
                OnDirectionChanged?.Invoke();
            }
        }
        private UniVector2 _direction;

        public Transform()
        {
            _position = new UniVector2();
            _direction = new UniVector2();
        }

        public Transform(UniVector2 position, UniVector2 direction)
        {
            _position = position;
            _direction = direction;
        }
    }
}