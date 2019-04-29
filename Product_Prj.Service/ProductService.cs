﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Warehouse_Prj.Logic;
using Warehouse_Prj.BDO;
using Category_Prj.Service;

namespace Product_Prj.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ProductService : IProduct
    {
        // Getting the product from the business logic layer 
        Product_Logic product_Logic = new Product_Logic();

        public Product GetProductByID(int id)
        {
            var product_BDO = product_Logic.Get_Product_By_ID(id);
            var product = new Product();
            product.Category = new Category();
            
            // Translating productBDO to productDTO
            TranslateProductBDOToProductDTO(product_BDO, product);

            return product;
        }
        public Product GetProductByUPC(long upc)
        {
            var product_BDO = product_Logic.Get_Product_By_UPC(upc);
            var product = new Product();
            product.Category = new Category();

            // Translating productBDO to productDTO
            TranslateProductBDOToProductDTO(product_BDO, product);

            return product;
        }

        public bool Create_Product(Product product_, ref string msg)
        {
            bool result = false;
            Product_BDO product_BDO = new Product_BDO();
            product_BDO.Category = new Category_BDO();

            TranslateProductDTOToProductBDO(product_, product_BDO);

            result = product_Logic.Create_Product(product_BDO, ref msg);

            return result;
        }

        public bool UpdateProductByID(Product product)
        {
            var result = true;

            // Checking to see if price is valid 
            if (product.UnitPrice <= 0)
            {
                
                result = false;
            }

            // UPC cannot be empty 
            else if (product.UPC <= 0)
            {
                
                result = false;
            }

            // Product name cannot be empty
            else if (string.IsNullOrEmpty(product.ProductName))
            {
                
                result = false;
            }

            // categoryID cannot be empty 
            else if (product.Category.Category_ID == 0)
            {
                
                result = false;
            }

            else
            {
                // TODO: call business logic layer to update product
                Product_BDO product_BDO = new Product_BDO();
                product_BDO.Category = new Category_BDO();

                TranslateProductDTOToProductBDO(product, product_BDO);

                
                return product_Logic.Update_Product_By_ID(ref product_BDO);
               
            }

            return result;
        }

        /*
        // GetAllCategories Method 
        // Creating a service for geting a list of all available categories of products at the DB

        public List<Category> GetAllCategories()
        {
            // Calling the business-layer to retrieve category
            List<Category_BDO> category_BDOs = Category_Logic.Get_All_Categories();
            List<Category> category = new List<Category>();
            Category c = new Category();

            foreach (Category_BDO cat in category_BDOs)
            {
                // Translating categoryBDO to categoryDTO
                TranslateCategoryBDOToCAtegoryDTO(cat, c);
                category.Add(c);
            }
            return category;
        }
        */



        // Translation method from ProductBDO to ProductDTO
        private void TranslateProductBDOToProductDTO(Product_BDO product_BDO, Product product)
        {
            product.ProductID = product_BDO.Product_ID;
            product.ProductName = product_BDO.Product_Name;
            product.Category.Category_ID = product_BDO.Category.Category_ID;
            product.Category.Category_Name = product_BDO.Category.Category_Name;
            product.Category.Category_Description = product_BDO.Category.Category_Description;
            product.UPC = product_BDO.Product_UPC;
            product.UnitPrice = product_BDO.Product_Price;
        }

        // Translation method from ProductDTO to ProductBDO 
        private void TranslateProductDTOToProductBDO(Product product,Product_BDO product_BDO)
        {
            product_BDO.Product_ID = product.ProductID;
            product_BDO.Product_Name = product.ProductName;
            product_BDO.Category.Category_ID = product.Category.Category_ID;
            product_BDO.Category.Category_Name = product.Category.Category_Name;
            product_BDO.Category.Category_Description = product.Category.Category_Description;
            product_BDO.Product_UPC = product.UPC;
            product_BDO.Product_Price = product.UnitPrice;
        }



    }
}
