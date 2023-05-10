using UnityEngine;

namespace catchFruit
{
    [CreateAssetMenu(fileName = "fruitData", menuName = "fruitData", order = 0)]
    public class FruitData : ScriptableObject
    {
        public int score;
        public float minX;
        public float maxX;
        public float fruitHeight;

    }
}