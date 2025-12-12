Shader "Custom/HoleDepthMask"
{
    SubShader
    {
        Tags { "Queue"="Geometry-10" }   // force way before Geometry (2000)
        ColorMask 0
        ZWrite On
        Pass {}
    }
}
