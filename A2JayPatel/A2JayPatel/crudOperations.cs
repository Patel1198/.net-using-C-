using System;
using System.Collections.Generic;
using System.Text;

namespace A2JayPatel
{
    class crudOperations
    {
        //private fields
        private NorthwindDataSetTableAdapters.DataTableTableAdapter _dtProducts;
        private NorthwindDataSet.DataTableDataTable _tblProducts;
        private NorthwindDataSetTableAdapters.CategoriesTableAdapter _dtProduct;
        private NorthwindDataSet.CategoriesDataTable _tblProduct;
        private NorthwindDataSetTableAdapters.SuppliersTableAdapter _sdtProduct;
        private NorthwindDataSet.SuppliersDataTable _stblProduct;

        //constructor
        public crudOperations()
        {
            _dtProducts = new NorthwindDataSetTableAdapters.DataTableTableAdapter();
            _tblProducts = new NorthwindDataSet.DataTableDataTable();
            _dtProduct = new NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            _tblProduct = new NorthwindDataSet.CategoriesDataTable();
            _sdtProduct = new NorthwindDataSetTableAdapters.SuppliersTableAdapter();
            _stblProduct = new NorthwindDataSet.SuppliersDataTable();
        }

        //to print all the products with details
        public void GetAllProducts()
        {
            _tblProducts = _dtProducts.GetProducts();

            // display products
            Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine($"{"ProductID",-10} {"ProductName",-35} {"CategoryName",-18} {"CompanyName",-40} {"UnitPrice",-12} {"UnitsInStock"}\n");
            foreach (var row in _tblProducts)
            {
                Console.WriteLine($"{row.ProductID,-10} {row.ProductName,-35} {row.CategoryName,-18} {row.CompanyName,-40} {row.UnitPrice.ToString("C"),-12} {row.UnitsInStock}");
            }
        }


        // method to print a single product based on its ID
        public void GetProductById(int pID)
        {
            _tblProducts = _dtProducts.GetProducts();

            // find a row based on its primary key
            var row = _tblProducts.FindByProductID(pID);

            if (row != null)
            {
                // display products
                Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
                Console.WriteLine($"{"ProductID",-10} {"ProductName",-35} {"CategoryName",-18} {"CompanyName",-40} {"UnitPrice",-12} {"UnitsInStock"}\n");
                Console.WriteLine($"{row.ProductID,-10} {row.ProductName,-35} {row.CategoryName,-18} {row.CompanyName,-40} {row.UnitPrice.ToString("C"),-12} {row.UnitsInStock}");
            }
            else
                Console.WriteLine("\nInvalid Product ID. Please try again.");
        }

        // method to get a product by its name
        public void GetProductByName(string pName)
        {
            _tblProducts = _dtProducts.GetProductByName(pName);
            
            if (_tblProducts.Count > 0)
            {

                // display products
                Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
                Console.WriteLine($"{"ProductID",-10} {"ProductName",-35} {"CategoryName",-18} {"CompanyName",-40} {"UnitPrice",-12} {"UnitsInStock"}\n");
                foreach (var row in _tblProducts)
                {
                    Console.WriteLine($"{row.ProductID,-10} {row.ProductName,-35} {row.CategoryName,-18} {row.CompanyName,-40} {row.UnitPrice.ToString("C"),-12} {row.UnitsInStock}");
                }
            }
            else
                Console.WriteLine("Invalid Product Name. Please try again.");
        }

        // method to print a single product based on its ID
        public void GetCategoryBycId(int cID)
        {

           
            _tblProducts = _dtProducts.GetByCategoryID(cID);
            if (_tblProducts.Count > 0)
            {
                // display products
                Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
                Console.WriteLine($"{"ProductID",-10} {"ProductName",-35} {"CategoryName",-18} {"CompanyName",-40} {"UnitPrice",-12} {"UnitsInStock"}\n");
                // find a row based on its primary key

                foreach (var row in _tblProducts)
                {




                    Console.WriteLine($"{row.ProductID,-10} {row.ProductName,-35} {row.CategoryName,-18} {row.CompanyName,-40} {row.UnitPrice.ToString("C"),-12} {row.UnitsInStock}");
                }
            }
            else
                Console.WriteLine("\nInvalid Category ID. Please try again.");
            }


            //method to insert a new product

             public void InsertProduct(string pName,int cID,short sID,short uPrice,short uInStocks)
             {
            _dtProducts.InsertProduct(pName,cID,sID,uPrice,uInStocks);
             }

            public void CategoryList() {

            _tblProduct = _dtProduct.GetByCategories();

            // display products
            Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine($"{"Category ID",-18} {"CategoryName"} \n");
            foreach (var row in _tblProduct)
            {
                
                Console.WriteLine($"{row.CategoryID,5}{ row.CategoryName,25}");
            }
        }

            public void SuppliersList() {

            _stblProduct = _sdtProduct.GetSuppliersByID();

            // display products
            Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine($"\t{"Suppliers ID",-30} {"CompanyName"}\n");
            foreach (var row in _stblProduct)
            {
                Console.WriteLine($"\t{row.SupplierID,-30} {row.CompanyName}");
            }
        }
    }


    }


