﻿using NUnit.Framework;
using ProjectStellar.Library;
using System;

namespace ProjectStellar
{
    [TestFixture]
    public class RunnerTests
    {
//      [Test]

//      public void create_building()
//      {
//          Map map = new Map(12,15);
//          BuildingType sut = new Hut(map);
        
//          Assert.That(sut.RockNeeded, Is.EqualTo(25));
//          Assert.That(sut.WoodNeeded, Is.EqualTo(50));
//          Assert.That(sut.StellarCoinNeeded, Is.EqualTo(15));
//          Assert.That(sut.MetalNeeded, Is.EqualTo(0));
//          Assert.That(sut.ElectricityConsume, Is.EqualTo(5));
//          Assert.That(sut.WaterConsume, Is.EqualTo(5));
//          Assert.That(sut.AirPollution, Is.EqualTo(0));
//          Assert.That(sut.NbPeople, Is.EqualTo(5));

//      }

//      [Test]

//      public void check_if_destroy_a_building_if_it_exits_work_well()
//      {
//          Map map = new Map(12, 15);
//          BuildingType sut = new Hut(map);

//          sut.IsBuild = false;

//        //  Assert.Throws<ArgumentException>(() => sut.Destroy());

//          BuildingType sut1 = new Hut(map);
      
//          Assert.That(sut1.IsBuild, Is.True);
//          //sut1.Destroy();
//          //Assert.That(sut1.IsBuild, Is.False);
//      }

//      [Test]

//      public void add_a_building_in_the_array_when_you_create_it()
//      {
        
//          Map map = new Map(12,15);
//          FireStation sut = new FireStation(map);

//          map.AddBuilding(3, 2);

//          Assert.That(map.CheckBuilding(3, 2), Is.True);
//          Assert.That(map.CheckBuilding(3, 8), Is.False);
//          Assert.That(map.Boxes[3,2], Is.EqualTo(sut));

//      }

//      [Test]

//      public void remove_a_building_from_the_array_when_it_is_destroy()
//      {
//          Map map = new Map(12,15);
//          Hut sut = new Hut(map);

//          map.AddBuilding(3, 2);

//          Assert.That(map.CheckBuilding(3, 2), Is.True);
//          Assert.That(map.CheckBuilding(3, 8), Is.False);
//          Assert.That(map.Boxes[3, 2], Is.EqualTo(sut));

//          map.RemoveBuilding(3, 2);

//          Assert.That(map.CheckBuilding(3, 2), Is.False);
//          Assert.That(map.Boxes[3, 2], Is.EqualTo(null));

//      }

//      [Test]

//      public void create_a_building_and_add_it_in_the_array_with_the_create_function()
//      {
//            Map map = new Map(12,15);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            Hut hut = new Hut(map);
//            House house = new House(map);
//            Flat flat = new Flat(map);

      
//          buildingFactory.CreateBuilding(1, 1,hut);
//          buildingFactory.CreateBuilding(1, 2, house);
//          buildingFactory.CreateBuilding(1, 4, house);
//          buildingFactory.CreateBuilding(1, 3, flat);
//          buildingFactory.CreateBuilding(1, 5, flat);
//          buildingFactory.CreateBuilding(1, 6, flat);


//          Assert.That(map.CheckBuilding(1, 1), Is.True);
//          Assert.That(map.CheckBuilding(1, 2), Is.True);
//          Assert.That(map.CheckBuilding(1, 4), Is.True);
//          Assert.That(map.CheckBuilding(1, 3), Is.True);
//          Assert.That(map.CheckBuilding(1, 5), Is.True);
//          Assert.That(map.CheckBuilding(1, 6), Is.True);



//      }

//      [Test]

//     public void when_a_building_is_detroy_remove_it_from_the_array_and_decrement_the_coumpteur()
//     {
//         Map map = new Map(12,15);
//         Hut sut = new Hut(map);
//         House house = new House(map);
//         Flat flat = new Flat(map);
//         ResourcesManager resourcesManager = new ResourcesManager(map);
        
//         BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);



//         buildingFactory.CreateBuilding(1, 1, sut);
//         buildingFactory.CreateBuilding(1, 2, house);
//         buildingFactory.CreateBuilding(1, 4, house);
//         buildingFactory.CreateBuilding(1, 3, flat);
//         buildingFactory.CreateBuilding(1, 5, flat);
//         buildingFactory.CreateBuilding(1, 6, flat);


//         Assert.That(map.CheckBuilding(1, 1), Is.True);
//         Assert.That(map.CheckBuilding(1, 2), Is.True);
//         Assert.That(map.CheckBuilding(1, 4), Is.True);
//         Assert.That(map.CheckBuilding(1, 3), Is.True);
//         Assert.That(map.CheckBuilding(1, 5), Is.True);
//         Assert.That(map.CheckBuilding(1, 6), Is.True);



//         buildingFactory.DestroyBuilding(1, 1, sut);
//         buildingFactory.DestroyBuilding(1, 4, house);
//         buildingFactory.DestroyBuilding(1, 3, flat);
//         buildingFactory.DestroyBuilding(1, 5, flat);

//         Assert.That(map.CheckBuilding(1, 1), Is.False);
//         Assert.That(map.CheckBuilding(1, 4), Is.False);
//         Assert.That(map.CheckBuilding(1, 3), Is.False);
//         Assert.That(map.CheckBuilding(1, 5), Is.False);
   
//     }

//     [Test]

//     public void the_dictionnary_of_building_is_update_as_it_should()
//     {
//         Map map = new Map(15,16);
//         Hut hut = new Hut(map);
//         House house = new House(map);
//         Flat flat = new Flat(map);
//            MetalMine metalMine = new MetalMine(map, 70);
//         ResourcesManager resourcesManager = new ResourcesManager(map);

//         BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);



//         Assert.That(map.NbBuilding.ContainsKey(hut), Is.False);
//         Assert.That(map.NbBuilding.ContainsKey(house), Is.False);
//         Assert.That(map.NbBuilding.ContainsKey(flat), Is.False);

//         buildingFactory.CreateBuilding(1, 1, hut);
//         buildingFactory.CreateBuilding(2, 4,house);
//         buildingFactory.CreateBuilding(1, 6, flat);

//            map.NbBuilding.TryGetValue(hut, out int te);

//         Assert.That(te, Is.EqualTo(1));
//         Assert.That(map.NbBuilding.ContainsKey(house), Is.True);
//         Assert.That(map.NbBuilding.ContainsKey(flat), Is.True);

//         buildingFactory.CreateBuilding(2, 8, house);
//         map.NbBuilding.TryGetValue(house, out int h);


//         Assert.That(h, Is.EqualTo(2));

//            buildingFactory.CreateBuilding(7,7, metalMine);
//            map.NbBuilding.TryGetValue(metalMine, out int mm);

//            Assert.That(mm, Is.EqualTo(1));


//            buildingFactory.CreateBuilding(1, 8, flat);
//            buildingFactory.CreateBuilding(1, 9,flat);
//            map.NbBuilding.TryGetValue(flat, out int f);

//            Assert.That(f, Is.EqualTo(3));

//         buildingFactory.DestroyBuilding(1, 6, flat);
//            map.NbBuilding.TryGetValue(flat, out int fa);

//            Assert.That(fa, Is.EqualTo(2));

//         buildingFactory.DestroyBuilding(1, 1, hut);
//            map.NbBuilding.TryGetValue(hut, out int tes);

//            Assert.That(tes, Is.EqualTo(0));


//     }

//    [Test]



//     public void calcul_the_tax_from_all_the_non_public_bat()
//     {
//         Map map = new Map(15,16);
//         CityManager manager = new CityManager(map);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            CityHelper cityHelper = new CityHelper(map);
//            Hut hut = new Hut(map);
//            House house = new House(map);
//            Flat flat = new Flat(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            buildingFactory.CreateBuilding(1, 2, cityHelper.GetHouse);
//            //ildingFactory.CreateBuilding(1, 1, hut);
//            //ildingFactory.CreateBuilding(1, 4, house);
//            //ildingFactory.CreateBuilding(1, 3, flat);
//            //ildingFactory.CreateBuilding(1, 5, flat);
//            //ildingFactory.CreateBuilding(1, 6, flat);



//            Assert.That(manager.CityTaxes, Is.EqualTo(45));
//     }

//     [Test]

//     public void the_resources_are_initialize_as_they_should()
//     {
//         Map map = new Map(10,10);

//         ResourcesManager resourcesManager = new ResourcesManager(map);

//         resourcesManager.UpdateResources();

//         Assert.That(resourcesManager.NbResources["wood"], Is.EqualTo(500));
//         Assert.That(resourcesManager.NbResources["rock"], Is.EqualTo(500));
//         Assert.That(resourcesManager.NbResources["metal"], Is.EqualTo(150));

//     }

//     [Test]

//     public void the_resources_update_as_they_should_but_not_in_function_of_the_time()
//     {
//         Map map = new Map(10, 10);
//            Sawmill sawmill = new Sawmill(map, 70);
//            OreMine oreMine = new OreMine(map, 70);
//            MetalMine metalMine = new MetalMine(map, 70);
//         ResourcesManager resourcesManager = new ResourcesManager(map);
//         BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);


//         resourcesManager.UpdateResources();

//         Assert.That(resourcesManager.NbResources["wood"], Is.EqualTo(500));
//         Assert.That(resourcesManager.NbResources["rock"], Is.EqualTo(500));
//         Assert.That(resourcesManager.NbResources["metal"], Is.EqualTo(150));

//         buildingFactory.CreateBuilding(2, 6, sawmill);
//         resourcesManager.UpdateResources();



//         Assert.That(resourcesManager.NbResources["wood"], Is.EqualTo(500));

//         buildingFactory.CreateBuilding(1, 5, oreMine);
//         buildingFactory.CreateBuilding(1, 6, oreMine);
//         resourcesManager.UpdateResources();

//         Assert.That(resourcesManager.NbResources["rock"], Is.EqualTo(485));

//         buildingFactory.CreateBuilding(1, 7, metalMine);
//         buildingFactory.CreateBuilding(1, 8, metalMine);
//         buildingFactory.CreateBuilding(1, 9, metalMine);
//         resourcesManager.UpdateResources();

     
//         Assert.That(resourcesManager.NbResources["metal"], Is.EqualTo(135));
     

//     }

//      [Test]

//      public void the_city_helper_is_working()
//      {
//          Resolution _resolution = new Resolution();
//          Game game = new Game(0, _resolution, false);
//          Map map = new Map(20, 20);
//          //game.Initialize();

//          CityHelper city = new CityHelper(map);
//          Assert.That(city.ListBuilding.Count, Is.EqualTo(28));
//      }

//      [Test]
//      public void calcul_the_pollution_of_the_city()
//      {
//         Resolution _resolution = new Resolution();
//         Game game = new Game(0, _resolution, false);
//         Map map = new Map(20, 20);
//         //game.Initialize();
//         CityManager cityManager = new CityManager(map);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            CityHelper cityHelper = new CityHelper(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            buildingFactory.CreateBuilding(1, 2, cityHelper.GetHouse);
//            //buildingFactory.CreateBuilding(1, 1, hut);
//            //buildingFactory.CreateBuilding(1, 4, house);
//            //buildingFactory.CreateBuilding(1, 3, flat);
//            //buildingFactory.CreateBuilding(1, 5, flat);
//            //buildingFactory.CreateBuilding(1, 6, flat);


//            Assert.That(cityManager.CityPollution, Is.EqualTo(10));

//}

//        [Test]
//        public void create_building_is_working()
//        {
//            Map map = new Map(20, 20);
//            ResourcesManager resourcesManager = new ResourcesManager(map);

//            Hut hut = new Hut(map);

//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);
//            buildingFactory.CreateBuilding(10, 2, hut);
//            buildingFactory.CreateBuilding(10, 3, hut);


//            map.NbBuilding.TryGetValue(hut, out int te);

//            Assert.That(te, Is.EqualTo(2));
//            Assert.That(map.Boxes[10, 2], Is.EqualTo(hut));
//            Assert.That(resourcesManager.NbResources["wood"], Is.EqualTo(400));
//        }

//        [Test]

//        public void check_electricity_and_water_production()
//        {
//            Map map = new Map(20, 20);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            CityHelper cityHelper = new CityHelper(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            buildingFactory.CreateBuilding(2, 4, cityHelper.GetPowerPlant);

//            Assert.That(resourcesManager.Electricity, Is.EqualTo(220));

//            buildingFactory.CreateBuilding(2, 1, cityHelper.GetPowerPlant);
//            Assert.That(resourcesManager.Electricity, Is.EqualTo(440));

//            buildingFactory.CreateBuilding(3, 1, cityHelper.GetPumpingStation);
//            Assert.That(resourcesManager.Water, Is.EqualTo(250));

//            buildingFactory.DestroyBuilding(2, 1, cityHelper.GetPowerPlant);
//            Assert.That(resourcesManager.Electricity, Is.EqualTo(220));


//        }

//        [Test]

//        public void check_electricity_consomation()
//        {
//            Map map = new Map(20, 20);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            CityHelper cityHelper = new CityHelper(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            buildingFactory.CreateBuilding(1, 2, cityHelper.GetCityHall);
//            buildingFactory.CreateBuilding(1, 3, cityHelper.GetFireStation);
//            buildingFactory.CreateBuilding(1, 4, cityHelper.GetFlat);
//            buildingFactory.CreateBuilding(1, 5, cityHelper.GetHospital);
//            buildingFactory.CreateBuilding(1, 6, cityHelper.GetHouse);
//            buildingFactory.CreateBuilding(1, 7, cityHelper.GetHut);
//            buildingFactory.CreateBuilding(1, 8, cityHelper.GetMetalMine);
//            buildingFactory.CreateBuilding(1, 9, cityHelper.GetOreMine);
//            buildingFactory.CreateBuilding(1, 10, cityHelper.GetPoliceStation);
//            buildingFactory.CreateBuilding(1, 12, cityHelper.GetPumpingStation);
//            buildingFactory.CreateBuilding(1, 13, cityHelper.GetSawmill);
//            buildingFactory.CreateBuilding(1, 14, cityHelper.GetSpaceStation);
//            buildingFactory.CreateBuilding(1, 15, cityHelper.GetWareHouse);

//            Assert.That(resourcesManager.ElectricityConsume, Is.EqualTo(325));


//        }

//        [Test]

//        public void check_water_consommation()
//        {
//            Map map = new Map(20, 20);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            CityHelper cityHelper = new CityHelper(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            buildingFactory.CreateBuilding(1, 2, cityHelper.GetCityHall);
//            buildingFactory.CreateBuilding(1, 3, cityHelper.GetFireStation);
//            buildingFactory.CreateBuilding(1, 4, cityHelper.GetFlat);
//            buildingFactory.CreateBuilding(1, 5, cityHelper.GetHospital);
//            buildingFactory.CreateBuilding(1, 6, cityHelper.GetHouse);
//            buildingFactory.CreateBuilding(1, 7, cityHelper.GetHut);
//            buildingFactory.CreateBuilding(1, 8, cityHelper.GetMetalMine);
//            buildingFactory.CreateBuilding(1, 9, cityHelper.GetOreMine);
//            buildingFactory.CreateBuilding(1, 10, cityHelper.GetPoliceStation);
//            buildingFactory.CreateBuilding(1, 11, cityHelper.GetPowerPlant);
//            buildingFactory.CreateBuilding(1, 12, cityHelper.GetPumpingStation);
//            buildingFactory.CreateBuilding(1, 13, cityHelper.GetSawmill);
//            buildingFactory.CreateBuilding(1, 14, cityHelper.GetSpaceStation);
//            buildingFactory.CreateBuilding(1, 15, cityHelper.GetWareHouse);

//            Assert.That(resourcesManager.WaterConsume, Is.EqualTo(370));
//        }

//        [Test]

//        public void check_water_balance()
//        {
//            Map map = new Map(20, 20);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            CityHelper cityHelper = new CityHelper(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            buildingFactory.CreateBuilding(2, 4, cityHelper.GetPumpingStation);
//            buildingFactory.CreateBuilding(2, 6, cityHelper.GetPumpingStation);

//            Assert.That(resourcesManager.Water, Is.EqualTo(500));

//            buildingFactory.CreateBuilding(1, 2, cityHelper.GetCityHall);
//            buildingFactory.CreateBuilding(1, 3, cityHelper.GetFireStation);
//            buildingFactory.CreateBuilding(1, 4, cityHelper.GetFlat);
//            buildingFactory.CreateBuilding(1, 5, cityHelper.GetHospital);
//            buildingFactory.CreateBuilding(1, 6, cityHelper.GetHouse);
//            buildingFactory.CreateBuilding(1, 7, cityHelper.GetHut);
//            buildingFactory.CreateBuilding(1, 8, cityHelper.GetMetalMine);
//            buildingFactory.CreateBuilding(1, 9, cityHelper.GetOreMine);
//            buildingFactory.CreateBuilding(1, 10, cityHelper.GetPoliceStation);
//            buildingFactory.CreateBuilding(1, 11, cityHelper.GetPowerPlant);
//            buildingFactory.CreateBuilding(1, 13, cityHelper.GetSawmill);
//            buildingFactory.CreateBuilding(1, 14, cityHelper.GetSpaceStation);
//            buildingFactory.CreateBuilding(1, 15, cityHelper.GetWareHouse);

//            Assert.That(resourcesManager.WaterBalance, Is.EqualTo(130));


//        }

//        [Test]

//        public void check_electricity_balance()
//        {
//            Map map = new Map(20, 20);
//            ResourcesManager resourcesManager = new ResourcesManager(map);
//            CityHelper cityHelper = new CityHelper(map);
//            BuildingFactory buildingFactory = new BuildingFactory(map, resourcesManager);

//            buildingFactory.CreateBuilding(2, 4, cityHelper.GetPowerPlant);
//            buildingFactory.CreateBuilding(2, 6, cityHelper.GetPowerPlant);


//            buildingFactory.CreateBuilding(1, 2, cityHelper.GetCityHall);
//            buildingFactory.CreateBuilding(1, 3, cityHelper.GetFireStation);
//            buildingFactory.CreateBuilding(1, 4, cityHelper.GetFlat);
//            buildingFactory.CreateBuilding(1, 5, cityHelper.GetHospital);
//            buildingFactory.CreateBuilding(1, 6, cityHelper.GetHouse);
//            buildingFactory.CreateBuilding(1, 7, cityHelper.GetHut);
//            buildingFactory.CreateBuilding(1, 8, cityHelper.GetMetalMine);
//            buildingFactory.CreateBuilding(1, 9, cityHelper.GetOreMine);
//            buildingFactory.CreateBuilding(1, 10, cityHelper.GetPoliceStation);
//            buildingFactory.CreateBuilding(1, 13, cityHelper.GetSawmill);
//            buildingFactory.CreateBuilding(1, 14, cityHelper.GetSpaceStation);
//            buildingFactory.CreateBuilding(1, 15, cityHelper.GetWareHouse);

//            Assert.That(resourcesManager.ElectricityBalance, Is.EqualTo(145));


//        }

        [Test]

        public void check_the_apparition_of_fire()
        {
            //Map map = new Map(12,32);
            //FireStationType fireStationType = new FireStationType();
            //HouseType houseType = new HouseType();
            //HouseType house = new HouseType();
            //ResourcesManager resourcesManager = new ResourcesManager(map);
            //fireStationType.CreateInstance(2, 5, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);
            //house.CreateInstance(1, 3, resourcesManager, map);


            //Fire fire = new Fire(map);

            //fire.FireProbability = 1;
            //fire.BuildingOnFire = house.List[1];
            //fire.NewFire();

            //Assert.That(house.List[1].OnFire, Is.EqualTo(true));





        }
    }
}


