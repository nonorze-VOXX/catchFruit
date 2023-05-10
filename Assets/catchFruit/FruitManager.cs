using System;
using System.Collections.Generic;
using System.Linq;
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
            fruitData.maxX = 2.35F;
            fruitData.minX = -4.8F;
            _nextFruitCounter = 0;
            _nextFruitTime = 0.01F;
            fruitData.tokenInstancesList = new Queue<GameObject>();
            fruitData.tokenInstancesList.Clear();
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
            if (fruitData.tokenInstancesList.Count == 0)
            {
                GameObject tmp = Instantiate(fruit, fruitContainer.transform);
                 fruitData.tokenInstancesList.Enqueue(tmp);
            }
            
            GameObject newFruit = fruitData.tokenInstancesList.First();
            fruitData.tokenInstancesList.Dequeue();
            var newPosition = new Vector3();
            newPosition.x = RandomX();
            newPosition.y = fruitData.fruitHeight;
            newFruit.transform.position = newPosition;
            Debug.Log(newFruit);
            Debug.Log("A");
            newFruit.gameObject.SetActive(true);
        }

        private float RandomX()
        {
            return Random.Range(fruitData.minX, fruitData.maxX);
        }
    }
}