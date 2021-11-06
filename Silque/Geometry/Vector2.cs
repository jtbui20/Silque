using System;

namespace Silque.Geometry
{
    public struct Vector2
    {
        public float x { get; }
        public float y { get; }

        public Vector2(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

        public static Vector2 zero {
            get => new Vector2(0, 0);
        }

        public static Vector2 one {
            get => new Vector2(1, 1);
        }

        public static Vector2 up {
            get => new Vector2(0, 1);
        }
        public static Vector2 down{
            get => new Vector2(0, -1);
        }

        public static Vector2 left {
            get => new Vector2(-1, 0);
        }

        public static Vector2 right {
            get => new Vector2(1, 0);
        }

        public static Vector2 operator+ (Vector2 a, Vector2 b) {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator- (Vector2 a, Vector2 b) {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static float operator* (Vector2 a, Vector2 b) {
            return (a.x * b.x) + (a.y * b.y);
        }

        public static Vector2 operator*(Vector2 a, float b) {
            return new Vector2(a.x * b, a.y * b);
        }

        public static Vector2 operator*(Vector2 a, int b) {
            return a * (float)b;
        }

        public static Vector2 operator/(Vector2 a, float b) {
            return new Vector2(a.x / b, a.y / b);
        }

        public static Vector2 operator/(Vector2 a, int b) {
            return a / (float)b;
        }

        public static bool operator<(Vector2 a, Vector2 b) {
            return (a.x < b.x) && (a.y < b.y);
        }

        public static bool operator<=(Vector2 a, Vector2 b) {
            return (a.x <= b.x) && (a.y <= b.y);
        }
        
        public static bool operator>(Vector2 a, Vector2 b) {
            return (a.x > b.x) && (a.y > b.y);
        }

        public static bool operator>=(Vector2 a, Vector2 b) {
            return (a.x >= b.x) && (a.y >= b.y);
        }

        public float Magnitude { get => (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); }
        public Vector2 Direction { get => (Magnitude != 0) ? this * (1 / Magnitude) : this; }

        public float AngleBetweenVector(Vector2 target, bool degrees = true, bool true_zero = true) {
            double output = Math.Acos((float)((this * target) / (Magnitude * target.Magnitude)));
            output *= (degrees) ? 180 / Math.PI : 1;
            output = (true_zero) ? ((y < 0) ? -1 * output : output) : output;
            return (float)Math.Round(output, 2);
        }
    }
}