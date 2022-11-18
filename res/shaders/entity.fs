#version 400 core

in vec3 pass_position;
in vec3 pass_normal;

uniform vec3 color;
uniform vec3 clear_color;

const int light_nb=3;
uniform vec3 light_pos[light_nb];
uniform vec3 light_col[light_nb];

out vec4 out_color;


const float resolution=12;
void main(void){


    //vec3 p=pass_position*resolution;
    //p=(p-mod(p,1.0))/resolution + (1.0/(2.0*resolution));
    ////float s=distance(light_pos,p)/20.0;
    ////s=clamp(s,0.0,1.0);
    //vec3 work_color=vec3(0.0,0.0,0.0);
    //float v;
    //vec3 light_c;
    //vec3 light_p;
    //float min_v=10000.0;
    //for(int i=0;i<11;i++) {
    //    light_c=vec3(light_col[i].x,light_col[i].y,light_col[i].z);
    //    light_p=vec3(light_pos[i].x,light_pos[i].y,light_pos[i].z);
    //    v=distance(light_p,p);
    //    //work_color=mix(work_color,light_c,1.0-clamp(v,0.0,1.0));
    //    if(min_v>v){
    //        min_v=v;
    //        work_color=light_c*v;
    //    }
    //}
    //out_color=vec4(work_color,1.0);
    //out_color=vec4(light_col[0],light_col[1],light_col[2],1.0);

    vec3 p=pass_position*resolution;
    p=(p-mod(p,1.0))/resolution + (1.0/(2.0*resolution));
    vec3 work_color=vec3(clear_color);
    for(int i=0;i<light_nb;i++){
        vec3 to_light=normalize(vec3(light_pos[i]-p));
        float overlap=dot(normalize(pass_normal),to_light);
        float brightness=max(overlap,0.0);
        float reach=distance(light_pos[i],p);
        work_color=work_color+light_col[i]*(brightness/(reach*reach));
    }


    out_color=vec4(clamp(work_color,0.0,1.0), 1.0);
    //out_color=vec4((pass_normal+1.0)/2.0, 1.0);
}