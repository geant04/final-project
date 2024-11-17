using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUtil
{
    public static Color HSVTransform(Color inColor, float h, float s, float v)
    {
        Vector3 hsv = new Vector3();
        Color.RGBToHSV(inColor, out hsv.x, out hsv.y, out hsv.z);
        hsv.x *= h;
        hsv.y *= s;
        hsv.z *= v;

        return Color.HSVToRGB(hsv.x, hsv.y, hsv.z);
    }
}
