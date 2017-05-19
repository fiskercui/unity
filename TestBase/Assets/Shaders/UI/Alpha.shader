Shader "Kod/UI/Transparent"
{
	Properties
	{
		_MainTex ("Main Texture", 2D) = "white" {}
	}

	Category
	{
		Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
		Blend SrcAlpha OneMinusSrcAlpha
		Cull Off Lighting Off ZWrite Off Fog { Color (0,0,0,0) }
		
		BindChannels 
		{
			Bind "Color", color
			Bind "Vertex", vertex
			Bind "TexCoord", texcoord
		}
		
		SubShader 
		{
			Fog { Mode Off }
			Pass 
			{
				SetTexture [_MainTex] 
				{
					combine texture * primary
				}
			}
		}
	}
}