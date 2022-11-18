#version 400 core

in vec2 tex_coord;

uniform sampler2D tex;
uniform vec3 mask;

out vec4 out_color;

void main(void){
    out_color=texture(tex,tex_coord)-vec4(mask,0.0);
    if(out_color.w<0.5)discard;
}