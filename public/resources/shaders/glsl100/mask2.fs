

precision mediump float;

// Input vertex attributes (from vertex shader)

varying vec2 fragTexCoord;



// Input uniform values
uniform sampler2D texture1;
uniform sampler2D texture0;
uniform vec4 colDiffuse;




void main()
{
    // Texel color fetching from texture sampler
    vec4 texelColor = texture2D(texture0, fragTexCoord);
    vec4 texelColor1 = texture2D(texture1, fragTexCoord);
    
    
    if (texelColor1.a < 0.2) {
        //gl_FragColor = vec4(0.0,0.0,0.0,0.0);
        discard;
    }
    
    gl_FragColor = texelColor*vec4(2.0,2.0,0.0,1.0);
        
    
}
