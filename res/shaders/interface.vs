#version 400 core

in vec2 position;

uniform mat4 transform;
uniform float tex_rotation;

out vec2 tex_coord;
void main(void){
	gl_Position = transform*vec4(position, 0.0, 1.0);
	vec2 p= vec2(position.x*cos(tex_rotation)-position.y*sin(tex_rotation),position.x*sin(tex_rotation)+position.y*cos(tex_rotation));
	tex_coord =vec2((p.x+1.0)/2.0, 1.0 - (p.y+1.0)/2.0);
}