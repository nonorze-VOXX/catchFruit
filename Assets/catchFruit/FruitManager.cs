using System;
using System.Xml.Schema;
using UnityEngine;
using Random = UnityEngine.Random;

namespace catchFruit
{
    public class FruitManager : MonoBehaviour
    {
        public FruitData fruitData;
        public GameObject fruit;
        public GameObject fruitContainer;
        private float _nextFruitCounter;
        private float _nextFruitTime;
        private void Start()
        {
            Init();
        }

        private void Init()
        {
            fruitData.score = 0;
            fruitData.maxX = 10;
            fruitData.minX = 0;
            _nextFruitCounter = 0;
            _nextFruitTime = 4;
        }

        private void Update()
        {
            _nextFruitCounter += Time.deltaTime;
            if (_nextFruitCounter > _nextFruitTime)
            {
                _nextFruitCounter = 0;
                CreateFruit();
            }
        }

        private void CreateFruit()
        {
            GameObject newFruit = Instantiate(fruit, fruitContainer.transform);
            var newPosition = new Vector3();
            newPosition.x = RandomX();
            newPosition.y = fruitData.fruitHeight;
            newFruit.transform.position = newPosition;
        }

        private float RandomX()
        {
            return Random.Range(fruitData.minX, fruitData.maxX);
        }
    }
}