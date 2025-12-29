#version 330 core
out vec4 FragColor;

struct Light {
    vec3 diffuse;
};

uniform Light light;

void main()
{
    //FragColor = vec4(1.0); // set all 4 vector values to 1.0
    FragColor = vec4(light.diffuse,0);
}