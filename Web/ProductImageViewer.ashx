<%@ WebHandler Language="C#" Class="ProductImageViewer" %>

using System;
using System.Web;
using System.IO;
public class ProductImageViewer : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        OnlineShop.Common.Product.Product product = new OnlineShop.Common.Product.Product();
        product.ImageID = OnlineShop.Operational.Utilities.QueryStringInt("ImageID");

        OnlineShop.BusinessLogic.Product.ProcessGetProductImageByID processGet =
            new OnlineShop.BusinessLogic.Product.ProcessGetProductImageByID();
        processGet.Product = product;

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

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}