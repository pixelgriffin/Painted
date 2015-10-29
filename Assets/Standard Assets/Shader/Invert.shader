Shader "Custom/Invert" {
Properties
    {
        _Color ("Tint Color", Color) = (1,1,1,1)
    }
   
    SubShader
    {
        Tags { "Queue" = "Transparent" }//Keep it opaque
 
        Pass
        {
           ZWrite On
           ColorMask 0
        }
        Blend OneMinusDstColor OneMinusSrcAlpha //the part that actually inverts
        BlendOp Add
       
        Pass
        {
       
CGPROGRAM

//From this point on it's just a basic shader

#pragma vertex vert
#pragma fragment frag

uniform float4 _Color;
 
struct vertexInput
{
    float4 vertex: POSITION;
    float4 color : COLOR;  
};
 
struct fragmentInput
{
    float4 pos : SV_POSITION;
    float4 color : COLOR0;
};
 
fragmentInput vert( vertexInput i )
{
    fragmentInput o;
    o.pos = mul(UNITY_MATRIX_MVP, i.vertex);
    o.color = _Color;
    return o;
}
 
half4 frag( fragmentInput i ) : COLOR
{
    return i.color;
}
 
ENDCG
}
}
}