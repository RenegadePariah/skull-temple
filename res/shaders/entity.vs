#version 400 core

in vec3 position;
in vec3 normal;

uniform mat4 transform;
uniform mat4 view;
uniform mat4 projection;

out vec3 pass_position;
out vec3 pass_normal;
out float pass_screen_height;

void main(void){
    vec4 world_pos=transform*vec4(position,1.0);
    vec4 view_pos=view*world_pos;
    gl_Position=projection*view_pos;
    pass_position=world_pos.xyz-vec3(0.001);
    pass_normal=normal;
}