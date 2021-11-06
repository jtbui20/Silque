using Silque.Geometry;

namespace Silque.ParticleEngine {
    public class Particle {
        Vector3 _position;
        Vector3 _velocity;
        
        Quaternion _angle;
        Quaternion _angularvelocity;

        System.Drawing.Color _color;
        int _energy;
        float _size;
        int life;

        internal Particle() {
            
        }

        internal void Update() {
            _position += _velocity;
        }
    }
}