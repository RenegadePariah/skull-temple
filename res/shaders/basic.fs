#version 400 core

in vec2 _texcoords;

uniform sampler2D sampler;

out vec4 out_color;

void main(void){
    out_color=texture(sampler,_texcoords);
    out_color.w=1.0;
}