using System;

namespace Silque.Geometry {
    public struct Quaternion {
        public float x {get; set;}
        public float y {get; set;}
        public float z {get; set;}
        public float angle {get; set;}

        public Quaternion(float x, float y, float z, float angle) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.angle = angle;
        }

        public Quaternion(Vector3 vector, float angle) {
            this.x = vector.x;
            this.y = vector.y;
            this.z = vector.z;
            this.angle = angle;
        }

        public static Quaternion zero {
            get => new Quaternion(0, 0, 0, 0);
        }

        public static Quaternion identity {
            get => new Quaternion(0,0,0,1);
        }
    }
}