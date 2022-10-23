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
uniform float fogDensity;

void main()
{
    // Texel color fetching from texture sampler
    

    

    vec4 texelColor = texture2D(texture0, fragTexCoord);
    vec4 texelColor1 = texture2D(texture1, fragTexCoord);
    
    
    if (texelColor1.r+fogDensity < 0.0) {
        //gl_FragColor = vec4(0.0,0.0,0.0,0.0);
        discard;
    }
    if (texelColor1.r+fogDensity > 1.0) {
        //gl_FragColor = vec4(0.0,0.0,0.0,0.0);
        finalColor = texelColor;
        
    }else{
    
        //finalColor = texelColor*texelColor1*vec4(2.0,2.0,0.0,1.0);
        finalColor = texelColor*(texelColor1.r+fogDensity);
    }

    
}
