using System.Collections.Generic;

namespace Silque.ParticleEngine {
    public class ParticleSystem {
        int SysType;
        List<Particle> particles;

        internal void Update() {
            foreach (Particle p in particles) {
                p.Update();
            }
        }
        
    }
}