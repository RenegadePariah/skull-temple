#version 400 core

uniform vec3 color;
uniform vec3 clear_color;

out vec4 out_color;

void main(void){
    out_color=vec4(max(color,clear_color),1.0);
}