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

struct MaterialProperty {
    vec3 color;
    int useSampler;
    sampler2D sampler;
};

struct Light {
    int enabled;
    int type;
    vec3 position;
    vec3 target;
    vec4 color;
};

// Input lighting values

uniform vec3 viewPos;
uniform float fogDensity;

void main()
{
    // Texel color fetching from texture sampler
    vec4 texelColor = texture(texture0, fragTexCoord);
    vec4 texelColor1 = texture(texture1, fragTexCoord);
    if (texelColor1.a < 0.25) discard;

    finalColor = texelColor;
}
