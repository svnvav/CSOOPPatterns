using System;

namespace CSOOPPatterns.Behavioral.Memento
{
    public class Hero
    {
        public struct State
        {
            public float x, y, z;
        }
        
        public class Memento
        {
            private State _state;

            public State State => _state;

            public Memento(Hero hero)
            {
                _state = hero._state;
            }
        }

        private State _state;

        public Memento Save()
        {
            return new Memento(this);
        }

        public void Restore(Memento memento)
        {
            _state = memento.State;
        }

        public void Move()
        {
            _state.x += 1;
            _state.y += 2;
            _state.z += 3;
        }
    }
}