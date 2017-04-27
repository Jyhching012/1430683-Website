﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GpuModel
/// </summary>
public class GpuModel
{
    public string InsertProduct(Product product)
    {
        try
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            db.Products.Add(product);
            db.SaveChanges();

            return product.GpuName + "was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }


    }

    public string UpdateProduct(int id, Product product)
    {
        try
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();

            //Retrieve from database
            Product p = db.Products.Find(id);

            p.GpuName = product.GpuName;
            p.Price = product.Price;
            p.GpuId = product.GpuId;
            p.Descriptionofgpu = product.Descriptionofgpu;
            p.Image = product.Image;

            db.SaveChanges();
            return product.GpuName + "was successfully updated";



        }
        catch (Exception e)
        {
            return "Error:" + e;
        }


    }

    public string DeleteProduct(int id)
    {
        try
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            Product product = db.Products.Find(id);

            db.Products.Attach(product);
            db.Products.Remove(product);
            db.SaveChanges();

            return product.GpuName + "was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }


    }



}