using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GpuSpecsModel
/// </summary>
public class GpuSpecsModel
{
    public string Insertproductspec(ProductSpec productspec)
    {
        try
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            db.ProductSpecs.Add(productspec);
            db.SaveChanges();

            return productspec.GpuId + "was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }


    }

    public string Updateproductspec(int id, ProductSpec productspec)
    {
        try
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();

            //Retrieve from database
            ProductSpec p = db.ProductSpecs.Find(id);

            p.GpuId = productspec.GpuId;


            db.SaveChanges();
            return productspec.GpuId + "was successfully updated";



        }
        catch (Exception e)
        {
            return "Error:" + e;
        }


    }

    public string Deleteproductspec(int id)
    {
        try
        {
            db_1430683_co5027_productEntities db = new db_1430683_co5027_productEntities();
            ProductSpec productspec = db.ProductSpecs.Find(id);

            db.ProductSpecs.Attach(productspec);
            db.ProductSpecs.Remove(productspec);
            db.SaveChanges();

            return productspec.GpuId + "was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }


    }


}