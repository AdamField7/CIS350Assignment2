﻿/*
 * Adam Field
 * Assignment 6
 * inventory framework
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.MYFIRSTPERSONCONTROLLER.OOP_Scripts
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private InventoryItem item;
        public List<InventoryItem> inventory;

        // Use this for initialization
        void Start()
        {
            item = new InventoryItem();
            inventory = new List<InventoryItem>();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}