﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
// Adding references of the logic layer to the service layer
using Warehouse_Prj.Logic;
using Warehouse_Prj.BDO;

namespace Warehouse_Prj.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class WarehouseService : IWarehouse
    {
        Warehouse_Logic warehouse_Logic = new Warehouse_Logic();

        public Warehouse GetWarehouse(int id)
        {
            // TODO: call business logic to retrieve warehouse

            var warehouse_BDO = warehouse_Logic.Get_Warehouse_By_ID(id);
            var warehouse = new Warehouse();

            // Translating productBDO to productDTO
            TranslateWarehouseBDOToWarehouseDTO(warehouse_BDO, warehouse);

            return warehouse;
            
            //warehouse.WarehouseID = id;
            //warehouse.WarehouseName = "fake warehouse name from service layer";
            //warehouse.WarehouseAddressStreet = "fake one from service layer";
            //warehouse.WarehouseAddressCity = "fake one from service layer";
            //warehouse.WarehouseAddressState = "fake one from service layer";
            //warehouse.WarehouseAddressZipcode = "fake one from service layer";
            //return warehouse;
        }


        public bool UpdateWarehouse(Warehouse warehouse, ref string message)
        {
            var result = true;

            // Warehouse name cannot be empty
            if (string.IsNullOrEmpty(warehouse.WarehouseName))
            {
                message = "Warehouse name cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(warehouse.WarehouseAddressStreet))
            {
                message = "Warehouse street address cannot be empty";
                result = false;
            }

            else if (string.IsNullOrEmpty(warehouse.WarehouseAddressCity))
            {
                message = "Warehouse city address cannot be empty";
                result = false;
            }

            else if (string.IsNullOrEmpty(warehouse.WarehouseAddressState))
            {
                message = "Warehouse state address cannot be empty";
                result = false;
            }

            else if (string.IsNullOrEmpty(warehouse.WarehouseAddressZipcode))
            {
                message = "Warehouse Zipcode cannot be empty";
                result = false;
            }

            else
            {
                var warehouse_BDO = new Warehouse_BDO();
                TranslateWarehouseDTOToWarehouseBDO(warehouse, warehouse_BDO);
                return warehouse_Logic.Update_Warehouse(ref warehouse_BDO, ref message);

            }

            return result;
        }

        private void TranslateWarehouseBDOToWarehouseDTO(Warehouse_BDO warehouse_BDO, Warehouse warehouse)
        {
            warehouse.WarehouseID = warehouse_BDO.Warehouse_ID;
            warehouse.WarehouseName = warehouse_BDO.Warehouse_Name;
            warehouse.WarehouseAddressStreet = warehouse_BDO.Street;
            warehouse.WarehouseAddressCity = warehouse_BDO.City;
            warehouse.WarehouseAddressState = warehouse_BDO.State;
            warehouse.WarehouseAddressZipcode = warehouse_BDO.Zipcode;
        }

        private void TranslateWarehouseDTOToWarehouseBDO(Warehouse warehouse, Warehouse_BDO warehouse_BDO)
        {
            warehouse_BDO.Warehouse_ID = warehouse.WarehouseID;
            warehouse_BDO.Warehouse_Name = warehouse.WarehouseName;
            warehouse_BDO.Street = warehouse.WarehouseAddressStreet;
            warehouse_BDO.City = warehouse.WarehouseAddressCity;
            warehouse_BDO.State = warehouse.WarehouseAddressState;
            warehouse_BDO.Zipcode = warehouse.WarehouseAddressZipcode;
        }



    }
}
