#version 400 core

in vec3 position;
in vec2 texcoords;

uniform mat4 transform;

out vec2 _texcoords;

void main(void){
    gl_Position=transform*vec4(position,1.0);
    _texcoords=texcoords;

}