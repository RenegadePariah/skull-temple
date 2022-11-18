#version 400 core

in vec3 position;

uniform mat4 transform;
uniform mat4 view;
uniform mat4 projection;


void main(void){
    vec4 world_pos=transform*vec4(position,1.0);
    vec4 view_pos=view*world_pos;
    gl_Position=projection*view_pos;

}