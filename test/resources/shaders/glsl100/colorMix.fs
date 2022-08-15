#version 100


precision mediump float;

// Input vertex attributes (from vertex shader)
varying vec2 fragTexCoord;
varying vec4 fragColor;

// Input uniform values
uniform sampler2D texture0;



// Input lighting values

uniform vec3 viewPos;
uniform vec4 fragColorR;
uniform vec4 fragColorG;
uniform vec4 fragColorB;

void main()
{
    //vec4 fragColorR = rgba(255,255,255,255);
    vec4 texelColor = texture2D(texture0, fragTexCoord);
    
    gl_FragColor = texelColor.r*fragColorR+texelColor.g*fragColorG+texelColor.b*fragColorB;
    gl_FragColor.a = texelColor.a;
    
}
