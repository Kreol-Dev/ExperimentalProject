Shader "Map/TerrainShader"
{
	Properties
	{
		_AtlasTex ("Data Texture", 2D) = "white" {}
		_MainTex ("Atlas Texture", 2D) = "white" {}
		_Color ("Tint", Color) = (1,1,1,1)
		_Size ("Size", int) = 32
		[MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
	}

	SubShader
	{
		Tags
		{ 
			"Queue"="Transparent" 
			"IgnoreProjector"="True" 
			"RenderType"="Transparent" 
			"PreviewType"="Plane"
			"CanUseSpriteAtlas"="True"
		}

		Cull Off
		Lighting Off
		ZWrite Off
		Blend One OneMinusSrcAlpha

		Pass
		{
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 2.0
			#pragma multi_compile _ PIXELSNAP_ON
			#pragma multi_compile _ ETC1_EXTERNAL_ALPHA
			#include "UnityCG.cginc"
			
			struct appdata_t
			{
				float4 vertex   : POSITION;
				float4 color    : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex   : SV_POSITION;
				fixed4 color    : COLOR;
				float2 texcoord  : TEXCOORD0;
			};
			
			fixed4 _Color;

			v2f vert(appdata_t IN)
			{
				v2f OUT;
				OUT.vertex = UnityObjectToClipPos(IN.vertex);
				OUT.texcoord = IN.texcoord;
				OUT.color = IN.color * _Color;
				#ifdef PIXELSNAP_ON
				OUT.vertex = UnityPixelSnap (OUT.vertex);
				#endif

				return OUT;
			}

			sampler2D _MainTex;
			sampler2D _AtlasTex;
			int _Size;
			

			fixed4 frag(v2f IN) : SV_Target
			{
				float2 tileOffset = clamp(IN.texcoord * _Size - float2((int)(IN.texcoord.x * _Size), (int)(IN.texcoord.y * _Size)) - float2(0.5, 0.5), 0, 0.25);
				float2 tileInverseOffset = clamp(float2(0.5, 0.5) - (IN.texcoord * _Size - float2((int)(IN.texcoord.x * _Size), (int)(IN.texcoord.y * _Size))), 0, 0.25);
				fixed4 c_north = tex2D (_AtlasTex, IN.texcoord + float2(0, -0.005));
				fixed4 c_east = tex2D (_AtlasTex, IN.texcoord + float2(-0.005, 0));
				fixed4 c_west = tex2D (_AtlasTex, IN.texcoord + float2(0.005, 0));
				fixed4 c_south = tex2D (_AtlasTex, IN.texcoord+ float2(0, 0.005));
				fixed4 c_center = tex2D (_AtlasTex, IN.texcoord);
				fixed4 north = tex2D(_MainTex,  c_north / 2 + IN.texcoord / 4) * tileInverseOffset.y;
				fixed4 east = tex2D(_MainTex,   c_east  / 2 + IN.texcoord / 4) * tileInverseOffset.x ;
				fixed4 west = tex2D(_MainTex,   c_west  / 2 + IN.texcoord / 4) * tileOffset.x ;
				fixed4 south = tex2D(_MainTex,  c_south / 2 + IN.texcoord / 4) * tileOffset.y;
				float full_alpha = tileOffset.y + tileOffset.x + tileInverseOffset.x + tileInverseOffset.y;
				fixed4 center = tex2D(_MainTex, c_center / 2 + IN.texcoord / 4) * max(0, 1 - full_alpha );
				fixed4 final_colour = (north + east + south + west + center );
				final_colour.a = 1;
				return final_colour;
			}
		ENDCG
		}
	}
}
