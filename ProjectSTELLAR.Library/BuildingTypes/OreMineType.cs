﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStellar.Library
{
    [Serializable]
    public class OreMineType : BuildingType
    {
        int _cost;
        int _coin;
        int _wood;
        int _rock;
        int _metal;
        int _water;
        int _electricity;
        int _pollution;
        int _nbPeople;
        int _rockProduction;
        string _type;
        List<Building> _list;
        int _size;
        int _rockCapacity;
        int _maxRockCapacity = 0;

        public OreMineType()
        {
            _rock = 0;
            _wood = 15;
            _coin = 25;
            _metal = 5;
            _electricity = 10;
            _water = 10;
            _pollution = 20;
            _nbPeople = 15;
            _cost = 0;
            _type = "resource";
            _size = 4;
            _list = new List<Building>();
            _rockProduction = 80;
            _rockCapacity = 800;
        }

        public override void CreateInstance(int x, int y, ResourcesManager resources, Map map)
        {
            if (!resources.CheckResourcesNeeded(this)) throw new ArgumentException("Ressources manquantes.");

            resources.UpdateWhenCreate(this);
            Building building = new OreMine(this, x, y);
            map.AddBuilding(x, y, building);
            _list.Add(building);
            MaxRockCapacity += _maxRockCapacity;
        }

        public override int Cost => _cost;
        public override int Coin => _coin;
        public override int Wood => _wood;
        public override int Rock => _rock;
        public override int Metal => _metal;
        public override int Water => _water;
        public override int Electricity => _electricity;
        public override int Pollution => _pollution;
        public override int NbPeople => _nbPeople;
        public override string Type => _type;
        public override List<Building> List => _list;

        public int RockProduction => _rockProduction;

        public override int NbBuilding => _list.Count;
        public override int Size => _size;

        public int MaxRockCapacity
        {
            get { return _maxRockCapacity; }
            set { _maxRockCapacity = value; }
        }
    }
}