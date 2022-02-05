<%@ WebHandler Language="C#" Class="ShopImageViewer" %>

using System;
using System.Web;
using System.IO;

using OnlineShop.BusinessLogic.Shop;
using OnlineShop.Common.Shop;

public class ShopImageViewer : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
        OnlineShop.Common.Shop.Shop shop = new OnlineShop.Common.Shop.Shop();
        shop.ImageData.ImageID = int.Parse(context.Request.QueryString["ImageID"]);

        ProcessGetShopImageByID processGet =
            new ProcessGetShopImageByID();
        processGet.Shop = shop;
        
        Stream stream = null;
        processGet.Invoke();

        context.Response.ContentType = "image/jpeg";
        context.Response.Cache.SetCacheability(HttpCacheability.Public);
        context.Response.BufferOutput = false;

        int bufferSize = 1024 * 16;
        byte[] buffer = new byte[bufferSize];

        stream = processGet.ImageStream;
        int count = stream.Read(buffer, 0, bufferSize);

        while (count > 0)
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