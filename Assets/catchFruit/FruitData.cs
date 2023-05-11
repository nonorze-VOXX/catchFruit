using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Platformer.Mechanics;
using UnityEngine;
using UnityEngine.UI;

namespace catchFruit
{
    [CreateAssetMenu(fileName = "fruitData", menuName = "fruitData", order = 0)]
    public class FruitData : ScriptableObject
    {
        public int score;
        public float minX;
        public float maxX;
        public float fruitHeight;

        public Queue<GameObject> tokenInstancesList;

        [SerializeField]
        public Sprite[] fruitPicture;
    }
}