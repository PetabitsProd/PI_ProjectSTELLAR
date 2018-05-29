﻿using ProjectStellar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStellar.Library
{
        public class CityManager
        {
        int _totalCharges;
        int _totalPollution;
        int _totalTaxes;
        int _nbBuilding;
        static  Map _ctx;
        


        public CityManager(Map ctx)
        {
            _ctx = ctx;
        }

        CityHelper c = new CityHelper(_ctx);
       

        public int CityBalance
        {
            get { return CityTaxes - CityCharges; }
        }

        public int CityCharges
        {
            get {
             
                return _totalCharges = (c.GetSpaceStation.MoneyWinOrLost * NbSpaceStation) + (c.GetPumpingStation.MoneyWinOrLost * NbPumpingStation) + (c.GetPowerPlant.MoneyWinOrLost * NbPowerPlant) + (c.GetPoliceStation.MoneyWinOrLost * NbPoliceStation) + (c.GetHospital.MoneyWinOrLost * NbHospital) + (c.GetFireStation.MoneyWinOrLost * NbFireStation) + (c.GetCityHall.MoneyWinOrLost * NbCityHall); }
        }

        public int CityTaxes
        {
            get { return _totalTaxes = (c.GetHut.MoneyWinOrLost * NbHut) + (c.GetHouse.MoneyWinOrLost * NbHouse) + (c.GetFlat.MoneyWinOrLost * NbFlat);  }
        }

        public int CityPollution
        {
            get { return _totalPollution = (c.GetHut.AirPollution * NbHut) + (c.GetHouse.AirPollution * NbHouse) + (c.GetFlat.AirPollution * NbFlat) + (c.GetSpaceStation.AirPollution * NbSpaceStation) + (c.GetPumpingStation.AirPollution * NbPumpingStation) + (c.GetPowerPlant.AirPollution * NbPowerPlant) + (c.GetPoliceStation.AirPollution * NbPoliceStation) + (c.GetHospital.AirPollution * NbHospital) + (c.GetFireStation.AirPollution * NbFireStation) + (c.GetMetalMine.AirPollution * NbMetalMine) + (c.GetOreMine.AirPollution * NbOreMine) + (c.GetSawmill.AirPollution * NbSawMill); }

        }

        internal int NbHut
        {
            get
            {
                for(int i=0; i < c.ListBuilding.Count; i++)
                {
                    _totalCharges += c.ListBuilding[i].Cost * NbBuilding(c.ListBuilding[i]);
                }
                return _totalCharges;

                //return _totalCharges = (c.GetSpaceStation.Cost * NbSpaceStation) 
                //    + (c.GetPumpingStation.Cost * NbPumpingStation) 
                //    + (c.GetPowerPlant.Cost * NbPowerPlant) 
                //    + (c.GetPoliceStation.Cost * NbPoliceStation) 
                //    + (c.GetHospital.Cost * NbHospital) 
                //    + (c.GetFireStation.Cost * NbFireStation) 
                //    + (c.GetCityHall.Cost * NbCityHall);
            }
        }

        public int CityPollution
        {
            get
            {
                for (int i = 0; i < c.ListBuilding.Count; i++)
                {
                    _totalPollution += c.ListBuilding[i].Pollution * NbBuilding(c.ListBuilding[i]);
                }
                return _totalPollution;

                //return _totalPollution = (c.GetHut.Pollution * NbHut) 
                //    + (c.GetHouse.Pollution * NbHouse) 
                //    + (c.GetFlat.Pollution * NbFlat) 
                //    + (c.GetSpaceStation.Pollution * NbSpaceStation) 
                //    + (c.GetPumpingStation.Pollution * NbPumpingStation) 
                //    + (c.GetPowerPlant.Pollution * NbPowerPlant) 
                //    + (c.GetPoliceStation.Pollution * NbPoliceStation) 
                //    + (c.GetHospital.Pollution * NbHospital) 
                //    + (c.GetFireStation.Pollution * NbFireStation) 
                //    + (c.GetMetalMine.Pollution * NbMetalMine) 
                //    + (c.GetOreMine.Pollution * NbOreMine) 
                //    + (c.GetSawmill.Pollution * NbSawMill);
            }

        }

        public int CityTaxes
        {
            get
            {
                return _totalTaxes = (c.GetHut.Cost * NbBuilding(c.GetHut)) 
                    + (c.GetHouse.Cost * NbBuilding(c.GetHouse)) 
                    + (c.GetFlat.Cost * NbBuilding(c.GetFlat));
            }
        }


        internal int NbBuilding(BuildingType buildingType)
        {
            for(int i = 0; i < c.ListBuilding.Count; i++)
            {
                _nbBuilding = c.ListBuilding[i].List.Count;
            }
            return _nbBuilding;
        }
    }
}

            get