#version 330

// Input vertex attributes (from vertex shader)
in vec2 fragTexCoord;
in vec4 fragColor;
in vec3 fragPosition;
in vec3 fragNormal;

// Input uniform values
uniform sampler2D texture1;
uniform sampler2D texture0;
uniform vec4 colDiffuse;

// Output fragment color
out vec4 finalColor;

// NOTE: Add here your custom variables

#define     MAX_LIGHTS              4
#define     LIGHT_DIRECTIONAL       0
#define     LIGHT_POINT             1

// Input lighting values

uniform vec3 viewPos;
uniform vec4 fragColorR;
uniform vec4 fragColorG;
uniform vec4 fragColorB;

void main()
{
    //vec4 fragColorR = rgba(255,255,255,255);
    vec4 texelColor = texture2D(texture0, fragTexCoord);
    
    finalColor = texelColor.r*fragColorR+texelColor.g*fragColorG+texelColor.b*fragColorB;
    finalColor.a = texelColor.a;
    
}
