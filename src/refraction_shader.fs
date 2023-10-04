#version 330 core
in vec3 Normal;
in vec3 Position;

out vec4 FragColor;

uniform samplerCube skybox;
uniform vec3 cameraPos;

void main() {
    float ratio = 1.00 / 1.52;
    vec3 i = normalize(Position - cameraPos);
    vec3 o = refract(i, normalize(Normal), ratio);
    FragColor = vec4(texture(skybox, o).rgb, 1.0);
}