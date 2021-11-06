using System;

namespace Silque.Geometry {
    public struct Vector3 {
        public float x { get; set;}
        public float y { get; set;}
        public float z { get; set;}

        public Vector3 (float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 zero {
             get => new Vector3(0, 0, 0);
        }

        public static Vector3 one {
            get => new Vector3(1, 1, 1);
        }

        public static Vector3 up {
            get => new Vector3(0, 1, 0);
        }
        public static Vector3 down {
            get => new Vector3(0, -1, 0);
        }

        public static Vector3 left {
            get => new Vector3(-1, 0, 0);
        }

        public static Vector3 right {
            get => new Vector3(1, 0, 0);
        }

        public static Vector3 forward {
            get => new Vector3(0, 0, 1);
        }
        
        public static Vector3 backward {
            get => new Vector3(0, 0, -1);
        }

        public static Vector3 identity {
            get => new Vector3(1, 1, 1);
        }

        public static Vector3 operator+ (Vector3 a, Vector3 b) {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3 operator- (Vector3 a, Vector3 b) {
            return new Vector3(a.x - b.x, a.y - b.y, a.z + b.z);
        }

        public static float operator* (Vector3 a, Vector3 b) {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }

        public static Vector3 operator*(Vector3 a, float b) {
            return new Vector3(a.x * b, a.y * b, a.z * b);
        }

        public static Vector3 operator*(Vector3 a, int b) {
            return a * (float)b;
        }

        public static Vector3 operator/(Vector3 a, float b) {
            return new Vector3(a.x / b, a.y / b, a.z / b);
        }

        public static Vector3 operator/(Vector3 a, int b) {
            return a / (float)b;
        }

        public static bool operator<(Vector3 a, Vector3 b) {
            return (a.x < b.x) && (a.y < b.y);
        }

        public static bool operator<=(Vector3 a, Vector3 b) {
            return (a.x <= b.x) && (a.y <= b.y);
        }
        
        public static bool operator>(Vector3 a, Vector3 b) {
            return (a.x > b.x) && (a.y > b.y);
        }

        public static bool operator>=(Vector3 a, Vector3 b) {
            return (a.x >= b.x) && (a.y >= b.y);
        }

        public float Magnitude { get => (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); }
        public Vector3 Direction { get => (Magnitude != 0) ? this * (1 / Magnitude) : this; }

        public float AngleBetweenVector(Vector3 target, bool degrees = true, bool truezero = true) {
            double output = Math.Acos((float)((this * target) / (Magnitude * target.Magnitude)));
            output *= (degrees) ? 180 / Math.PI : 1;
            output = (truezero) ? ((this.y < 0) ? -1 * output : output) : output;
            return (float)Math.Round(output, 2);
        }
    }
}