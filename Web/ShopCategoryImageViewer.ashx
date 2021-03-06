<%@ WebHandler Language="C#" Class="ShopCategoryImageViewer" %>

using System;
using System.Web;
using OnlineShop.Common.Shop;
using OnlineShop.BusinessLogic.Shop;
using System.IO;

public class ShopCategoryImageViewer : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
        ShopCategory shopCategory = new ShopCategory();
        shopCategory.ImageID = int.Parse(context.Request.QueryString["ImageID"]);

        ProcessGetShopCategoryImage processGet =
            new ProcessGetShopCategoryImage();
        processGet.ShopCategory = shopCategory;

        Stream stream = null;

        processGet.Invoke();

        context.Response.ContentType = "image/jpeg";
        context.Response.Cache.SetCacheability(HttpCacheability.Public);
        context.Response.BufferOutput = false;

        int bufferSize = 1024 * 16;
        byte[] buffer = new byte[bufferSize];

        stream = processGet.ImageStream;       
        int count = stream.Read(buffer, 0, bufferSize);
                
        while(count>0)
        {
            context.Response.OutputStream.Write(buffer, 0, count);
            count = stream.Read(buffer, 0, bufferSize);
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}