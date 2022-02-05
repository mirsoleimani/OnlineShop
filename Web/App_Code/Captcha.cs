using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

/// <summary>
/// Summary description for Captcha
/// </summary>
public class Captcha
{
    private string _text;
    private int _width;
    private int _hieght;
    private Random _random;
    private string _fontFamily;
    private Bitmap _image;
    
    public Captcha(string str, int width, int height)
    {
        this._text = str;
        SetImageDimension(width, height);
        GenerateImage();

    }
    public Captcha(string str, int width, int height, string fontFamily)
    {
        this._text = str;
        SetFontFamily(fontFamily);
        SetImageDimension(width, height);
        GenerateImage();
    }

    private void SetFontFamily(string fontFamily)
    {
        try
        {
            Font font = new Font(fontFamily, 12F);
            this._fontFamily = fontFamily;
            font.Dispose();
        }
        catch
        {
            this._fontFamily = System.Drawing.FontFamily.GenericSerif.Name;
        }
    }

    ~Captcha()
    {
        Dispose(false);
    }

    private void Dispose()
    {
        GC.SuppressFinalize(this);
        this.Dispose(true);
    }

    private void Dispose(bool disposing)
    {
        if (disposing)
            this._image.Dispose();
    }
    private void GenerateImage()
    {
        
    }

    private void SetImageDimension(int width, int height)
    {
        if (width >= 0 && height >= 0)
        {
            this._width = width;
            this._hieght = height;
        }

    }
}
