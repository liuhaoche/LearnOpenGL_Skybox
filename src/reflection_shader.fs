#version 330 core
in vec3 Normal;
in vec3 Position;

out vec4 FragColor;

uniform samplerCube skybox;
uniform vec3 cameraPos;

void main() {
    vec3 i = normalize(Position - cameraPos);
    vec3 o = reflect(i, normalize(Normal));
    FragColor = vec4(texture(skybox, o).rgb, 1.0);
}